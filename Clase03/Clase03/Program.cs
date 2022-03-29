using System;

namespace Veterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato garfield = new Gato("Garfield", new DateTime(1995,4,1) );
            garfield.AsignarPeso(5);
            Console.WriteLine(garfield.obtenerDatos());
        }
    }
}
