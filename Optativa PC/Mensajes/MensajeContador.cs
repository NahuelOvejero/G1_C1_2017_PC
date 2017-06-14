using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajes
{
    public class MensajeContador : MensajeBase
    {
        int pulso;
        public MensajeContador(string from, string to, int sala,int pulso) : base(from, to, sala)
        {
            base.TipoMensaje = this.GetType().Name;
            this.pulso = pulso;
        }
        public int Pulso {
            get { return pulso; }
        }
    }
}
