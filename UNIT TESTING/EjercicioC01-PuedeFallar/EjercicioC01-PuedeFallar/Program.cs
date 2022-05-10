using System;

namespace EjercicioC01_PuedeFallar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero ");
            string numeroInput = Console.ReadLine();
            int numeroIngresado;

            int.TryParse(numeroInput, out numeroIngresado);
            Console.WriteLine(numeroIngresado.FizzBuzz());

            Console.Write("Ingrese un numero ");
            numeroInput = Console.ReadLine();
            int.TryParse(numeroInput, out numeroIngresado);
            Console.WriteLine(numeroIngresado.FizzBuzz());

            Console.Write("Ingrese un numero ");
            numeroInput = Console.ReadLine();
            int.TryParse(numeroInput, out numeroIngresado);
            Console.WriteLine(numeroIngresado.FizzBuzz());

            Console.Write("Ingrese un numero ");
            numeroInput = Console.ReadLine();
            int.TryParse(numeroInput, out numeroIngresado);
            Console.WriteLine(numeroIngresado.FizzBuzz());
        }
    }
}
