using System;

namespace EjercicioI02_Unidad02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("Desea continuar? (S/N)");
            userInput = Console.ReadLine();

            if (Validador.ValidarRespuesta(userInput))
            {
                Console.WriteLine("Continuaste");
            }
            else
            {
                Console.WriteLine("Saliste...");
            }

           
        }
    }
}
