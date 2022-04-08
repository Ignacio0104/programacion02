using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI08_Unidad02
{
    internal class CalculoTiempo
    {
        public static double CalcularDias(int dia,int mes,int ano)
        {
            DateTime inicio = new DateTime(ano, mes, dia);

            DateTime final = new DateTime(DateTime.Now.Year,DateTime.Now.Month, DateTime.Now.Day);

            int contadorDias = 0;

            for(DateTime i = inicio; i < final; i=i.AddDays(1))
            {
                contadorDias += 1;
            }

            return contadorDias;
        }
    }
}
