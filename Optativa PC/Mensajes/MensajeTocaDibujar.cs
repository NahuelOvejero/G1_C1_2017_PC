using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajes
{
    public class MensajeTocaDibujar : MensajeBase
    {
        public MensajeTocaDibujar(string from, string to, int sala) : base(from, to, sala)
        {
        }
    }
}
