using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI06_Unidad02
{
    internal class CalculadorDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return longitudLado * longitudLado;
        }

        public static double CalcularAreaTriangulo (double baseIngresada, double altura)
        {
            return (baseIngresada * altura) / 2;
        }

        public static double CalcularAreaCirculo (double radio)
        {
            float pi = 3.14F;

            return Math.Pow((pi * radio), 2);

        }
    }
}
