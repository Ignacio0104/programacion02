using System;
using System.Text;

namespace BibliotecaDeClases
{
    public abstract class Microrganismo
    {
        protected long contador;
        private Enumerados.EContagiosidad contagiosidad;
        private string nombre;
        private Enumerados.ETipo tipo;

        public abstract long IndiceDeContagios { get; }

        public Microrganismo(string nombre)
        {
            this.nombre = nombre;
            contador = 200;
        }

        public Microrganismo(string nombre,Enumerados.ETipo tipo, Enumerados.EContagiosidad contagiosidad) : this(nombre)
        {
            this.tipo = tipo;
            this.contagiosidad = contagiosidad;
        }

        public string Informe()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"El {tipo} lleva el nombre de {nombre} y tiene una contagiosidad de {contagiosidad}");
            sb.AppendLine($"Su impacto de contagios se calcula en {IndiceDeContagios}");

            return sb.ToString();
        } 

    }
}
