using System;

namespace EjercicioI05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int numero;
            bool existeMitad = false;

            Console.WriteLine("Ingrese un numero");
            userInput = Console.ReadLine();

            while (!int.TryParse(userInput, out numero))
            {
                Console.WriteLine("Error, ingrese un valor válido");
                userInput = Console.ReadLine();
            }

            int[] arrayNumerico = new int[numero+1];

            for (int i = 0; i < arrayNumerico.Length; i++)
            {
                arrayNumerico[i] = i;
            }

            for (int centro = 1; centro < arrayNumerico.Length; centro++)
            {
                int sumaPrimeraMitad = 0;
             
                for (int j = 0; j < centro; j++)
                {
                    sumaPrimeraMitad = sumaPrimeraMitad + arrayNumerico[j];
                }
                int sumaSegundaMitad = 0;
                for (int x = centro + 1; x <= sumaPrimeraMitad; x++)
                {
                    if ((sumaSegundaMitad == sumaPrimeraMitad) || (x >= arrayNumerico.Length))
                    {
                        break;
                    }

                    sumaSegundaMitad = sumaSegundaMitad + arrayNumerico[x];

                }
                if (sumaPrimeraMitad == sumaSegundaMitad)
                {
                    Console.WriteLine("El {0} es un centro numerico", arrayNumerico[centro]);
                    existeMitad = true;
                }
                else
                {
                    sumaSegundaMitad = 0;
                }
            }

            if (!existeMitad)
            {
                Console.WriteLine("No existe un centro exacto en esta lista");
            }
        }
    }
}
