using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtensionDatetime
    {
        public static double DiferenciaDias(this DateTime inicio, DateTime fin)
        {
            return (fin - inicio).TotalSeconds;
        }
    }
}
