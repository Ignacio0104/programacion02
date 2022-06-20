using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class ExtensionDateTime
    {
        public static double DiferenciaTiempo(this DateTime inicio, DateTime fin)
        {
            return (fin - inicio).TotalSeconds;
        }
    }
}
