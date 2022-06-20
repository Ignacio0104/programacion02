using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class ExtensionRandom
    {
       public static int TirarUnaMoneda(this Random numeroRandom)
        {
            return (int)numeroRandom.Next(1, 2);
        }
    }
}
