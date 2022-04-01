using System;
using BibliotecaDeClases;

namespace EjercicioI02_Unidad03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Pedro", new DateTime(1995, 4, 1), 38994938);
            Persona p2 = new Persona("Santiago", new DateTime(2010, 12, 3), 39567123);
            Persona p3 = new Persona("Jesus", new DateTime(2021, 2, 25), 11111111);

            Console.WriteLine(p1.Mostrar());
            Console.WriteLine(p2.Mostrar());
            Console.WriteLine(p3.Mostrar());
        }
    }
}
