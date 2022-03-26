using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI04_Unidad02
{
    internal class Calculadora
    {
        public static decimal Calcular (decimal numeroUno, decimal numeroDos, string operacion)
        {
            decimal result = 0;
            switch (operacion)
            {
                case "+":
                    result = numeroUno + numeroDos;
                    break;
                case "-":
                    result = numeroUno - numeroDos;
                    break;
                case "*":
                    result = numeroUno * numeroDos;
                    break;
                case "/":
                    if (Validar(numeroDos))
                    {
                        result = numeroUno / numeroDos;
                    }
                    break;
            }

            return result;
        }

        private static bool Validar (decimal segundoOperando)
        {
            if (segundoOperando == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
