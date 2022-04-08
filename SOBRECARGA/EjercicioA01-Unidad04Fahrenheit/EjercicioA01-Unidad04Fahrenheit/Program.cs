using System;
using ClassLibrary;

namespace EjercicioA01_Unidad04Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fahrenheit gradoF = new Fahrenheit(126);
            Kelvin gradoK = new Kelvin(24);
            Celsius gradoC = new Celsius(80);

            Console.WriteLine(gradoK);
            Console.WriteLine((Celsius)gradoK);
            Console.WriteLine((Fahrenheit)gradoK);            
            
            Console.WriteLine(gradoF);
            Console.WriteLine((Celsius)gradoF);
            Console.WriteLine((Kelvin)gradoF);            
            
            Console.WriteLine(gradoC);
            Console.WriteLine((Kelvin)gradoC);
            Console.WriteLine((Fahrenheit)gradoC);            
            



        }
    }
}
