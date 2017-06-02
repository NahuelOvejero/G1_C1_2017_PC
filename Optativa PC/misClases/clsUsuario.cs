﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace misClases
{
    public class clsUsuario
    {
        string user;
        int puntos;
        //los reportes se acumulan por partida 
        int reportes = 0 ;
        object _lockPuntos = new object();

        public void reiniciarReportes()
        {
            this.reportes = 0;
        }

        public void sumarReporte() {
            reportes++;
        }
        public int getReportes() {
            return this.reportes;
        }
        


        public string User
        {
            get{return user;}
            set{user = value;}
        }

        public int Puntos
        {
            get { lock (_lockPuntos) { return puntos; }
        }
            set{ lock (_lockPuntos) { puntos = value; } }
        }
    }
}
