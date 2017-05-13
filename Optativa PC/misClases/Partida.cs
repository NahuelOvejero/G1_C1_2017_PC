using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace misClases
{
    class Partida
    {

        //max 4 usuarios 
        //3 rondas donde cada usuario dibuja
        // 30 segundos por ronda

        clsUsuario[] jugadores = new clsUsuario[4];

        //verificar incremento, para multiples partidas.
        int idpartida =0;

        int turnoactivo = 0;
        int actuales = 0;
        int rondaActual =0;
        string palabraactual = "";

        //estas palabras podrian ser buscadas de una API , o ser cargadas cuando se genera la partida
        string[] palabras = new string[99];

        public Partida() {

            this.generarPalabra();

        }

        public int RondaActual
        {
            get
            {
                return rondaActual;
            }

            set
            {
                rondaActual = value;
            }
        }

        public int Actuales
        {
            get
            {
                return actuales;
            }

            set
            {
                actuales = value;
            }
        }

        public int Turnoactivo
        {
            get
            {
                return turnoactivo;
            }

            set
            {
                turnoactivo = value;
            }
        }

        public bool salaLlena() {

            return (this.actuales == 4);

        }

        public bool ingresarJugador(clsUsuario nuevo) {

            if (this.salaLlena())
            {
                jugadores[actuales] = nuevo;
                actuales++;
                return true;
            }
            else {

                return false;
            }
        }

        public clsUsuario ganador() {
            int puntajemaximo = 0;
            int indicejugador = 0;
            /*
             *   SI usamos foreach no podemos saber el indice del jugador.
             * foreach (clsUsuario u in usuarios) {
                 if (puntajemaximo < u.Puntos) {
                     puntajemaximo = 0;
                     indicejugador
                 }                
              */
             

            try
            {

                for (int i = 0; i < 4; i++)
                {
                    if (jugadores[i].Puntos > puntajemaximo)
                    {
                        puntajemaximo = jugadores[i].Puntos;
                        indicejugador = i;
                    }
                }
            }

            catch (Exception e) {
                return null;
            }
            
            return jugadores[indicejugador];


            }

        public bool partidaTerminada() {

            if (rondaActual == 4)
                return true;
            else
                return false;

        }

        public clsUsuario jugadordeturno() {


            if (turnoactivo >= 3)
            {
                rondaActual++;
                turnoactivo = 0;
                return jugadores[turnoactivo];
            }
            else
            {
                turnoactivo++;
                return jugadores[turnoactivo-1];

            }
        }

        public void eliminarJugador(clsUsuario u) {
            //por si se desconecta mucho tiempo, o sale voluntariamente
            //verificar como queda el array
            try
            {
                u.reiniciarReportes();
                jugadores = jugadores.Where(val => val != u).ToArray();
                actuales--;
            }

            catch (Exception e)
            {

            }

            finally {

            }


        }

        public void generarPalabra() {

            Random rnd = new Random();
            //cambiar aca por la api
            this.palabraactual = palabras[rnd.Next(1, 99)];

        }


        public void reportar(clsUsuario u) {

            u.sumarReporte();
            if (u.getReportes() == 3) {
                this.ban(u);
            }
        }

        public void ban(clsUsuario u) {
            //dar un aviso que se le dieron 3 reportes y se le va a banear.
            eliminarJugador(u);
        }

        }

    }