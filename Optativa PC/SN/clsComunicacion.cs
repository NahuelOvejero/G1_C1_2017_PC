using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN
{
    public class clsComunicacion
    {
        

        public void enviaEjes( int x1, int y1,frmPrueba formu)
        {
            formu.dibujar(x1, y1);

        }

       public void enviaRta(string rta,frmJuego formu)
        {
            formu.rtasIncorrectas(rta);
        }
    }
}
