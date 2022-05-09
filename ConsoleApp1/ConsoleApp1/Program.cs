using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Persona
    {
        int nombre;

    }

    public class Estudiante : Persona
    {
        int numero;
        public Estudiante()
        {
            numero = 23;
        }
    }
}
