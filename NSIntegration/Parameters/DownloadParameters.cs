using Newtonsoft.Json;
using System;

namespace Aplicacao.NFe.NSIntegration.Parameters
{
    class DownloadParameters
    {
        public String chNFe { get; set; }
        public Boolean printCEAN { get; set; }
        public int tpAmb { get; set; }
        public String tpDown { get; set; }

        public DownloadParameters(String chNFe, String tpDown, int tpAmb, Boolean printCEAN)
        {
            this.chNFe = chNFe;
            this.tpDown = tpDown;
            this.tpAmb = tpAmb;
            this.printCEAN = printCEAN;
        }

        public String toJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

}
