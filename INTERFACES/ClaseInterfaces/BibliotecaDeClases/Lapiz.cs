using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        float IAcciones.UnidadesDeEscritura { get => tamanioMina; set => tamanioMina = value; }

        ConsoleColor IAcciones.Color { get=> ConsoleColor.Gray; set=> throw new NotImplementedException(); }
        public Lapiz(int unidades)
        {
            //this.tamanioMina = unidades;
            ((IAcciones)this).UnidadesDeEscritura = unidades;
        }
        EscrituraWrapper IAcciones.Escribir (string texto)
        {
            ((IAcciones)this).UnidadesDeEscritura -= (0.1f * texto.Length);

            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Lapiz {((IAcciones)this).Color},{((IAcciones)this).UnidadesDeEscritura}");

            return sb.ToString();
        }

        bool IAcciones.Recargar(int unidades)
        {
            throw new NotImplementedException();
        }
    }
}
