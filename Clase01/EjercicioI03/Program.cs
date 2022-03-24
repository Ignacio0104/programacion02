using System;

namespace EjercicioI03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroInt;
            bool continuar = false;
            string userInput;

            Console.WriteLine("Desea comenzar? S (si) o N (no)");
            userInput = Console.ReadLine().ToLower();

            while (userInput != "s" && userInput != "n")
            {
                Console.WriteLine("Favor ingresar una de las opciones. S (si) o N (no)");
                userInput = Console.ReadLine().ToLower();
            }
            if (userInput == "s")
            {
                continuar = true;
            }
            else
            {
                Console.WriteLine("Cerrando sistema...");
            }

            while (continuar)
            {
                Console.WriteLine("Ingrese un numero");
                userInput = Console.ReadLine().ToLower();

                while (!int.TryParse(userInput, out numeroInt) || numeroInt < 1)
                {
                    Console.WriteLine("Error, ingrese un numero valido o presione N para salir");
                    userInput = Console.ReadLine().ToLower();
                    if (userInput == "s")
                    {
                        continuar = true;
                    }
                    else if (userInput == "n")
                    {
                        continuar = false;
                        Console.WriteLine("Cerrando sistema...");
                        break;
                    }
                }

                for (int i = numeroInt; i > 0; i--)
                {
                    int divisores = 0;
                    int j = 1;

                    while (j <= i)
                    {
                        if (i % j == 0)
                        {
                            divisores++;
                        }

                        j++;
                    }

                    if (divisores <= 2)
                    {
                        Console.WriteLine("El numero {0} es primo", i);
                    }
                }

                Console.WriteLine("Desea continuar? S (si) o N (no)");
                userInput = Console.ReadLine().ToLower();

                while (userInput != "s" && userInput != "n")
                {
                    Console.WriteLine("Favor ingresar una de las opciones. S (si) o N (no)");
                    userInput = Console.ReadLine().ToLower();
                }
                if (userInput == "s")
                {
                    continuar = true;
                }
                else if (userInput == "n")
                {
                    continuar = false;
                    Console.WriteLine("Cerrando sistema...");

                }

            }
        }
    }
}
