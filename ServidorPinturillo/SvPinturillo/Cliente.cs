using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Mensajes;
using Newtonsoft.Json;
namespace SvPinturillo
{
    public class Cliente
    {
        TcpClient cliente;
        string id;
        NetworkStream stream;
        StreamWriter writer;
        StreamReader reader;
        public string Id {
            get { return id; }
        }
        #region eventos
        public delegate void delRecibir(MensajeBase mensaje);
        public event delRecibir recibir;
        #endregion
        public Cliente(TcpClient cliente, string id) {
            this.cliente = cliente;
            this.id = id;
            stream = cliente.GetStream();
            writer = new StreamWriter(stream, Encoding.ASCII) { AutoFlush = true };
            reader= new StreamReader(stream, Encoding.ASCII);
        }
        public void atender()
        {
            while (true)
            {
                try
                {
                    string mens = reader.ReadLine();
                    MensajeBase msjBase = JsonConvert.DeserializeObject<MensajeBase>(mens);
                                   
                }
                catch (ArgumentNullException e) { }
            }
        }


    }
}
