using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {
        protected float costo;
        public Local(float duracion, string nroDestino, string nroOrigen, float costo) : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }

        public Local (Llamada llamada,float costo):this(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen, costo)
        {

        }

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            return this.costo * this.Duracion;
        }
        public override string ToString()
        {
            return Mostrar();
        }

        public override bool Equals(object llamada) => llamada is Local;

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo por minuto: {costo}");
            sb.AppendLine($"Costo total: {CostoLlamada}");

            return sb.ToString();
        }
    }
}
