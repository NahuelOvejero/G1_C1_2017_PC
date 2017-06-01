using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensajes
{
   public class MensajeDibujarPuntos : MensajeBase
    {
        int grosor, colorRGB, cordX, cordY;
        public MensajeDibujarPuntos(string emisor, string receptor,int grosor,int colorRGB,int cordX,int cordY, int sala, string J) : base(emisor, receptor, sala)
        {
            base.TipoMensaje = this.GetType().Name;
        }
        public int Grosor {
            get { return grosor; }
            set { grosor = value; }
        }
        public int ColorRGB
        {
            get { return colorRGB; }
            set { colorRGB = value; }
        }
        public int CordX
        {
            get { return cordX; }
            set { cordX = value; }
        }
        public int CordY
        {
            get { return cordY; }
            set { cordY = value; }
        }
    }
}
