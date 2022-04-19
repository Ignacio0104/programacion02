using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaDeClases
{
    public class Espectador
    {
        private string dni;
        private string nombre;
        private string numeroTelefonico;
        int cantidadEntradas;

        public Espectador()
        {
            this.cantidadEntradas = 1;
        }

        public Espectador(string dni, string nombre, string numeroTelefonico)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.numeroTelefonico = numeroTelefonico;
        }

        public Espectador(string dni, string nombre, string numeroTelefonico, int cantidadEntradas) : this(dni, nombre, numeroTelefonico)
        {
            this.cantidadEntradas = cantidadEntradas;
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{nombre}"+ "\n");
            sb.AppendLine($"{dni}" + "\n");
            sb.AppendLine($"{numeroTelefonico}" + "\n");
            sb.AppendLine($"Entradas: {cantidadEntradas}" + "\n");

            return sb.ToString();

        }
    }
}
