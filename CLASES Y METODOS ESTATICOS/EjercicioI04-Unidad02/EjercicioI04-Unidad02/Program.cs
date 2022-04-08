using System;

namespace EjercicioI04_Unidad02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            decimal numeroUno;
            decimal numeroDos;
            string operacion;
            decimal resultado;
            bool continuar = false;

            Console.WriteLine("Desea comenzar? S (si) o N (no)");
            userInput = Console.ReadLine();

            while (userInput.ToLower() != "s" && userInput.ToLower() != "n")
            {
                Console.WriteLine("Favor ingresar una opción válida. Desea comenzar? S (si) o N (no)");
                userInput = Console.ReadLine();
            }

            if (userInput.ToLower() == "s")
            {
                continuar = true;
            }
            else
            {
                Console.WriteLine("Cerrando el programa...");
                continuar = false;
            }

            while (continuar)
            {
                Console.WriteLine("Indique el primer numero");
                userInput = Console.ReadLine();

                while (!decimal.TryParse(userInput, out numeroUno))
                {
                    Console.WriteLine("Favor ingresar un número");
                    userInput = Console.ReadLine();
                }

                Console.WriteLine("Indique el segundo numero");
                userInput = Console.ReadLine();

                while (!decimal.TryParse(userInput, out numeroDos))
                {
                    Console.WriteLine("Favor ingresar un número");
                    userInput = Console.ReadLine();
                }

                Console.WriteLine("Indique la operación (+,-,/,*)");
                userInput = Console.ReadLine();

                while (userInput != "+" && userInput != "-" && userInput != "*" && userInput != "/")
                {
                    Console.WriteLine("Favor ingresar una opción válida (+,-,/,*)");
                    userInput = Console.ReadLine();
                }

                operacion = userInput;

                Console.Clear();
                resultado = Calculadora.Calcular(numeroUno, numeroDos, operacion);
                Console.WriteLine("El resultado de {0} {1} {2} es {3}",numeroUno, operacion, numeroDos, resultado);

                Console.WriteLine("Desea continuar? S (si) o N (no)");
                userInput = Console.ReadLine();

                while (userInput.ToLower() != "s" && userInput.ToLower() != "n")
                {
                    Console.WriteLine("Favor ingresar una opción válida. Desea comenzar? S (si) o N (no)");
                    userInput = Console.ReadLine();
                }

                if (userInput.ToLower() == "s")
                {
                    continuar = true;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Cerrando el programa...");
                    continuar = false;
                }

            }
        }
    }
}
