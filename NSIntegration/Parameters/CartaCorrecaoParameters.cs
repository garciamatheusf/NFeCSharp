using Newtonsoft.Json;
using System;

namespace Aplicacao.NFe.NSIntegration.Parameters
{
    class CartaCorrecaoParameters
    {
        public String chNFe { get; set; }
        public String xCorrecao { get; set; }
        public String dhEvento { get; set; }
        public int nSeqEvento { get; set; }
        public int tpAmb { get; set; }

        public CartaCorrecaoParameters(String chNFe, String xCorrecao, int nSeqEvento, int tpAmb, String dhEvento)
        {
            this.chNFe = chNFe;
            this.xCorrecao = xCorrecao;
            this.tpAmb = tpAmb;
            this.nSeqEvento = nSeqEvento;
            this.dhEvento = dhEvento;
        }

        public String toJson()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
