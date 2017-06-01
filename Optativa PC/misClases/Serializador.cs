using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Mensajes;
namespace misClases
{
    public class Serializador
    {
        MiConBase conBase;
        clsComunicacion comunicacion;
        public Serializador(clsComunicacion comunicacion)
        {
            conBase = new MiConBase(this);
            this.comunicacion = comunicacion;
        }
       

        public delegate void RMensaje(string strJSON);
        //una cola de string para deserializar
        public event RMensaje recibir;
        public void recibirMensaje(string mensaje) {
            MensajeBase mb = JsonConvert.DeserializeObject<MensajeBase>(mensaje);
            switch (mb.TipoMensaje)
            {
                case "MensajeIntentarLogin" : comunicacion.intentarLogeo((MensajeIntentarLogin)mb);break;
            
            }
        }
        public void enviarMensaje(MensajeBase msg) {
            string mensaje = JsonConvert.SerializeObject(msg);
            conBase.enviar(mensaje);
        }

     
 
    }
}
