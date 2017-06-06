using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajes
{
    public class MensajeIniciarPartida : MensajeBase
    {
        int sala;

        public MensajeIniciarPartida(string emisor, string receptor, int sala) : base(emisor, receptor, sala)
        {
            base.TipoMensaje = this.GetType().Name;
            this.sala = sala;
        }
    }
}
