using Newtonsoft.Json;
using System;

namespace Aplicacao.NFe.NSIntegration.Parameters
{
    class EnvioNFeEmailParameters
    {
        public String chNFe { get; set; }
        public String email { get; set; }
        public Boolean enviaEmailDoc { get; set; }

        public EnvioNFeEmailParameters(String chNFe, String email, Boolean enviaEmailDoc)
        {
            this.chNFe = chNFe;
            this.email = email;
            this.enviaEmailDoc = enviaEmailDoc;
        }

        public String toJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
