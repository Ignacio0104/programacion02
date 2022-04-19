using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BibliotecaDeClases.Llamada;

namespace Centralita
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Local);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }


        public float GananciaPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            razonSocial = nombreEmpresa;
        }


        private float CalcularGanancia(TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;

            foreach (var item in listaDeLlamadas)
            {
                if(item is Local variableLocal)
                {
                    gananciaLocal += variableLocal.CostoLlamada;
                } else if(item is Provincial variableProvincial)
                {
                    gananciaProvincial += variableProvincial.CostoLlamada;
                }
            }

           switch (tipo)
            {
                case TipoLlamada.Local:
                    return gananciaLocal;
                case TipoLlamada.Provincial:
                    return gananciaProvincial;
                default:
                    return gananciaLocal + gananciaProvincial;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razon social: {razonSocial}");
            sb.AppendLine($"Ganancia Local: {GananciaPorLocal}");
            sb.AppendLine($"Ganancia Provincial: {GananciaPorProvincial}");
            sb.AppendLine($"Ganancia Total: {GananciaPorTotal}");
            sb.AppendLine($"Lista de llamadas");
            foreach (var item in listaDeLlamadas)
            {
                if(item is Local llamadaLocal)
                {
                    sb.AppendLine(llamadaLocal.Mostrar());
                }else if(item is Provincial llamadaProvincial)
                {
                    sb.AppendLine(llamadaProvincial.Mostrar());
                }
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
