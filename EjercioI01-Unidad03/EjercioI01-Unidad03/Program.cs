using System;
using Entidades;

namespace EjercioI01_Unidad03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta santander = new Cuenta("Ignacio", 140000.25m);

            Console.WriteLine(santander.Mostrar());

            santander.Ingresar(60000);

            Console.WriteLine(santander.Mostrar());

            santander.Retirar(100000);

            Console.WriteLine(santander.Mostrar());

        }
    }
}
