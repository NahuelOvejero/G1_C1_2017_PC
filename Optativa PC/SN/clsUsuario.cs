using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN
{
    public class clsUsuario
    {
        string user;
        int puntos;

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public int Puntos
        {
            get
            {
                return puntos;
            }

            set
            {
                puntos = value;
            }
        }
    }
}
