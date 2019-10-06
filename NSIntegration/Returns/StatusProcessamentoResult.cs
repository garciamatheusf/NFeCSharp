using System;

namespace Aplicacao.NFe.NSIntegration.Returns
{
    class StatusProcessamentoResult
    {
        public int status { get; set; }
        public String motivo { get; set; }
        public String chNFe { get; set; }
        public int cStat { get; set; }
        public String xMotivo { get; set; }
        public String nProt { get; set; }
        public String dhRecbto { get; set; }
        public String xml { get; set; }
        public StatusProcessamentoErroResult erro { get; set; }
        
    }

    class StatusProcessamentoErroResult
    {
        public int cStat { get; set; }
        public String xMotivo { get; set; }
    }
}
