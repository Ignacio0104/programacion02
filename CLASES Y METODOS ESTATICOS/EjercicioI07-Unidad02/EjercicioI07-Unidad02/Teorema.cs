using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI07_Unidad02
{
    internal class Teorema
    {
        public static double Calcular (double baseIngresada , double altura)
        {
            double result;

            result = Math.Pow(baseIngresada, 2) + Math.Pow(altura, 2);
            result = Math.Sqrt(result);

            return result;
        }
    }
}
