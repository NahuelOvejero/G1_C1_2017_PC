using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Mensajes;
using Newtonsoft.Json;
namespace ServidorPinturillo
{
   
     class Servidor
    {
        private delegate void enviarMsj(MensajeBase msg);
        private event enviarMsj enviar;
        int port = 9000;
        IPAddress localAddr = IPAddress.Parse("120.0.0.1");
        TcpListener server;
        List<TcpClient> clientes = new List<TcpClient>();
        public Servidor() {
            server = new TcpListener(localAddr, port);
        }
        public void start()
        {
            TcpClient client;
            server.Start();
            Console.WriteLine("Servidor iniciado");
            int nCon = 0;
            
            while (true)
            {
                client = server.AcceptTcpClient();
                clientes.Add(client);
                Thread t = new Thread(atender);
            }
        }

        private void Servidor_enviar(MensajeBase msg)
        {
            
        }

        private void atender(object tcpClient)
        {
            TcpClient cliente = (TcpClient)tcpClient;
            NetworkStream stream = cliente.GetStream();
            StreamWriter writer = new StreamWriter(stream, Encoding.ASCII) { AutoFlush = true };
            StreamReader reader = new StreamReader(stream, Encoding.ASCII);
            string mens=reader.ReadLine();
            MensajeBase msjBase = JsonConvert.DeserializeObject<MensajeBase>(mens);
            
        }
        

    }
}
