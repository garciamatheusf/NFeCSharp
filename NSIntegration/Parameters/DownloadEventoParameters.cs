using Newtonsoft.Json;
using System;

namespace Aplicacao.NFe.NSIntegration.Parameters
{
    class DownloadEventoParameters
    {
        public String chNFe { get; set; }
        public String tpDown { get; set; }
        public String tpEvento { get; set; }
        public int tpAmb { get; set; }
        public int nSeqEvento { get; set; }

        public DownloadEventoParameters(String chNFe, String tpDown, String tpEvento, int tpAmb, int nSeqEvento)
        {
            this.chNFe = chNFe;
            this.tpDown = tpDown;
            this.tpEvento = tpEvento;
            this.tpAmb = tpAmb;
            this.nSeqEvento = nSeqEvento;
        }

        public DownloadEventoParameters(String chNFe, String tpDown, String tpEvento, int tpAmb)
        {
            this.chNFe = chNFe;
            this.tpDown = tpDown;
            this.tpEvento = tpEvento;
            this.tpAmb = tpAmb;
        }

        public String toJson()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
