using Newtonsoft.Json;
using System;

namespace Aplicacao.NFe.NSIntegration.Parameters
{
    class DownloadInutilizacaoParameters
    {
        public String chave { get; set; }
        public String tpDown { get; set; }
        public int tpAmb { get; set; }

        public DownloadInutilizacaoParameters(String chave, String tpDown, int tpAmb)
        {
            this.chave = chave;
            this.tpDown = tpDown;
            this.tpAmb = tpAmb;
        }

        public String toJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
