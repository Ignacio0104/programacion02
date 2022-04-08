using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI02_Unidad02
{
    internal class Validador
    {
        public static bool ValidarRespuesta(string letra)
        {
            if (letra == "S")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
