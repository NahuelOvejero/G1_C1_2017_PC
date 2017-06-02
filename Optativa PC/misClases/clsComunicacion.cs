using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensajes;
using misClases;
using System.Threading;
namespace misClases
{
    public class clsComunicacion:ICom
    {
        int segundos=60;

        private Serializador serializador;
        #region eventos
        public delegate void DelLogeo(MensajeLogin m);
        public event DelLogeo Logear;
        public delegate void DelEntrarSala(MensajeEntrarSala m);
        public event DelEntrarSala EntraSala;
        public delegate void DelDibujar(MensajeDibujarPuntos m);
        public event DelDibujar Dibujar;
        public delegate void DelRespPalabra(MensajeEnviarPalabra m);
        public event DelRespPalabra RespuestaPalabraEnviada;
        #endregion

        public void contador()
        {
            segundos--;
        }
        public int Segundos
        {
            get { return segundos; }
        }

       

        string palabraDesignada;

        public string PalabraDesignada
        {
            get { return palabraDesignada; }
        }

       MiConBase ConBase;
        public clsComunicacion()
        {
            Random r = new Random();
          
            serializador = new Serializador();
            ConBase = new MiConBase(serializador);
            Thread tEscucha = new Thread(ConBase.read);
            tEscucha.Start();
            serializador.Recibir += Serializador_Recibir;
        }

        private void Serializador_Recibir(MensajeBase msg)
        {
            switch (msg.TipoMensaje) {
                case "MensajeLogin": if (Logear != null)
                    {
                        try
                        {
                            MensajeLogin msgL = (MensajeLogin)msg;
                            Logear(msgL);
                        }
                        catch (InvalidCastException e) { }
                    }
                    break;

                case "MensajeEntrarSala":
                    if (EntraSala != null)
                    {
                        try
                        {
                            MensajeEntrarSala msgEn = (MensajeEntrarSala)msg;
                            EntraSala(msgEn);
                        }
                        catch (InvalidCastException e) { }
                    }
                    break;
                case "MensajeDibujarPuntos":
                    MensajeDibujarPuntos msgDibPun = (MensajeDibujarPuntos)msg;
                    if (Dibujar != null) {
                        Dibujar(msgDibPun);
                    }
                    break;
                case "MensajeEnviarPalabra":
                    MensajeEnviarPalabra msgEnvPal = (MensajeEnviarPalabra)msg;
                    if (RespuestaPalabraEnviada != null)
                    {
                        RespuestaPalabraEnviada(msgEnvPal);
                    }
                    break;

            }
        }

        public void enviarDibujado(Pen lapiz, int x,int y,string nombre)
        {

            MensajeDibujarPuntos dibPuntos = new MensajeDibujarPuntos(nombre, "*",(int) lapiz.Width, lapiz.Color.ToArgb(),x, y, 0, "");
            serializador.enviarMensaje(dibPuntos);
        }



        #region enviarMensajes
        public void conectar(string nombre)
        {
            MensajeLogin intentarLogin = new MensajeLogin(nombre, "", 0);
            serializador.enviarMensaje(intentarLogin);
        }

        public void entrar_sala(string emisor, string receptor, int sala, string js)
        {
            MensajeEntrarSala entrasala = new MensajeEntrarSala(emisor,receptor,sala,js);
            serializador.enviarMensaje(entrasala);
        }
        public void enviaRta(string rta, string nombre,int puntos)
        {
            MensajeEnviarPalabra enviarPalabra = new MensajeEnviarPalabra(nombre, "", 0, rta,puntos);
            serializador.enviarMensaje(enviarPalabra);
        }
        #endregion
    }
}
