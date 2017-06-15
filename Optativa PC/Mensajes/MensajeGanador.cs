using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajes
{
    public class MensajeGanador : MensajeBase
    {

        //dentro del JSON deberia estar el nombre del usuario con mas puntos
        int puntos;
        public MensajeGanador(string emisor, string receptor, int sala,int puntos) : base(emisor, receptor, sala)
        {
            this.puntos = puntos;
            base.TipoMensaje = this.GetType().Name;
        }
        public int Puntos {
            get { return puntos; }
        }

    }
}
