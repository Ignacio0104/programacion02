﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI01LanzarAtrapar
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion()
        {
        }

        public MiExcepcion(string message) : base(message)
        {
        }

        public MiExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
