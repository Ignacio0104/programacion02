using System;
using System.Linq;

namespace EjercicioI08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            uint numero;
            int cantidad = 1;

            Console.WriteLine("Ingrese un numero");
            userInput = Console.ReadLine();

            while (!uint.TryParse(userInput, out numero))
            {
                Console.WriteLine("Error, ingrese un valor valido");
                userInput = Console.ReadLine();
            }

            for (int i = 1; i <= numero; i++)
            {
                for (int j = 0; j < cantidad; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                cantidad += 2;
            }
        }
    }
}
