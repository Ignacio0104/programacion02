using System;

namespace EjercicioI06_Unidad02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            double ladoIngresado;
            double baseIngresada;
            double altura;
            double radio;

            Console.WriteLine("Ingrese el lado del cuadrado");
            userInput = Console.ReadLine();

            while(!double.TryParse(userInput,out ladoIngresado))
            {
                Console.WriteLine("Ingrese un numero valido");
                userInput = Console.ReadLine();
            }

            Console.WriteLine("Ingrese la base del triangulo");
            userInput = Console.ReadLine();

            while (!double.TryParse(userInput, out baseIngresada))
            {
                Console.WriteLine("Ingrese un numero valido");
                userInput = Console.ReadLine();
            }

            Console.WriteLine("Ingrese la altura del triangulo");
            userInput = Console.ReadLine();

            while (!double.TryParse(userInput, out altura))
            {
                Console.WriteLine("Ingrese un numero valido");
                userInput = Console.ReadLine();
            }

            Console.WriteLine("Ingrese el radio del circulo");
            userInput = Console.ReadLine();

            while (!double.TryParse(userInput, out radio))
            {
                Console.WriteLine("Ingrese un numero valido");
                userInput = Console.ReadLine();
            }

            Console.WriteLine("El area del cuadrado es {0}",CalculadorDeArea.CalcularAreaCuadrado(ladoIngresado));
            Console.WriteLine("El area del triangulo es {0}",CalculadorDeArea.CalcularAreaTriangulo(baseIngresada,altura));
            Console.WriteLine("El area del circulo es {0}",CalculadorDeArea.CalcularAreaCirculo(radio));



        }
    }
}
