using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajes
{
    public class MensajeBase
    {


        string from,to;
        int nroSala;
        DateTime fecha;
        String tipoMensaje;
        

        public MensajeBase(string from, string to, int sala) {

            this.from = from;
            this.to = to;
            this.nroSala = sala;
            this.fecha = new DateTime();
           
           
        }
        public string From {
            get { return from; }
            set { from = value; }
        }
        public string To {
            get { return to; }
            set { to = value; }
        }
        public int NroSala {
            get { return nroSala; }
            set { nroSala = value; }
        }
        public DateTime Fecha {
            get { return fecha; }
            set { fecha = value; }
        }
        public String TipoMensaje {
            get { return tipoMensaje; }
            set { tipoMensaje = value; }
        }
    }
}
