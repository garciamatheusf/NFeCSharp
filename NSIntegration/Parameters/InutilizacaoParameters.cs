using Newtonsoft.Json;
using System;

namespace Aplicacao.NFe.NSIntegration.Parameters
{
    class InutilizacaoParameters
    {
        public int cUF { get; set; }
        public int ano { get; set; }
        public String CNPJ { get; set; }
        public int serie { get; set; }
        public int nNFIni { get; set; }
        public int nNFFin { get; set; }
        public String xJust { get; set; }
        public int tpAmb { get; set; }

        public InutilizacaoParameters(String CNPJ, int cUF, int ano, int serie, int nNFIni, int nNFFin, String xJust, int tpAmb)
        {
            this.CNPJ = CNPJ;
            this.cUF = cUF;
            this.ano = ano;
            this.serie = serie;
            this.nNFIni = nNFIni;
            this.nNFFin = nNFFin;
            this.tpAmb = nNFIni;
            this.xJust = xJust;
        }

        public String toJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
