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


        public event delRec Recibir;

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
                   
                    string mensaje = reader.ReadLine();
                   
                    MensajeBase msj = JsonConvert.DeserializeObject<MensajeBase>(mensaje);
                    switch (msj.TipoMensaje)
                    {

                        case "MensajeLogin":
                            msj = JsonConvert.DeserializeObject<MensajeLogin>(mensaje);
                            break;

                        case "MensajeDibujarPuntos":
                            msj = JsonConvert.DeserializeObject<MensajeDibujarPuntos>(mensaje);
                            break;

                        case "MensajeEntrarSala":
                            msj = JsonConvert.DeserializeObject<MensajeEntrarSala>(mensaje);
                            break;

                        case "MensajeGanador":
                            msj = JsonConvert.DeserializeObject<MensajeGanador>(mensaje);
                            break;
                        default:
                            msj = JsonConvert.DeserializeObject<MensajeLogin>(mensaje);
                            break;
                    }

                    if(Recibir != null) { 
                           Recibir(msj);
                        }

                }
                catch (ArgumentNullException e) { }
            }
        }


        public void enviar(MensajeBase msj) {
            string str = JsonConvert.SerializeObject(msj);
            writer.WriteLine(str);
        }


    }

    public delegate void delRec(MensajeBase msg);
}

/*                     string mens = reader.ReadLine();
                    MensajeBase msjBase = JsonConvert.DeserializeObject<MensajeBase>(mens);
                    switch (msjBase.TipoMensaje) {

                        case "MensajeLogin": break;

                        case "MensajeDibujarPuntos": break;

                        case "MensajeEntrarSala": break;

                        case "MensajeGanador": break;

                        case "MensajeBase": break;

                        default : break;

                    }


    */
