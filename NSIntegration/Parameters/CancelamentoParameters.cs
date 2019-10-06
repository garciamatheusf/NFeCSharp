using Newtonsoft.Json;
using System;

namespace Aplicacao.NFe.NSIntegration.Parameters
{
    class CancelamentoParameters
    {
        public String chNFe { get; set; }
        public int tpAmb { get; set; }
        public String dhEvento { get; set; }
        public String nProt { get; set; }
        public String xJust { get; set; }

        public CancelamentoParameters(String chNFe, String nProt, String xJust, int tpAmb, String dhEvento)
        {
            this.chNFe = chNFe;
            this.nProt = nProt;
            this.tpAmb = tpAmb;
            this.xJust = xJust;
            this.dhEvento = dhEvento;
        }

        public String toJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
