using System;
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
        List<string> nombreUsuarios = new List<string>();
        private delegate void enviarMsj(MensajeBase msg);
        private event enviarMsj enviar;
        int port = 8999;
        IPAddress localAddr = IPAddress.Parse("127.0.0.1");
        TcpListener server;
        List<TcpClient> clientes = new List<TcpClient>();
        public Servidor()
        {
            server = new TcpListener(localAddr, port);
        }
        public void start()
        {
            TcpClient client;
            server.Start();
           Console.WriteLine("Servidor iniciado");    
            while (true)
            {
                client = server.AcceptTcpClient();
                clientes.Add(client);
                Thread t = new Thread(atender);
                t.Start(client);
            }
        }

        private void Servidor_enviar(MensajeBase msg)
        {

        }
        //los usuarios deben recibir los mensajes como eventos del lado del cliente
        /*
         TCP Client se lo paso a una clase que maneja con ID y guardar en una lista
         */
        private void atender(object tcpClient)
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

        }
        private void manejarMensaje(MensajeBase msjBase,TcpClient cliente)
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
            else if (msjBase.TipoMensaje == "MensajeEntrarSala") {
                Console.WriteLine("Es del tipo "+msjBase.TipoMensaje);
            }
            
          
        }


    }
}
