using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using Newtonsoft.Json;
namespace misClases
{
    public class MiConBase
    {
        int port = 8999;
        TcpClient client;
        StreamReader reader;
        StreamWriter writer;
        NetworkStream stream;
        //evento al serializador

        public void empezar()
        {
            client = new TcpClient("localhost", port);
            stream = client.GetStream();
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream) { AutoFlush = true };
        }
        public void read()
        {
            string e=reader.ReadLine();
            mrecibido(e);

        }

        public delegate void llegomsj(string j);
        public event llegomsj mrecibido;


    }
}




