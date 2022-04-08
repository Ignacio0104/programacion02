using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(double numeroEntero)
        {
            string numeroBinario = "";
            int numero = (int)numeroEntero;

            while (numero > 0)
            {
                string digito = (numero % 2).ToString();
                numeroBinario = digito + numeroBinario;
                numero /= 2;
            }

            return numeroBinario;
        }

        public static double ConvertirBinarioADecimal(string numeroEntero)
        {
            int result = 0;
            string binarioString = numeroEntero.ToString();
            int potencia = binarioString.Length - 1;
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
    }
}
