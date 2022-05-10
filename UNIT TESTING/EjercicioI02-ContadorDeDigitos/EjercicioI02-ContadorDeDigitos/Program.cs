using System;

namespace EjercicioI02_ContadorDeDigitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            string numeroString = Console.ReadLine();
            Int64 numeroIngresado;
            Int64.TryParse(numeroString, out numeroIngresado);
            int resultado = ContadorDigitos.CantidadDeDigitos(numeroIngresado);
            Console.WriteLine($"Numero de \t {resultado} digitos");

            Console.Write("Ingrese un numero: ");
            numeroString = Console.ReadLine();
            Int64.TryParse(numeroString, out numeroIngresado);
            resultado = ContadorDigitos.CantidadDeDigitos(numeroIngresado);
            Console.WriteLine($"Numero de \t {resultado} digitos");

            Console.Write("Ingrese un numero: ");
            numeroString = Console.ReadLine();
            Int64.TryParse(numeroString, out numeroIngresado);
            resultado = ContadorDigitos.CantidadDeDigitos(numeroIngresado);
            Console.WriteLine($"Numero de \t {resultado} digitos");

            Console.Write("Ingrese un numero: ");
            numeroString = Console.ReadLine();
            Int64.TryParse(numeroString, out numeroIngresado);
            resultado = ContadorDigitos.CantidadDeDigitos(numeroIngresado);
            Console.WriteLine($"Numero de \t {resultado} digitos");
        }
    }
}
