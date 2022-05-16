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

        private string Mostrar()
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
                    sb.AppendLine(llamadaLocal.ToString());
                }else if(item is Provincial llamadaProvincial)
                {
                    sb.AppendLine(llamadaProvincial.ToString());
                }
            }

            return sb.ToString();
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            listaDeLlamadas.Add(nuevaLlamada);
        }

        public override string ToString()
        {
            return Mostrar();
        }
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public static bool operator ==(Centralita central, Llamada llamada)
        {
            foreach (Llamada item in central.listaDeLlamadas)
            {
                if (item == llamada)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Centralita central, Llamada llamada)
        {
            return !(central == llamada);
        }

        public static Centralita operator +(Centralita central, Llamada llamada)
        {
            if(central != llamada)
            {
                central.AgregarLlamada(llamada);
            }
            else
            {
                throw new CentralitaException("Aviso: la llamada ya estaba registrada", "centralita", "Metodo operador +");
            }

            return central;
        }
    }
}
