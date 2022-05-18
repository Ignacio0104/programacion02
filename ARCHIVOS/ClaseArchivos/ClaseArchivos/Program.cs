using System;

namespace ClaseArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Archivo.Escribir();
            Console.WriteLine( Archivo.Leer("Laboratorio"));
        }
    }
}
