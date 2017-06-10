using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Mensajes;
namespace misClases
{
    public delegate void delRec(MensajeBase msg);
    public delegate void delEnv(string strJSON);
    public class Serializador
    {
       
        public Serializador()
        {
            
        }

    
        //una cola de string para deserializar
        public event delEnv Enviar;
        public event delRec Recibir;
        public void recibirMensaje(string mensaje) {
            MensajeBase mb = JsonConvert.DeserializeObject<MensajeBase>(mensaje);
            switch (mb.TipoMensaje)
            {
                case "MensajeLogin":
                        mb= JsonConvert.DeserializeObject<MensajeLogin>(mensaje);break;
                case "MensajeEntrarSala":        
                       mb = JsonConvert.DeserializeObject<MensajeEntrarSala>(mensaje);break;     
                case "MensajeDibujarPuntos":
                        mb = JsonConvert.DeserializeObject<MensajeDibujarPuntos>(mensaje);break;
                case "MensajeEnviarPalabra":
                    mb = JsonConvert.DeserializeObject<MensajeEnviarPalabra>(mensaje);break;
                case "MensajeIniciarPartida":
                    mb = JsonConvert.DeserializeObject<MensajeIniciarPartida>(mensaje); break;
                case "MensajedibujarPuntos":
                    mb = JsonConvert.DeserializeObject<MensajeDibujarPuntos>(mensaje); break;
                case "MensajeTocaDibujar":
                    mb = JsonConvert.DeserializeObject<MensajeTocaDibujar>(mensaje); break;
                case "MensajeFinTrazo":
                    mb = JsonConvert.DeserializeObject<MensajeFinTrazo>(mensaje); break;
            }
            if (Recibir != null)
                Recibir(mb);
         }
         
        public void enviarMensaje(MensajeBase msg) {
            string mensaje = JsonConvert.SerializeObject(msg);
            if (Enviar != null) {
                Enviar(mensaje);
            }
        }

     
 
    }
}
