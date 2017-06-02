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
                    {
                        MensajeLogin mL= JsonConvert.DeserializeObject<MensajeLogin>(mensaje);
                        if (Recibir != null)
                            Recibir(mL);
                        ; break;
                    }
                case "EntraSala":
                    {
                        MensajeLogin mL = JsonConvert.DeserializeObject<MensajeLogin>(mensaje);
                        if (Recibir != null)
                            Recibir(mL);
                        ; break;
                    }
            }
           
        }
 
        public void enviarMensaje(MensajeBase msg) {
            string mensaje = JsonConvert.SerializeObject(msg);
            if (Enviar != null) {
                Enviar(mensaje);
            }
        }

     
 
    }
}
