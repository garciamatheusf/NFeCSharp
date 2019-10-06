using Newtonsoft.Json;
using System;

namespace Aplicacao.NFe.NSIntegration.Parameters
{
    class StatusProcessamentoParameters
    {
        public String CNPJ { get; set; }
        public String nsNRec { get; set; }

        public StatusProcessamentoParameters(String CNPJ, String nsNRec)
        {
            this.CNPJ = CNPJ;
            this.nsNRec = nsNRec;
        }

        public String toJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
