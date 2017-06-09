using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using Newtonsoft.Json;
using Mensajes;
using System.Net;

namespace misClases
{
    public class MiConBase
    {
        int port = 8999;
        TcpClient client;
        StreamReader reader;
        StreamWriter writer;
        NetworkStream stream;
        Serializador serializador;

        public  MiConBase(Serializador serializador)
        {
            this.serializador = serializador;
            serializador.Enviar +=enviar;
            try
            {

                client = new TcpClient("192.168.1.142", port);
                stream = client.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream) { AutoFlush = true };
            }
            catch (SocketException e) { }
        }
        public void read()
        {
            while (true)
            {
                string e = reader.ReadLine();
                serializador.recibirMensaje(e);
            }
        }
        public void enviar(string msg)
        {
            try { writer.WriteLine(msg); }
            catch (NullReferenceException e) { string s = e.Message; }            
        }
    }
}




