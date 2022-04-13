using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI03_Unidad02
{
    internal class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string numeroBinario = "";

            while (numeroEntero > 0)
            {
                string digito = (numeroEntero % 2).ToString();
                numeroBinario = digito + numeroBinario;
                numeroEntero /= 2;
            }

            return numeroBinario;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int result = 0;
            string binarioString = numeroEntero.ToString();
            int potencia = binarioString.Length-1;
            for (int i = 0; i < binarioString.Length; i++)
            {
                if (binarioString[i] is '1')
                {
                    result += (int)Math.Pow(2, potencia);
                }
                potencia--;
            }

            return result;
        }

        public static bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '1' && binario[i] != '0')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
