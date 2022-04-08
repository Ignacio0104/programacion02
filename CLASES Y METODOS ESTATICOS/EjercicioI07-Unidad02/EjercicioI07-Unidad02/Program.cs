using System;

namespace EjercicioI07_Unidad02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double baseIngresada;
            double altura;


            Console.WriteLine("Ingrese la base de triangulo");
            userInput = Console.ReadLine();

            while (!double.TryParse(userInput, out baseIngresada))
            {
                Console.WriteLine("Ingrese un numero valido");
                userInput = Console.ReadLine();
            }


            Console.WriteLine("Ingrese la altura de triangulo");
            userInput = Console.ReadLine();

            while (!double.TryParse(userInput, out altura))
            {
                Console.WriteLine("Ingrese un numero valido");
                userInput = Console.ReadLine();
            }

            Console.WriteLine(Teorema.Calcular(baseIngresada,altura));
        }
    }
}
