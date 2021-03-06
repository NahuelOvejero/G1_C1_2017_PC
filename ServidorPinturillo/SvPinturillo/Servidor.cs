﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using Mensajes;
using Newtonsoft.Json;


namespace SvPinturillo
{
    public class Servidor
    {
        
        CancellationTokenSource RecToken;
        CancellationToken EndToken;
        int port = 8999;
        IPAddress localAddr = IPAddress.Parse("127.0.0.1");//127.0.0.1");
        TcpListener server;
        private object _ListaLocker = new object(), _banderLocker = new object();
        List<Cliente> listaClientes = new List<Cliente>();
        string[] palabras = new string[] { "perro", "gato", "auto", "casa", "celular", "teclado", "gafas", "silla", "mochila", "televisor", "cuadro", "campera", "computadora","anillo","reloj","cartera","cama","pelota","campana","moto","bicicleta","barco"};
        string palabraDesignada="perro";
        List<string> orden = new List<string>(),usuarioEnsala=new List<string>();
        bool EmpezoPartida;
        int enSala = 0;
        int rondaActual = 0;
        int turnoActual = 0;




        public Servidor()
        {
            server = new TcpListener(localAddr, port);
        }
        public void start()
        {
            server.Start();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Servidor iniciado");
            EmpezoPartida = false;
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                Thread Hiloautenticar = new Thread(autenticar);
                Hiloautenticar.Start(client);
            }
        }

        private bool estaLibreElNombre(string nombre)
        {
            bool libre = true;
            lock (_ListaLocker)
            {
                foreach (Cliente c in listaClientes)
                {
                    if (c.Id.CompareTo(nombre) == 0)
                    {
                        libre = false;
                        break;
                    }
                }
            }
            return libre;
        }
        

        #region comentarios
        //los usuarios deben recibir los mensajes como eventos del lado del cliente
        /*
         TCP Client se lo paso a una clase que maneja con ID y guardar en una lista
         */
        /* private void atender(object tcpClient)
         {
             Console.WriteLine("Atendiendo al cliente");
             TcpClient cliente = (TcpClient)tcpClient;
             NetworkStream stream = cliente.GetStream();
             StreamWriter writer = new StreamWriter(stream, Encoding.ASCII) { AutoFlush = true };
             StreamReader reader = new StreamReader(stream, Encoding.ASCII);
             while (cliente.Connected)
             {
                 try
                 {
                     string mens = reader.ReadLine();
                     MensajeBase msjBase = JsonConvert.DeserializeObject<MensajeBase>(mens);
                     Console.WriteLine("Es del tipo " + msjBase.TipoMensaje);
                     try { MensajeLogin msj = (MensajeLogin)msjBase; } catch (InvalidCastException e) { }
                     if (nombreUsuarios.Contains(msjBase.From))
                     {
                         MensajeLogin respuesta = new MensajeLogin("", "", 0);
                         respuesta.Conectado = false;
                         respuesta.Mensaje = "Nombre de usuario ya existente";
                         string resp = JsonConvert.SerializeObject(respuesta);
                         Console.WriteLine("Nombre de usuario ya existente " + msjBase.From);
                         writer.WriteLine(resp);
                     }
                     else
                     {
                         MensajeLogin respuesta = new MensajeLogin("","", 0);
                         respuesta.Conectado = true;
                         respuesta.Mensaje = "Conectado";
                         nombreUsuarios.Add(msjBase.From);
                         Console.WriteLine("El usuario se ha logeado: " + msjBase.From);
                         string resp = JsonConvert.SerializeObject(respuesta);
                         writer.WriteLine(resp);
                     }

                     // manejarMensaje(msjBase,cliente);
                 }
                 catch (ArgumentNullException e) { }
             }

         }*/
        /*  private void manejarMensaje(MensajeBase msjBase,TcpClient cliente)
          {
              if (msjBase.TipoMensaje == "MensajeLogin")
              {
                  Console.WriteLine("Es del tipo "+ msjBase.TipoMensaje);
                  MensajeLogin msj = (MensajeLogin)msjBase;
                  if (nombreUsuarios.Contains(msjBase.From))
                  {
                      MensajeLogin respuesta = new MensajeLogin("","",0);
                      respuesta.Conectado = false;
                      respuesta.Mensaje = "Nombre de usuario ya existente";
                  }
              }
              else if (msjBase.TipoMensaje == "MensajeDibujarPuntos")
              {
                  Console.WriteLine("Es del tipo "+ msjBase.TipoMensaje);
              }
              else if (msjBase.TipoMensaje == "EntraSala") {
                  Console.WriteLine("Es del tipo "+msjBase.TipoMensaje);
              }          
          }*/

        #endregion

