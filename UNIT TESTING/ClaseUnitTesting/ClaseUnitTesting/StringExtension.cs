using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseUnitTesting
{
    public static class StringExtension
    {
        public static int ContarVocales(this string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new BusinessException("Error");
            }
            texto = texto.ToLower();
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            int contador = 0;

            foreach (char item in texto)
            {
                if (vocales.Contains(item))
                {
                    contador++;
                }
            }
            return contador;
        }

        public static int ContarCaracteres(this string texto, char caracter)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return 0;
            }
            texto = texto.ToLower();
            char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
            int contador = 0;

            foreach (char item in texto)
            {
                if (item == caracter)
                {
                    contador++;
                }
            }
            return contador;
        }

   
    }
}
