using System;
using System.Collections.Generic;
using ClassLibrary1;

namespace EjercicioC01_Unidad06EstadisticaDeportiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo team = new Equipo(10, "Bulls");
            Jugador j1 = new Jugador(1, "Pedro",20,10);
            Jugador j2 = new Jugador(2, "Juan",5,10);
            Jugador j3 = new Jugador(3, "Santiago",10,10);
            Jugador j4 = new Jugador(4, "Tomas",3,10);
            Jugador j5 = new Jugador(5, "Matias",5,10);
            Jugador j6 = new Jugador(6, "Valentin",35,10);
            Jugador j7 = new Jugador(7, "Sandro",2,10);
            Jugador j8 = new Jugador(8, "Mauricio",5,10);
            Jugador j9 = new Jugador(9, "Lucas",6,10);
            Jugador j10 = new Jugador(10, "Sebastian",19,10);

            Console.WriteLine(team + j1);
            Console.WriteLine(team + j2);
            Console.WriteLine(team + j3);
            Console.WriteLine(team + j3);
            Console.WriteLine(team + j5);
            Console.WriteLine(team + j6);
            Console.WriteLine(team + j7);
            Console.WriteLine(team + j8);
            Console.WriteLine(team + j9);
            Console.WriteLine(team + j10);
            Console.WriteLine(team + j10);

            Console.WriteLine(team.jugadores.Count);

            foreach (var item in team.jugadores)
            {
                Console.WriteLine(item.MostrarDatos());
            }

            
        }
    }
}
