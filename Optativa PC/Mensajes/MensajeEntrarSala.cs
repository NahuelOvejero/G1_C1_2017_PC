using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajes
{
   public class MensajeEntrarSala:MensajeBase
    {
        public MensajeEntrarSala(string emisor, string receptor, int sala, string J) : base(emisor, receptor, sala)
        {
            base.TipoMensaje = this.GetType().Name;
        }
    }
}