        public void autenticar(object client)
        {
            TcpClient clienteAutenticando = (TcpClient)client;
            NetworkStream stream = clienteAutenticando.GetStream();
            StreamWriter writer = new StreamWriter(stream, Encoding.ASCII) { AutoFlush = true };
            StreamReader reader = new StreamReader(stream, Encoding.ASCII);
            while (true)
            {
                string mens = reader.ReadLine();
                MensajeBase msjBase = JsonConvert.DeserializeObject<MensajeBase>(mens);
                string nombre = msjBase.From;
                try { MensajeLogin msj = (MensajeLogin)msjBase; } catch (InvalidCastException e) { }
                if (estaLibreElNombre(nombre))
                {
                    MensajeLogin respuesta = new MensajeLogin("", nombre, 0);
                    respuesta.Conectado = true;
                    Cliente c = new Cliente(clienteAutenticando, nombre);
                    c.Recibir += C_Recibir;
                    c.Desconectar += C_Desconectar;
                    lock (_ListaLocker)
                    {
                        //despues verificar sala, de momento es prueba
                        //if(conectados > 4) mandar mensaje de "server lleno"
                        //o poner al usuario en lista de espera
                        listaClientes.Add(c);
                        orden.Add(c.Id);
                      
                    }

                    Thread HiloAtender = new Thread(c.atender);
                    Console.Out.NewLine = "\r\n\r\n";
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(msjBase.Fecha + ":El usuario se ha logeado: " + nombre);
                    Console.WriteLine("Total conectados " + listaClientes.Count);
                    string resp = JsonConvert.SerializeObject(respuesta);
                    writer.WriteLine(resp);
                    HiloAtender.Start();
                    break;
                }
                else
                {
                    MensajeLogin respuesta = new MensajeLogin("", "", 0);
                    respuesta.Conectado = false;
                    respuesta.Mensaje = "Nombre de usuario ya existente ";
                    string resp = JsonConvert.SerializeObject(respuesta);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nombre de usuario ya existente " + msjBase.From);
                    writer.WriteLine(resp);
                }
            }
        }

        private void C_Desconectar(string id)
        {
            int i=listaClientes.IndexOf(filtrar(id));
            lock (_ListaLocker)
            {   if(i>-1)
                listaClientes.RemoveAt(i);
                orden.RemoveAt(orden.IndexOf(id));
                enSala--;
            }
            usuarioEnsala.Remove(id);
            actualizarSala();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Se desconectó el usuario"+id+". Usuarios conectados:"+listaClientes.Count);
        }

        private void C_Recibir(MensajeBase msg)
        {
            //si es para el servidor:
            if (msg.To == "")
            {

                switch (msg.TipoMensaje)
                {
                    case "MensajeEnviarPalabra":
                        MensajeEnviarPalabra mj = (MensajeEnviarPalabra)msg;
                        Cliente c = filtrar(mj.From);

                        if (corroborar(mj.Palabra))
                        {

                            if (c != null)
                            {
                                filtrar(mj.From).Puntos = mj.Puntos;
                                mj.To = mj.From;
                                mj.From = "";
                                mj.Correcta = true;
                                enviarTodos(mj, "");
                                RecToken.Cancel();
                                actualizarSala();
                                empezarPartida();
                            }

                        }
                        else
                        {

                            enviarTodos(mj, "");
                            // filtrar(mj.From).enviar();
                        }
                        break;

                    case "MensajeDibujandoPuntos":
                        enviarTodos(msg, msg.From);
                        break;

                    case "MensajeGanador":
                        msg = (MensajeGanador)msg;
                        break;

                    case "MensajeEntrarSala":

                        Console.WriteLine("ENTRO A LA BENDITA SALA");
                        enSala++;
                        msg = (MensajeEntrarSala)msg;
                        usuarioEnsala.Add(msg.From);
                        actualizarSala();
                        if (enSala>1 && !EmpezoPartida)
                        {     
                            empezarPartida();
                        }
                        break;

                    case "MensajeFinTrazo":
                        enviarTodos(msg, msg.From);
                        break;
                    case "MensajeIniciarPartida":
                        rondaActual = 0;
                        turnoActual = 0;
                        foreach (Cliente cli in listaClientes) {
                            cli.Puntos = -cli.Puntos;
                        }
                        actualizarSala();
                        empezarPartida();
                        break;
                }
            }
            #region msg todos o server

            //si el msj es para todos:
            else if (msg.To == "*")
            {
                lock (_ListaLocker)
                {
                    foreach (Cliente c in listaClientes)
                    {
                        c.enviar(msg);
                    }
                }
            }
            //todos menos uno
            else if (msg.To == "-") {
                enviarTodos(msg, msg.From);
            }
            // si no es para el servidor:
            else
            {
                if (filtrar(msg.To) != null)
                {
                    filtrar(msg.To).enviar(msg);
                }
            }
            #endregion
        }



