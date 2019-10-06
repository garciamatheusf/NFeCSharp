using Newtonsoft.Json;
using System;

namespace Aplicacao.NFe.NSIntegration.Parameters
{
    class ConsultaStatusWSSefazParameters
    {
        public String CNPJCont { get; set; }
        public String UF { get; set; }
        public int tpAmb { get; set; }
        public String versao { get; set; }

        public ConsultaStatusWSSefazParameters(String CNPJCont, String UF, String versao, int tpAmb)
        {
            this.CNPJCont = CNPJCont;
            this.UF = UF;
            this.versao = versao;
            this.tpAmb = tpAmb;
        }

        public String toJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
