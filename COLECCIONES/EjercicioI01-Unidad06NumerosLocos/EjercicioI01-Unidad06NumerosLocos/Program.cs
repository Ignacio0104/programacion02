using System;
using System.Collections.Generic;

namespace EjercicioI01_Unidad06NumerosLocos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();


            for (int i = 0; i < 20; i++)
            {
                Random rnd = new Random();
                lista.Add(rnd.Next(-1000, 1000));
            }

            Mostrar(lista);
            lista.Sort();
            Console.WriteLine("Lista ordenada ascendente ---------------------------------");
            Mostrar(lista);
            lista.Sort(Criterio);
            Console.WriteLine("Lista ordenada descendente ---------------------------------");
            Mostrar(lista);


        }

        public static int Criterio(int elemento1, int elemento2)
        {
            return elemento2 - elemento1;
        }


        public static void Mostrar(List<int> coleccion)
        {
            foreach (var item in coleccion)
            {
                Console.WriteLine(item);
            }
        }



    }
}
