using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC01_PuedeFallar
{
    public static class ClaseFizzBuzz
    {
        public static string FizzBuzz(this int numero)
        {
            if (numero % 5 == 0 && numero % 3 == 0)
            {
                return "Fizz Buzz";
            }else if (numero % 5 == 0)
            {
                return "Buzz";
            }else if(numero %3 == 0)
            {
                return "Fizz";
            }
            return numero.ToString();
        }
    }
}
