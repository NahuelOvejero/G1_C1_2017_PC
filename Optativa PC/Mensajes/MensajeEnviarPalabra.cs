using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajes
{
    public class MensajeEnviarPalabra : MensajeBase
    {
        string palabra;
        bool correcta;
        int puntos;
        public MensajeEnviarPalabra(string from, string to, int sala,string palabra,int puntos) : base(from, to, sala)
        {
            this.palabra = palabra;
            this.puntos = puntos ;
        }

        public string Palabra {
            get { return palabra; }
        }
        public bool Correcta {
            get { return correcta; }
            set { correcta = value; }
        }
        public int Puntos {
            get { return puntos; }
        }
    }
}
