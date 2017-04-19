using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN
{
    class ClsUser
    {
        string usuario;
        string pasword;
        int puntos;
        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Pasword
        {
            get
            {
                return pasword;
            }

            set
            {
                pasword = value;
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
