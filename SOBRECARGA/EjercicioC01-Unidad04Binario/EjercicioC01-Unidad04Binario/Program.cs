using System;
using ClassLibrary;

namespace EjercicioC01_Unidad04Binario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario numeroB = new NumeroBinario("1011011"); //91
            NumeroDecimal numedoD = new NumeroDecimal(120);// 1111000

            Console.WriteLine(numeroB + numedoD);
            Console.WriteLine(numeroB - numedoD);
            Console.WriteLine(numeroB == numedoD);
            Console.WriteLine(numeroB != numedoD);

            Console.WriteLine(numedoD + numeroB);
            Console.WriteLine(numedoD - numeroB);
            Console.WriteLine(numedoD == numeroB);
            Console.WriteLine(numedoD != numeroB);


        }
    }
}
