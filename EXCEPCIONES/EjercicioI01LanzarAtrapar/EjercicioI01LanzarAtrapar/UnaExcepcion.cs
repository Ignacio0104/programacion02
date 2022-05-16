using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI01LanzarAtrapar
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion()
        {
        }

        public UnaExcepcion(string message) : base(message)
        {
        }

        public UnaExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
