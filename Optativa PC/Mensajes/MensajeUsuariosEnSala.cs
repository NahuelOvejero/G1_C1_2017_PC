using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajes
{
    public class MensajeUsuariosEnSala : MensajeBase
    {
        List<String> usuariosEnSala;
        public MensajeUsuariosEnSala(string from, string to, int sala,List<String> usuariosEnSala) : base(from, to, sala)
        {
            base.TipoMensaje = this.GetType().Name;
            this.usuariosEnSala = usuariosEnSala;
        }
        public List<String> UsuariosEnSala {
            get { return usuariosEnSala; }
        }
    }
}
