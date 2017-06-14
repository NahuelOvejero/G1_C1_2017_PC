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
        public event delDesc Desconectar;
        public delegate void delDesc(string id);
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
            string mensaje="";
            while (true)
            {
                try
                {

                    mensaje = reader.ReadLine();
                    Console.Out.NewLine = "\r\n\r\n";
                    MensajeBase msj = JsonConvert.DeserializeObject<MensajeBase>(mensaje);
                    switch (msj.TipoMensaje)
                    {
                        case "MensajeLogin":
                            msj = JsonConvert.DeserializeObject<MensajeLogin>(mensaje);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;

                        case "MensajeDibujarPuntos":
                            msj = JsonConvert.DeserializeObject<MensajeDibujarPuntos>(mensaje);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;

                        case "MensajeEntrarSala":
                            msj = JsonConvert.DeserializeObject<MensajeEntrarSala>(mensaje);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            break;
                        case "MensajeGanador":
                            msj = JsonConvert.DeserializeObject<MensajeGanador>(mensaje);
                            break;
                        case "MensajeEnviarPalabra":
                            msj = JsonConvert.DeserializeObject<MensajeEnviarPalabra>(mensaje);
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            break;
                      
                    }

                    if (Recibir != null)
                    {
                        Recibir(msj);
                    }

                }
                catch (ArgumentNullException e) {
                    if (mensaje == null) {
                        if (Desconectar != null) {
                            Desconectar(this.id);
                            break;
                        }
                    }
                }
                catch (IOException c) {
                    if (Desconectar != null)
                    {
                        Desconectar(this.id);
                        break;
                    }
                }
            }
        }


        public void enviar(MensajeBase msj) {
            
            string str = JsonConvert.SerializeObject(msj);
            try
            {
                writer.WriteLine(str);
            }
            catch (IOException e) {
                Console.WriteLine("No se pudo enviar el mensaje a " + id);
            }
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
