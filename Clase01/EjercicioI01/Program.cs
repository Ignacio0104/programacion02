using System;

namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mayor = int.MinValue;
            double menor = int.MaxValue; 
            double acumulador = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero");
                string numeroString = Console.ReadLine();
                double numeroInt;

                while (!double.TryParse(numeroString,out numeroInt))
                {
                    Console.WriteLine("Error, ingrese un número");
                    numeroString = Console.ReadLine();
                }

                if (numeroInt > mayor)
                {
                    mayor = numeroInt;
                }

                if(numeroInt < menor)
                {
                    menor= numeroInt;
                }

                acumulador += numeroInt;
            }

            double promedio = acumulador / 5;

            Console.WriteLine("El numero mas grande fue {0}. El numero mas chico fue {1} y el promedio es {2}",mayor,menor,promedio);
        }
    }
}
