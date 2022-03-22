using System;

namespace EjercicioI02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroString;
            uint numero;
            double cuadrado;
            double cubo;

            Console.WriteLine("Ingrese un número");
            numeroString = Console.ReadLine();
            while(!uint.TryParse(numeroString, out numero))
            {
                Console.WriteLine("Error, numero invalido");
                Console.WriteLine("Ingrese un número");
                numeroString = Console.ReadLine();
            }

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("El cuadrado de {0} es {1}",numero,cuadrado);
            Console.WriteLine("El cubo de {0} es {1}", numero, cubo);

        }
    }
}
