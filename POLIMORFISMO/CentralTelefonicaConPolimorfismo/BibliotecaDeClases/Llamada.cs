using System;
using System.Text;

namespace BibliotecaDeClases
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public enum TipoLlamada
        {
            Local, Provincial,Todas
        }
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion { get => duracion; }
        public string NroDestino { get => nroDestino;  }
        public string NroOrigen { get => nroOrigen; }
        public abstract float CostoLlamada { get; }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Origen: {nroOrigen}");
            sb.AppendLine($"Destino: {nroDestino}");
            sb.AppendLine($"Duracion: {duracion}");

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            float diferencia = llamada1.Duracion - llamada2.Duracion;

            return (int)diferencia;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return (l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroDestino);
        }
    }
}
