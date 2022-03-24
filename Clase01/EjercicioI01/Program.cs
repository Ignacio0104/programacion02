using System;

namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mayor = int.MinValue;
            int menor = int.MaxValue; 
            double acumulador = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");
                string numeroString = Console.ReadLine();
                int numeroInt;

                while (!int.TryParse(numeroString,out numeroInt))
                {
                    Console.WriteLine("Error, ingrese un número");
                    numeroString = Console.ReadLine();
                }

                if (numeroInt > mayor)
                {
                    mayor = numeroInt;
                } else if(numeroInt < menor)
                {
                    menor= numeroInt;
                }

                acumulador += numeroInt;
            }

            double promedio = (float)acumulador / 5;

            Console.WriteLine("El numero mas grande fue {0}. El numero mas chico fue {1} y el promedio es {2:#.##}",mayor,menor,promedio);
        }
    }
}
