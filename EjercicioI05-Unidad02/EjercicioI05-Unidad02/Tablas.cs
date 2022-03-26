using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI05_Unidad02
{
    internal class Tablas
    {
        public static StringBuilder Calcular(int numero)
        {
            StringBuilder resultado = new StringBuilder();

            for(int i=1; i<= 10; i++)
            {
                int cuenta = numero * i;

                resultado.AppendLine($"{numero} x {i} = {cuenta}");
            }

            return resultado;
        }
    }
}
