using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI02_Atrapame_si_puedes
{
    internal class ValoresNoNumericosException : Exception
    {
        public ValoresNoNumericosException()
        {
        }

        public ValoresNoNumericosException(string message) : base(message)
        {
        }

        public ValoresNoNumericosException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
