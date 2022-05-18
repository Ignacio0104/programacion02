using System;

namespace ClaseArchivos02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Archivos02.Escribir();

            Console.WriteLine(Archivos02.Leer("Laboratorio"));
        }
    }
}
