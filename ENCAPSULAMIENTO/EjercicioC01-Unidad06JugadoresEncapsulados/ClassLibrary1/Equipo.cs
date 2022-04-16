using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        public List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre):this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
           
            if(e.jugadores.Count < e.cantidadDeJugadores )
            {
                foreach (Jugador jug in e.jugadores)
                {
                    if (jug == j)
                    {
                        return false;
                    }
                }
                e.jugadores.Add(j);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
