using Aplicacao.NFe.NSIntegration.Parameters;
using Aplicacao.NFe.NSIntegration.Returns;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Threading;

namespace Aplicacao.NFe.NSIntegration
{
    class NFeAPI{
        private const String token = "";
        private const String CNPJ = "";
        private String urlEnvioNFe;
	    private String urlStatusProcessamento;
	    private String urlDownloadNFe;
        private String urlCancelamento;
        private String urlConsultaSituacao;
        private String urlCartaCorrecao;
        private String urlDownloadEvento;
        private String urlInutilizacao;
        private String urlDownloadInutilizacao;
        private String urlConsultaContribuinte;
        private String urlConsultaStatusWSSefaz;
        private String urlEnvioNFeEmail;
        private String urlPrevia;
        private int isStatusOK = 200;

        public NFeAPI(){
			this.urlEnvioNFe = "https://nfe.ns.eti.br/nfe/issue";
			this.urlStatusProcessamento = "https://nfe.ns.eti.br/nfe/issue/status";
			this.urlDownloadNFe = "https://nfe.ns.eti.br/nfe/get";
            this.urlCancelamento = " https://nfe.ns.eti.br/nfe/cancel";
            this.urlConsultaSituacao = "https://nfe.ns.eti.br/nfe/stats";
            this.urlCartaCorrecao = "https://nfe.ns.eti.br/nfe/cce";
            this.urlDownloadEvento = "https://nfe.ns.eti.br/nfe/get/event";
            this.urlInutilizacao = "https://nfe.ns.eti.br/nfe/inut";
            this.urlDownloadInutilizacao = "https://nfe.ns.eti.br/nfe/get/inut";
            this.urlConsultaContribuinte = "https://nfe.ns.eti.br/util/conscad";
            this.urlConsultaStatusWSSefaz = "https://nfe.ns.eti.br/util/wssefazstatus";
            this.urlEnvioNFeEmail = "https://nfe.ns.eti.br/util/resendemail";
            this.urlPrevia = "https://nfe.ns.eti.br/util/preview/nfe";
        }

        public String emissaoSincrona(String conteudo, String tpDown = "X", int tpAmb=2, Boolean saveLocal = false, Boolean printCEAN = false, String caminho = "", Boolean isShow = false)
        {
            String retornoEmissaoString = emitirNFe(conteudo);
            EmissaoReturn retornoEmissao = JsonConvert.DeserializeObject<EmissaoReturn>(retornoEmissaoString);
            StatusProcessamentoResult retornoProcessamento;

            if (retornoEmissao.status != 200)
            {
                String retornoErro = retornoEmissao.motivo;
                if (retornoEmissao.erros != null)
                {
                    foreach (String erro in retornoEmissao.erros)
                    {
                        retornoErro += "\n" + erro;
                    }
                }
                return retornoErro;
            }

            int counter = 0;

            do
            {
                if(counter == 0)
                {
                    Thread.Sleep(250);
                } else
                {
                    Thread.Sleep(3000);
                }

                ++counter;

                String retornoProcessamentoString = consultaStatusProcessamento(retornoEmissao.nsNRec);
                retornoProcessamento = JsonConvert.DeserializeObject<StatusProcessamentoResult>(retornoProcessamentoString);

                if(retornoProcessamento.status == isStatusOK)
                {
                    break;
                }

                if(retornoProcessamento.cStat != 0)
                {
                    if(retornoProcessamento.cStat == 105)
                    {
                        return retornoProcessamento.xMotivo;
                    }
                } else
                {
                    return retornoProcessamento.xMotivo;
                }
            } while (counter < 3);

            if(retornoProcessamento.cStat == 100)
            {
                if (saveLocal)
                {
                    downloadNFeAndSave(retornoProcessamento.chNFe, tpDown, caminho, isShow, tpAmb, printCEAN);
                } else
                {
                    downloadNFe(retornoProcessamento.chNFe, tpDown, tpAmb, printCEAN);
                }
                return retornoProcessamento.xMotivo;
            } else
            {
                return retornoProcessamento.xMotivo;
            }
        }

        public String emitirNFe(String conteudo){
            return enviaConteudoParaAPI(conteudo, this.urlEnvioNFe);
        }

        public String consultaStatusProcessamento(String nsNRec){
            StatusProcessamentoParameters param = new StatusProcessamentoParameters(CNPJ, nsNRec);
            return enviaConteudoParaAPI(param.toJson(), this.urlStatusProcessamento);
        }

