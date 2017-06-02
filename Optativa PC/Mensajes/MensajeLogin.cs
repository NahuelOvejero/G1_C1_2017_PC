using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajes
{
    public class MensajeLogin:MensajeBase
    {
        int sala;
        bool conectado;
        string mensaje;
        public MensajeLogin(string emisor, string receptor, int sala) : base(emisor, receptor, sala)
        {
            base.TipoMensaje = this.GetType().Name;
            this.sala = sala;
        }
        public int Sala {
            get { return sala; }
            set { sala = value; }
        }
        public bool Conectado {
            get { return conectado; }
            set { conectado = value; }
        }
        public string Mensaje {
            get { return mensaje; }
            set { mensaje = value; }
        }

    }
}
