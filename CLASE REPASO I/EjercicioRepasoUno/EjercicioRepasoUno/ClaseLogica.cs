using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioRepasoUno
{
    public static class ClaseLogica
    {
        static int cantidadProductos;
        static bool productosDisponibles;

        static ClaseLogica()
        {
            cantidadProductos = 10;
            productosDisponibles = true;
        }

        public static bool ValidarProductos(int limite)
        {
            if (cantidadProductos > limite)
            {
                return true;
            }

            return false;
        }
    }
}
