using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensajes;
using misClases;

namespace misClases
{
    public class clsComunicacion:ICom
    {
        int segundos=60;
        string mensaje;
        private Serializador serializador;
        public string Mensaje
        {
            get { return mensaje; }
        }
        public  void enviaEjes(Pen lapiz, int x1, int y1)
        {
           

        }
        public void contador()
        {
            segundos--;
        }
        public int Segundos
        {
            get { return segundos; }
        }

        public  bool enviaRta(string rta)
        {
            return false;
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
            serializador = new Serializador(this);
      
        }

        public void enviarDibujado(Pen lapiz, Point p1, Point p2)
        {

        }

        public bool corroborar(string palabraEnviada)
        {
            return palabraDesignada.ToUpper() == palabraEnviada.ToUpper();        
        }

        public void conectar(string nombre)
        {
            MensajeIntentarLogin intentarLogin = new MensajeIntentarLogin(nombre, "", 0);
            serializador.enviarMensaje(intentarLogin);
        }
        public bool intentarLogeo(MensajeIntentarLogin m) {
            mensaje = m.Mensaje;
            return m.Conectado;
        }
        public delegate bool EventoLogeo(MensajeIntentarLogin m);
        public event EventoLogeo IntentarLogear;
    }
}
