using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace misClases.mensajesEspecificos
{
    class MensajeGanador : MensajeBase
    {


        string idEmisor;
        string idReceptor;
        int nroSala;
        DateTime fecha;
        string JSONmensaje; 
        
        //dentro del JSON deberia estar el nombre del usuario con mas puntos

        public MensajeGanador(string emisor, string receptor, int sala, string J) : base(emisor, receptor, sala, J)
        {


        }

    }
}
