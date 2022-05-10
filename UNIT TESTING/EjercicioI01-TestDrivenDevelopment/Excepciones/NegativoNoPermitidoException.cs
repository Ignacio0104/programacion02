using System;

namespace Excepciones
{
    public class NegativoNoPermitidoException :Exception
    {
        public NegativoNoPermitidoException(string mensaje): base(mensaje)
        {

        }
    }
}
