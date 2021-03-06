﻿using System;
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
        public delegate void DelIniciarPartida(MensajeIniciarPartida m);
        public event DelIniciarPartida IniciarPartida;
        public delegate void DelTocaDibujar(MensajeTocaDibujar m);
        public event DelTocaDibujar TocaDibujar;
        public delegate void DelMensajeFinTrazo(MensajeFinTrazo m);
        public event DelMensajeFinTrazo FinTrazo;
        public delegate void DelMensajeContador(MensajeContador m);
        public event DelMensajeContador Contador;
        public delegate void DelMensajeUsuariosEnSala(MensajeUsuariosEnSala m);
        public event DelMensajeUsuariosEnSala UsuariosEnSala;
        public delegate void DelMensajeGanador(MensajeGanador m);
        public event DelMensajeGanador Ganador;
        public delegate void DelMensajeEmpate(MensajeEmpate m);
        public event DelMensajeEmpate Empate;
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
            switch (msg.TipoMensaje)
            {
                case "MensajeLogin":
                    if (Logear != null)
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
                    if (Dibujar != null)
                    {
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
                case "MensajeIniciarPartida":
                    if (IniciarPartida != null)
                    {
                        try
                        {
                            MensajeIniciarPartida msgEn = (MensajeIniciarPartida)msg;
                            IniciarPartida(msgEn);
                        }
                        catch (InvalidCastException e) { }
                    }
                    break;
                case "MensajeTocaDibujar":
                    if (TocaDibujar != null)
                    {
                        try
                        {
                            MensajeTocaDibujar msgEn = (MensajeTocaDibujar)msg;
                            TocaDibujar(msgEn);
                        }
                        catch (InvalidCastException e) { }
                    }
                    break;

                case "MensajeFinTrazo":
                    if (FinTrazo != null)
                    {

                        try
                        {
                            MensajeFinTrazo msgEn = (MensajeFinTrazo)msg;
                            FinTrazo(msgEn);
                        }
                        catch (InvalidCastException e) { }
                    }
                    break;
                case "MensajeContador":
                    if (Contador != null)
                    {
                        try
                        {
                            MensajeContador msgCon = (MensajeContador)msg;
                            Contador(msgCon);
                        }
                        catch (InvalidCastException e) {
                            Console.WriteLine("151" + e.Message);
                        }
                    }
                    break;
                case "MensajeUsuariosEnSala":
                    if (UsuariosEnSala != null) {
                        try {
                            MensajeUsuariosEnSala msgUsSala = (MensajeUsuariosEnSala)msg;
                            UsuariosEnSala(msgUsSala);
                        }
                        catch (InvalidCastException e)
                        {
                            Console.WriteLine("164" + e.Message);
                        }
                    }
                    break;
                case "MensajeGanador":
                    if (Ganador != null) {
                        try
                        {
                            MensajeGanador msgGanador = (MensajeGanador)msg;
                            Ganador(msgGanador);
                        }
                        catch (InvalidCastException e)
                        {
                            Console.WriteLine("180" + e.Message);
                        }
                    }break;
                case "MensajeEmpate":
                    if(Empate!=null)
                    {
                        try
                        {
                            MensajeEmpate msgempate = (MensajeEmpate)msg;
                            Empate(msgempate);
                        }
                        catch (InvalidCastException e)
                        {
                            Console.WriteLine("195" + e.Message);
                        }
                    }
                    break;
            }


        }



        public void enviarDibujado(int grosor,int colorRGB, int x,int y,string nombre)
        {

            MensajeDibujarPuntos dibPuntos = new MensajeDibujarPuntos(nombre, "-",grosor,colorRGB,x, y, 0, "");
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

        public void enviarFinTrazo(string emisor)
        {
            MensajeFinTrazo mf = new MensajeFinTrazo(emisor, "*" ,0);
            serializador.enviarMensaje(mf);
        }
        public void empezarNuevaPartida() {
            MensajeIniciarPartida iniciarPartida = new MensajeIniciarPartida("", "", 0);
            serializador.enviarMensaje(iniciarPartida);
        }
        
        #endregion
    }
}
