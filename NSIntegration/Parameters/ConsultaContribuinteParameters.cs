using Newtonsoft.Json;
using System;

namespace Aplicacao.NFe.NSIntegration.Parameters
{
    class ConsultaContribuinteParameters
    {
        public String CNPJCont { get; set; }
        public String UF { get; set; }
        public String IE { get; set; }
        public String CNPJ { get; set; }
        public String CPF { get; set; }

        public ConsultaContribuinteParameters(String CNPJCont, String UF, String identificacao, String tpIdentificacao)
        {
            this.CNPJCont = CNPJCont;
            this.UF = UF;
            if (tpIdentificacao.Equals("CNPJ"))
            {
                this.CNPJ = identificacao;
            } else if (tpIdentificacao.Equals("IE"))
            {
                this.IE = identificacao;
            } else
            {
                this.CPF = identificacao;
            }
        }

        public String toJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
