using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI01LanzarAtrapar
{
    public class OtraClase
    {
        public void InstanciarMiClase()
        {
            try
            {
                MiClase nuevaClase = new MiClase();
            }catch(Exception ex)
            {
                throw new MiExcepcion();
            }
            

        }
    }
}