        /*

            la funcion filtrar nos identifica un Cliente dentro de la lista cliente, y lo retorna.
            Si el id cliente no esta en la lista, o no es encontrado, devuelve null.

        */
        public void actualizarSala() {
            MensajeUsuariosEnSala usuariosEnSala = new MensajeUsuariosEnSala("", "", 0, genteEnSala());
            enviarTodos(usuariosEnSala, "");
        }
        private List<String> genteEnSala() {
            List<String> retorno = new List<String>();
            foreach (string us in usuarioEnsala) {
                retorno.Add(us+", Puntos:"+filtrar(us).Puntos);
            }
            return retorno;
        }

        private Cliente filtrar(string id) {
            lock (_ListaLocker)
            {
                foreach (Cliente c in listaClientes)
                {
                    if (c.Id == id)
                    {
                        return c;
                    }
                }
            }
            return null;
        }

        //enviar todos manda un msj a TODOS los clientes
        //excepto quien lo origina

            //puede modificarse al enviar todos los que pertenezcan en una sala cuando sea multipartida.
        private void enviarTodos(MensajeBase mb,string evitar) {
            lock (_ListaLocker)
            {
                foreach (Cliente c in listaClientes)
                {
                    if (c.Id != evitar)
                    {
                        c.enviar(mb);
                    }
                }
            }
        }


        public bool corroborar(string palabraEnviada)
        {
            return palabraDesignada.ToUpper() == palabraEnviada.ToUpper();
        }

        //habria que verificar cuando hay un ganador o se acabe el tiempo, que se ejecute el avanzar turno:
        //a la vez verifica la ronda actual.
        //suponiendo que el juego tendra 3 rondas donde dibujara una vez uno de los cuatro participantes.
        public void avanzarTurno() {
            Console.WriteLine("Avanza un turno "+turnoActual);
            turnoActual++;
            rondaActual++;
            //RONDA DE TESTING
            //SOLO DOS JUGADORES 
            if (turnoActual >= enSala) {  
                turnoActual = 0;
            }
        }
    
        public void empezarPartida()
        {
            if (rondaActual != 5)
            {
                EmpezoPartida = true;
                Console.WriteLine("Empezo la partida");
                RecToken = new CancellationTokenSource();
                EndToken = RecToken.Token;
                Random ran = new Random();
                int i = ran.Next(0, palabras.Length - 1);
                palabraDesignada = palabras[i];
                Console.WriteLine("Palabra designada " + palabraDesignada);
                MensajeTocaDibujar msjToca = new MensajeTocaDibujar("", "*", 1, orden.ElementAt<string>(turnoActual), palabraDesignada);
                Console.WriteLine("Turno de dibujar: " + orden.ElementAt<string>(turnoActual));
                MensajeIniciarPartida iniciar = new MensajeIniciarPartida("", "*", 1);
                //SE ENVIA A TODOS EL MENSAJE Iniciar Partida y toca dibujar
                enviarTodos(msjToca, "");
                Thread.Sleep(3000);
                enviarTodos(iniciar, "");
                //THREAD CONTADOR 
                Thread HiloContador = new Thread(contador);
                HiloContador.Start(EndToken);
                avanzarTurno();
                //SE ENVIA AL DEL TURNO ACTUAL EL MENSAJE TOCA DIBUJAR
            }
            else
            {
                RecToken.Cancel();
                string ganador = "";
                int puntos = 0;
                Cliente cliente;
                foreach (string en in usuarioEnsala) {
                    cliente = filtrar(en);
                    if (cliente.Puntos > puntos)
                    {
                        ganador = cliente.Id;
                        puntos = cliente.Puntos;
                    }
                }
                MensajeGanador msgGanador = new MensajeGanador("", ganador, 0, puntos);
                enviarTodos(msgGanador, "");
                EmpezoPartida = false;
            }
        }

        public void contador(object token)
        {
            CancellationToken EndToken = (CancellationToken)token;
            int cont = 60;
            while (!EndToken.IsCancellationRequested && cont != -1)
            {
                MensajeContador mensajeContador = new MensajeContador("", "*", 1, cont--);
                enviarTodos(mensajeContador, "");
                Thread.Sleep(1000);
            }
            if (cont == -1)//Nadie adivinó
            {
                MensajeEmpate msj = new MensajeEmpate("", "", 0);
                enviarTodos(msj, "");
                Thread.Sleep(3000);
                empezarPartida();
            }
        }

        public void reiniciarPartida()
        {
            this.rondaActual = 0;
            this.turnoActual = 0;
        }


    }
}
