using System;
using System.Text;

namespace BibliotecaDeClases
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor colorTinta;
        private float tinta;

        public ConsoleColor Color { get => colorTinta; set => colorTinta = value; }

        public float UnidadesDeEscritura { get => tinta; set => tinta=value; }

        public Boligrafo(int unidades,ConsoleColor color)
        {
            this.tinta = unidades;
            this.colorTinta = color;
        }

        public EscrituraWrapper Escribir(string texto)
        {   
            this.UnidadesDeEscritura  -= (0.3f * texto.Length);

            return new EscrituraWrapper(texto, Color);
        }

        public bool Recargar(int unidades)
        {
            this.UnidadesDeEscritura += unidades;
            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Boligrafo {Color},{UnidadesDeEscritura}");

            return sb.ToString();
        }

    }
}