        public String downloadNFe(String chNFe, String tpDown, int tpAmb = 2, Boolean printCEAN = false)
        {
            DownloadParameters param = new DownloadParameters(chNFe, tpDown, tpAmb, printCEAN);
            return enviaConteudoParaAPI(param.toJson(), this.urlDownloadNFe);
        }

        public String downloadNFeAndSave(String chNFe, String tpDown, String caminho = "", Boolean isShow = false, int tpAmb = 2, Boolean printCEAN = false){
            String retorno = downloadNFe(chNFe, tpDown, tpAmb, printCEAN);

            if (caminho != ""){
                if (!Directory.Exists(caminho))
                {
                    Directory.CreateDirectory(caminho);
                }
                if (!caminho.EndsWith("\\"))
                {
                    caminho += "\\";
                }
            }
            
            DownloadNFeReturn JSONRetorno = JsonConvert.DeserializeObject<DownloadNFeReturn>(retorno);
            
            if (JSONRetorno.status == isStatusOK){
                String pathName = caminho + chNFe + "-procNfe";
                if (tpDown.ToUpper().Contains("X")){
                    salvaArquivo(JSONRetorno.xml, pathName, "X");
                }
                else{
                    if (tpDown.ToUpper().Contains("J")){
                        salvaArquivo(JSONRetorno.nfeProc, pathName, "J");
                    }
                }

                if (tpDown.ToUpper().Contains("P"))
                {
                    String conteudoSalvar = JSONRetorno.pdf;
                    salvaArquivo(conteudoSalvar, pathName, "P");
                    if (isShow) System.Diagnostics.Process.Start(@pathName + ".pdf");
                }
            }
            return retorno;
        }

        public String cancelarNFe(String chNFe, String nProt, String xJust, int tpAmb = 2, DateTime dhEventoDT = default(DateTime))
        {
            String dhEvento;
            if (dhEventoDT.Equals(default(DateTime)))
            {
                dhEvento = String.Format("{0:yyyy-MM-dd}" + "T" + "{0:HH:mm:sszzz}", DateTime.Now);
            } else
            {
                dhEvento = String.Format("{0:yyyy-MM-dd}" + "T" + "{0:HH:mm:sszzz}", dhEventoDT);
            }

            if (xJust.Length < 15)
            {
                return "Tamanho da justificativa insuficiente. Deve ter pelo menos 15 caracteres";
            }
            CancelamentoParameters param = new CancelamentoParameters(chNFe, nProt, xJust, tpAmb, dhEvento);
            return enviaConteudoParaAPI(param.toJson(), this.urlCancelamento);
        }

        public String consultaSituacaoNFe(String chNFe, int tpAmb)
        {
            ConsultaSituacaoParameters param = new ConsultaSituacaoParameters(chNFe, tpAmb, CNPJ);
            return enviaConteudoParaAPI(param.toJson(), this.urlConsultaSituacao);
        }

        public String cartaCorrecaoNFe(String chNFe, String xCorrecao, int nSeqEvento, int tpAmb = 2, DateTime dhEventoDT = default(DateTime))
        {
            String dhEvento;
            if (dhEventoDT.Equals(default(DateTime)))
            {
                dhEvento = String.Format("{0:yyyy-MM-dd}" + "T" + "{0:HH:mm:sszzz}", DateTime.Now);
            } else
            {
                dhEvento = String.Format("{0:yyyy-MM-dd}" + "T" + "{0:HH:mm:sszzz}", dhEventoDT);
            }
            CartaCorrecaoParameters param = new CartaCorrecaoParameters(chNFe, xCorrecao, nSeqEvento, tpAmb, dhEvento);
            return enviaConteudoParaAPI(param.toJson(), this.urlCartaCorrecao);
        }

        public String downloadEventoNFe(String chNFe, String tpDown, String tpEvento, int tpAmb = 2, int nSeqEvento = 0)
        {
            DownloadEventoParameters param;
            if (tpEvento.Contains("CCE") || tpEvento.Contains("cce") || tpEvento.Length == 3 || nSeqEvento > 0) //CCE
            {
                param = new DownloadEventoParameters(chNFe, tpDown, tpEvento, tpAmb, nSeqEvento);
            } else //CANC
            {
                param = new DownloadEventoParameters(chNFe, tpDown, tpEvento, tpAmb);
            }
            return enviaConteudoParaAPI(param.toJson(), this.urlDownloadEvento);
        }

