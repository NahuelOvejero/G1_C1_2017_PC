using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN
{
    public class clsComunicacion:ICom
    {
        int segundos=60;
        
        
        public  void enviaEjes(Pen lapiz, int x1, int y1,frmPrueba formu)
        {
            formu.dibujar(lapiz,x1, y1);

        }
        public void contador()
        {
            segundos--;
        }
        public int Segundos
        {
            get { return segundos; }
        }

        public  bool enviaRta(string rta,frmJuego formu)
        {
            return formu.rtas(rta);
        }

        string palabraDesignada;

        public string PalabraDesignada
        {
            get { return palabraDesignada; }
        }

        string[] palabras = new string[] { "perro", "gato", "auto", "casa", "celular", "ratón", "gafas", "silla", "mochila", "jarrón", "cuadro", "sillón", "computadora" };

        public clsComunicacion()
        {
            Random r = new Random();
            int i = r.Next(0, palabras.Count());
            palabraDesignada = palabras[i];
        }

        public void enviarDibujado(Pen lapiz, Point p1, Point p2)
        {

        }

        public bool corroborar(string palabraEnviada)
        {
            if (palabraDesignada.ToUpper() == palabraEnviada.ToUpper())
                return true;
            else
                return false;
        }

        

        
    }
}
