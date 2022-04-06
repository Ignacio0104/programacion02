using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Logica
    {
        public static int MasKilometrosSemana(Conductor[] conductores)
        {
            int maximo = int.MinValue;

            int acumulador = 0;
            for (int i = 0; i < conductores.Length; i++)
            {
                acumulador = 0;
                int[] listaKms = conductores[i].GetKilometro();
                for (int j = 0; j < listaKms.Length; j++)
                {
                    acumulador = acumulador + listaKms[j];
                }

                if (acumulador > maximo)
                {
                    maximo = acumulador;
                }
            }

            return maximo;

        }

        public static int MasKilometrosDia(Conductor[] conductores,int dia)
        {
            int maximo = int.MinValue;

            for (int i = 0; i < conductores.Length; i++)
            {
                int kilometros = conductores[i].GetKilometro()[dia-1];
              
                if (kilometros > maximo)
                {
                    maximo = kilometros;
                }
            }

            return maximo;

        }
   
    }
}
