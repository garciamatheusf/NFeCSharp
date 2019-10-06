using System;
using System.Collections;

namespace Aplicacao.NFe.NSIntegration.Returns
{
    class EmissaoReturn
    {
        public int status { get; set; }
        public String motivo { get; set; }
        public String nsNRec { get; set; }
        public ArrayList erros { get; set; }
    }
}
