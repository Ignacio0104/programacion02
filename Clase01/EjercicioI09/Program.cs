using System;

namespace EjercicioI09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            uint numero;
            uint cantidad;
            uint centro;
            uint limite;

            Console.WriteLine("Ingrese un numero");
            userInput = Console.ReadLine();

            while (!uint.TryParse(userInput, out numero))
            {
                Console.WriteLine("Error, ingrese un valor valido");
                userInput = Console.ReadLine();
            }
            cantidad = numero * 2 - 1;
            for (int i = 1; i <= numero; i++)
            {
                centro = (cantidad / 2) ;
                limite = 1;
                for (uint j = 0; j < cantidad; j++)
                {
                    if(j == centro||j==centro+limite||j==centro-limite)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("x");
                    }
                    limite++;
                }
                

                Console.WriteLine("");
            }
        }
    }
}
