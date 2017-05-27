using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace misClases
{
    class MensajeBase
    {


        string idEmisor;
        string idReceptor;
        int nroSala;
        DateTime fecha;
        string JSONmensaje; //datos

        public MensajeBase(string emisor, string receptor, int sala, string J) {

            this.idEmisor = emisor;
            this.idReceptor = receptor;
            this.nroSala = sala;
            this.fecha = new DateTime();
            this.JSONmensaje = J;
        }


        

    }
}
