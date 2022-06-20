using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class SinClientesException : Exception
    {
        public SinClientesException()
        {
        }

        public SinClientesException(string message) : base(message)
        {
        }

        public SinClientesException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
