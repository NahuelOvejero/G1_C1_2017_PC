using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajes
{
    class IntentarLogin:MensajeBase
    {
        public IntentarLogin(string emisor, string receptor, int sala, string J) : base(emisor, receptor, sala, J)
        {

        }
    }
}
