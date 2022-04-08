using System;


namespace EjercicioI01_Unidad02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int numero;
            int acumulador = 0;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            decimal promedio;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero");
                userInput = Console.ReadLine();

                while(!int.TryParse(userInput,out numero) || !Validador.Validar(numero, -100, 100))
                {
                    Console.WriteLine("Error, ingrese un valor valido");
                    userInput = Console.ReadLine();
                }
                acumulador += numero;
                if (numero > maximo)
                {
                    maximo = numero;
                }
                if (numero < minimo)
                {
                    minimo = numero;
                }

    
            }
            promedio = (decimal)acumulador / 10;

            Console.WriteLine($"El mayor numero fue {maximo}. El menr numero fue {minimo}. Y el promedio fue {promedio}");
        }
    }
}
