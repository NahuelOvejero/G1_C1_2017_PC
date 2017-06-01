﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using Newtonsoft.Json;
using Mensajes;
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
            try
            {
                client = new TcpClient("localhost", port);
                stream = client.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream) { AutoFlush = true };
            }
            catch (SocketException e) { }
        }
        public void read()
        {
            string e=reader.ReadLine();
            
        }



        public delegate void llegomsj(string j);
        public event llegomsj mrecibido;

        public void enviar(string msg)
        {
            writer.WriteLine(msg);            
        }
    }
}




