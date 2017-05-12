using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace misClases
{
    public class Serializador
    {

        MiConBase mc = new MiConBase();

        public delegate void RMensaje(string strJSON);
        //una cola de string para deserializar
        public event RMensaje recibir;
       

        public  Serializador(){
            mc.mrecibido += sale;
        }

        private void sale(string json) {
            string deserializado = JsonConvert.DeserializeObject<string>(json);
            MensajeBase msj = new MensajeBase("Servidor", "", 0, deserializado);
            
        }
    }
}
