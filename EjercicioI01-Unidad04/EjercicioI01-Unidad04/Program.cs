using System;
using BibliotecaDeClases;

namespace EjercicioI01_Unidad04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumadorUno = new Sumador(32);
            Sumador sumadorDos = new Sumador(35);

            Console.WriteLine(sumadorUno.Mostrar());

            Console.WriteLine(sumadorUno.Sumar(23,56));
            Console.WriteLine(sumadorUno.Sumar("Hola","Juan Carlo"));
            Console.WriteLine(sumadorUno.Sumar("Hola", "Pedro"));
            Console.WriteLine(sumadorUno.Mostrar());

            Console.WriteLine(sumadorUno | sumadorDos);

        }
    }
}
