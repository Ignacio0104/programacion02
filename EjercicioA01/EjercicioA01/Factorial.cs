using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioA01
{
    internal class Factorial
    {
        public static double CalcularFactorial(int numero)
        {
            double result = 1;

            for (int i = 1; i < numero; i++)
            {
                result *= i + 1;
            }

            return result;
        }
    }
}
