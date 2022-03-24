using System;
using Formulas = proyecto02.Formulas;

namespace Clase02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string datos = Formulas.DevolverMensaje();

            Console.WriteLine(datos);
        }
    }
}
