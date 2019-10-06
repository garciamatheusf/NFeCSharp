using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacao.NFe.NSIntegration.Returns
{
    class CartaCorrecaoReturn
    {
        public int status { get; set; }
        public string motivo { get; set; }
        public RetornoEvento retEvento { get; set; }
        public CCeError erro { get; set; }
    }

    class RetornoEvento
    {
        public int cStat { get; set; }
        public string xMotivo { get; set; }
        public string chNFe { get; set; }
        public string dhRegEvento { get; set; }
        public string nProt { get; set; }
    }

    class CCeError{
        public int cStat { get; set; }
        public string xMotivo { get; set; }
    }
}
