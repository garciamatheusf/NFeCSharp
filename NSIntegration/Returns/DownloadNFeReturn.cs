
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Aplicacao.NFe.NSIntegration.Returns
{
    class DownloadNFeReturn
    {
        public int status { get; set; }
        public String motivo { get; set; }
        public String chNFe { get; set; }
        public String xml { get; set; }
        public String nfeProc { get; set; }
        public String pdf { get; set; }
        public DownloadNFeError erro { get; set; }
    }

    class DownloadNFeError
    {
        public int cStat { get; set; }
        public String xMotivo { get; set; }
    }
}