        public String inutilizaNFe(int cUF, int ano, int serie, int nNFIni, int nNFFin, String xJust, int tpAmb = 2)
        {
            if (xJust.Length < 15)
            {
                return "Tamanho da justificativa insuficiente. Deve ter pelo menos 15 caracteres";
            }
            InutilizacaoParameters param = new InutilizacaoParameters(CNPJ, cUF, ano, serie, nNFIni, nNFFin, xJust, tpAmb);
            return enviaConteudoParaAPI(param.toJson(), this.urlInutilizacao);
        }

        public String downloadInutilizacao(String chave, String tpDown = "X", int tpAmb = 2)
        {
            DownloadInutilizacaoParameters param = new DownloadInutilizacaoParameters(chave, tpDown, tpAmb);
            return enviaConteudoParaAPI(param.toJson(), this.urlDownloadInutilizacao);
        }

        public String consultaContribuinte(String UF, String identificacao, String tpIdentificacao)
        {
            if (tpIdentificacao.Equals("CNPJ") || tpIdentificacao.Equals("cnpj") || tpIdentificacao.Length == 4)
            {
                tpIdentificacao = "CNPJ";
            } else if (tpIdentificacao.Equals("IE") || tpIdentificacao.Equals("ie") || tpIdentificacao.Length == 2)
            {
                tpIdentificacao = "IE";
            } else
            {
                tpIdentificacao = "CPF";
            }
            ConsultaContribuinteParameters param = new ConsultaContribuinteParameters(CNPJ, UF, identificacao, tpIdentificacao);
            return enviaConteudoParaAPI(param.toJson(), this.urlConsultaContribuinte);
        }

        public String consultaStatusWSSefaz(String UF, String versao, int tpAmb = 2)
        {
            ConsultaStatusWSSefazParameters param = new ConsultaStatusWSSefazParameters(CNPJ, UF, versao, tpAmb);
            return enviaConteudoParaAPI(param.toJson(), this.urlConsultaStatusWSSefaz);
        }

        public String enviarNFePorEmail(String chNFe, String email = null, Boolean enviaEmailDoc = false)
        {
            if (email.Equals(null) && enviaEmailDoc.Equals(false))
            {
                return "Deve ser informado um e-mail de destino ou se deve ser utilizado os que constam na NFe.";
            }
            EnvioNFeEmailParameters param = new EnvioNFeEmailParameters(chNFe, email, enviaEmailDoc);
            return enviaConteudoParaAPI(param.toJson(), this.urlEnvioNFeEmail);
        }

        public String enviarPrevia(String conteudo)
        {
            String retornoString = enviaConteudoParaAPI(conteudo, this.urlPrevia);
            PreviaReturn retorno = JsonConvert.DeserializeObject<PreviaReturn>(retornoString);
            if (retorno.status == isStatusOK)
            {
                if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Previa\\"))
                {
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Previa\\");
                }
                String pathName = Directory.GetCurrentDirectory() + "\\Previa\\" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day +
                    DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second;
                salvaArquivo(retorno.pdf, pathName, "P");
                System.Diagnostics.Process.Start(@pathName + ".pdf");
            }
            return enviaConteudoParaAPI(conteudo, this.urlPrevia);
        }

        private Boolean salvaArquivo(String conteudo, String pathName, String tpArq)
        {
            try
            {
                if (tpArq.Equals("X"))
                {
                    System.IO.File.WriteAllText(@pathName + ".xml", conteudo);
                } else if (tpArq == "J")
                {
                    System.IO.File.WriteAllText(@pathName + ".json", conteudo);
                } else {
                    byte[] bytes = Convert.FromBase64String(conteudo);
                    if (File.Exists(pathName + ".pdf")) File.Delete(pathName + ".pdf");
                    System.IO.FileStream stream = new FileStream(@pathName + ".pdf", FileMode.CreateNew);
                    System.IO.BinaryWriter writer = new BinaryWriter(stream);
                    writer.Write(bytes, 0, bytes.Length);
                    writer.Close();
                }
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        private String enviaConteudoParaAPI(String conteudo, String url)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers["X-AUTH-TOKEN"] = token;
            httpWebRequest.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(conteudo);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream())) return streamReader.ReadToEnd();
            } catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    HttpWebResponse response = (HttpWebResponse)ex.Response;
                    using (var streamReader = new StreamReader(response.GetResponseStream())) return streamReader.ReadToEnd();
                } else
                {
                    return ex.Message;
                }

            }

        }
    }
}
