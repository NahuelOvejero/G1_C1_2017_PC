using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajes
{
    class EntrarSala:MensajeBase
    {
        public EntrarSala(string emisor, string receptor, int sala, string J) : base(emisor, receptor, sala, J)
        {

        }
    }
}
