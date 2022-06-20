using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public delegate void AvancesInfectados(int dia, long infectados);
    public delegate void FinInfectacion();
    public static class GrupoDePrueba <T> where T : Microrganismo
    {
        private static T enfermedad;
        private static long poblacion;
        public static event FinInfectacion FinalizaSimulacion;
        public static event AvancesInfectados InformeDeAvance; 


        static GrupoDePrueba()
        {
            poblacion = 10000000;
        }

        public static long Poblacion { get => poblacion; set => poblacion = value; }

        public static void InfectarPoblcacion(Object obj)
        {
            if(obj is T datoVerificado)
            {
                enfermedad = datoVerificado;
                int dia = 1;
                while (datoVerificado.IndiceDeContagios <= poblacion)
                {
                    if(InformeDeAvance is not null)
                    {
                        InformeDeAvance.Invoke(dia, datoVerificado.IndiceDeContagios);
                    }
                    dia++;
                    Thread.Sleep(750);
                }

                if(FinalizaSimulacion is not null)
                {
                    FinalizaSimulacion();
                }         
            }
        }
    }
}
