using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajes
{
    public class MensajeTocaDibujar : MensajeBase
    {
        string dibujante, palabraAdivinar;
        public MensajeTocaDibujar(string from, string to, int sala,string dibujante,string palabraAdivinar) : base(from, to, sala)
        {
            base.TipoMensaje = this.GetType().Name;
            this.dibujante = dibujante;
            this.palabraAdivinar = palabraAdivinar;
        }
        public string Dibujante {
            get { return dibujante; }
        }
        public string PalabraAdivinar {
            get { return palabraAdivinar; }
        }
    }
}
