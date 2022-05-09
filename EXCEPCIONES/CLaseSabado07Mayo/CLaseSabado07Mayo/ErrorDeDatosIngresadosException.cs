using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CLaseSabado07Mayo
{
    internal class ErrorDeDatosIngresadosException : Exception
    {
        public ErrorDeDatosIngresadosException()
        {
        }

        public ErrorDeDatosIngresadosException(string message) : base(message)
        {
        }

        public ErrorDeDatosIngresadosException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
