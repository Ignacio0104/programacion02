using System;

namespace EjercicioI05_Unidad02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int numeroIngresado;
            bool continuar = false;

            Console.WriteLine("Desea comenzar? S o N");
            userInput = Console.ReadLine();

            while(userInput.ToLower()!="s"&& userInput.ToLower() != "n")
            {
                Console.WriteLine("Ingrese una opcion valida: S o N");
                userInput = Console.ReadLine();
            }

            if (userInput.ToLower() == "s")
            {
                continuar = true;
            }
            else
            {
                continuar = false;
                Console.WriteLine("Cerrando el sistema...");
            }


            while (continuar)
            {
                Console.WriteLine("Ingrese un numero");
                userInput = Console.ReadLine();
                while (!int.TryParse(userInput, out numeroIngresado))
                {
                    Console.WriteLine("Error, ingrese un numero valido");
                    userInput = Console.ReadLine();
                }

                Console.WriteLine(Tablas.Calcular(numeroIngresado));

                Console.WriteLine("Desea continuar? S o N");
                userInput = Console.ReadLine();

                while (userInput.ToLower() != "s" && userInput.ToLower() != "n")
                {
                    Console.WriteLine("Ingrese una opcion valida: S o N");
                    userInput = Console.ReadLine();
                }

                if (userInput.ToLower() == "s")
                {
                    continuar = true;
                    Console.Clear();
                }
                else
                {
                    continuar = false;
                    Console.WriteLine("Cerrando el sistema...");
                }
            }

        }
    }
}
