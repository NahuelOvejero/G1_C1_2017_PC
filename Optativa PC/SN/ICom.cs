using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SN
{
    public interface ICom
    {


        void enviaEjes(Pen lapiz, int x1, int y1, frmPrueba formu);

        bool enviaRta(string rta, frmJuego formu);


       bool corroborar(string palabraEnviada);

        void enviarDibujado(Pen lapiz, Point p1, Point p2);

       /* void conectaUser(clsUsuario us);//para tener registrado usuario que ingresa

        List<string> listaSalas();//entrega lista de salas con la cantidad de usuarios en ellas
                                  //se podria crear la clase sala
        List<clsUsuario> listaUsuarios();//para que devuelva lista usuarios con sus puntos q son de una sala
                                         //puede q tenga q recibir algun parametro q especifiq para q sala es

        void enviarTimer(string sala, clsUsuario us);//para controlar los tiempo de dibujo

        void selecDibujante(string sala, List<clsUsuario> users);//recibe la sala y los users de ella
        //e indica a quien le toca dibujar,se podria hacer q resiba un solo objeto q contenga la sala y los integrantes

        */


    }
}
