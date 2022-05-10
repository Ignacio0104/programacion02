using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI02_ContadorDeDigitos
{
    public static class ContadorDigitos
    {
        public static int CantidadDeDigitos (this Int64 numero) //Int 64 idem que LONG
        {
            string numeroString = numero.ToString();
            if (numeroString[0] == '-')
            {
                return numeroString.Length-1;
            }
            return numeroString.Length;

        }


    }
}
