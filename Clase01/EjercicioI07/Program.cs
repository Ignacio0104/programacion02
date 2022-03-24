using System;

namespace EjercicioI07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            decimal valorHora;
            string nombreEmpleado;
            uint antiguedad;
            uint cantidadHoras;
            decimal total;
            bool continuar = false;

            do
            {
                Console.WriteLine("Ingrese el nombre del empleado");
                nombreEmpleado = Console.ReadLine();

                Console.WriteLine("Ingrese el valor hora");
                userInput = Console.ReadLine();

                while (!decimal.TryParse(userInput, out valorHora))
                {
                    Console.WriteLine("Error, Vuelva a ingresar el valor hora");
                    userInput = Console.ReadLine();
                }

                Console.WriteLine("Ingrese la cantidad de horas");
                userInput = Console.ReadLine();

                while (!uint.TryParse(userInput, out cantidadHoras))
                {
                    Console.WriteLine("Error, ingrese un valor valido");
                    userInput = Console.ReadLine();
                }

                Console.WriteLine("Ingrese la antiguedad");
                userInput = Console.ReadLine();

                while (!uint.TryParse(userInput, out antiguedad))
                {
                    Console.WriteLine("Error, ingrese un valor valido");
                    userInput = Console.ReadLine();
                }

                total = (valorHora * cantidadHoras) + (antiguedad * 150);
       

                Console.WriteLine($"El empleado {nombreEmpleado}, con {antiguedad} años de antiguedad. " +
                    $"Horas trabajadas {cantidadHoras} a un valor de {valorHora} por hora.");


                Console.WriteLine($"Salario bruto: {total}. Salario neto: {total - (total * 13 / 100)}");

                Console.WriteLine("Desea ingresar otro empleado? S (si) o N (no)");
                userInput = Console.ReadLine().ToLower();

                if (userInput == "n")
                    continuar = false;
                else
                    continuar = true;
            } while (continuar);
          
        }
    }
}
