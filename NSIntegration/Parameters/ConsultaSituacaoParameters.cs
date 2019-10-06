using Newtonsoft.Json;
using System;

namespace Aplicacao.NFe.NSIntegration.Parameters
{
    class ConsultaSituacaoParameters
    {
        public String chNFe { get; set; }
        public int tpAmb { get; set; }
        public String CNPJ { get; set; }

        public ConsultaSituacaoParameters(String chNFe, int tpAmb, String CNPJ)
        {
            this.chNFe = chNFe;
            this.tpAmb = tpAmb;
            this.CNPJ = CNPJ;
        }

        public String toJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
