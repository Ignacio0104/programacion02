using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI01LanzarAtrapar
{
    public class MiClase
    {
        string nombre;
        public MiClase(string nombre)
        {
            this.nombre = nombre;
            try
            {
                MetodoDePrueba();
            }
            catch (DivideByZeroException ex)
            {
                throw new DivideByZeroException("fallo2", ex);
            }
        }

        public MiClase()
        {
            try
            {
                MiClase objeto = new MiClase();
            }
            catch (DivideByZeroException ex)
            {
                throw new DivideByZeroException("fallo3", ex);
            }

        }

        public static void MetodoDePrueba()
        {
            throw new DivideByZeroException("fallo1");
        }
    }
}
