using System;
using System.Text;

namespace BibliotecaDeClases
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random rand;

        static Estudiante()
        {
            rand = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private double CalcularPromedio()
        {
            double resultado = ((double)notaPrimerParcial + notaSegundoParcial) / 2;
            return resultado;
        }

        public double CalcularNotaFinal()
        {
            double resultado = -1;
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                resultado = rand.Next(6,11);
            }

            return resultado;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Alumno: {nombre} {apellido} Legajo {legajo}");
            sb.AppendLine($"Primer Parcial: {notaPrimerParcial} Segundo Parcial {notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");
            if (CalcularNotaFinal() > 1)
            {
                sb.AppendLine($"Nota Final: {CalcularNotaFinal()}");
            }
            else
            {
                sb.AppendLine($"Nota Final: Desaprobado");
            }

            return sb.ToString();
        }
    }
}
