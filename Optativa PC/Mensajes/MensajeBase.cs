using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajes
{
    public class MensajeBase
    {


        string idEmisor;
        string idReceptor;
        int nroSala;
        DateTime fecha;
        

        public MensajeBase(string emisor, string receptor, int sala) {

            this.idEmisor = emisor;
            this.idReceptor = receptor;
            this.nroSala = sala;
            this.fecha = new DateTime();
           
        }
        public string IdEmisor {
            get { return idEmisor; }
            set { idEmisor = value; }
        }
        public string IdReceptor {
            get { return idReceptor; }
            set { idReceptor = value; }
        }
        public int NroSala {
            get { return nroSala; }
            set { nroSala = value; }
        }
        public DateTime Fecha {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
