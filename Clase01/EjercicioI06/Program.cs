using System;

namespace EjercicioI06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int inicio;
            int fin;

            Console.WriteLine("Ingrese un año");
            userInput = Console.ReadLine();

            while(!int.TryParse(userInput,out inicio))
            {
                Console.WriteLine("Error, ingrese un año valido");
                userInput = Console.ReadLine();
            }

            Console.WriteLine("Ingrese un año");
            userInput = Console.ReadLine();

            while (!int.TryParse(userInput, out fin))
            {
                Console.WriteLine("Error, ingrese un año valido");
                userInput = Console.ReadLine();
            }

            for (int i = inicio; i < fin; i++)
            {
                if(i%4==0)
                {
                    if (i % 100 == 0)
                    {
                        if (i % 400 == 0)
                        {
                            Console.WriteLine("El año {0} es bisiesto",i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("El año {0} es bisiesto",i);
                    }
                }
            }
        }
    }
}
