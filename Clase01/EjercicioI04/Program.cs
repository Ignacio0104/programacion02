using System;

namespace EjercicioI04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorPerfectos = 0;
            for (int i = 1; contadorPerfectos < 5; i++)
            {
                int acumulador = 0;

                int j = 1;

                while (j < i)
                {
                    if (i % j == 0)
                    {
                        acumulador = acumulador + j;
                    }
                    j++;
                }

                if (acumulador == i)
                {
                    Console.WriteLine("El numero {0} es perfecto", i);
                    contadorPerfectos++;
                }
            }
        }
    }
}
