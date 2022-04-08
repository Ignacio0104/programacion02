using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private string[] historialDeVacunacion = new string[15];

        public Mascota(string especie, string nombre, DateTime fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public string GetEspecie()
        {
            return especie;
        }

        public string GetNombre()
        {
            return nombre;
        }
        public DateTime GetFechaNacimiento()
        {
            return fechaNacimiento;
        }

        public void SetVacuna(string vacuna)
        {
            for (int i = 0; i < historialDeVacunacion.Length; i++)
            {
                if (historialDeVacunacion[i] == null)
                {
                    historialDeVacunacion[i] = vacuna;
                    break;
                }
            }
        }

        public string GetVacunas()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Vacunas: ");
            for (int i = 0; i < historialDeVacunacion.Length; i++)
            {
                if (historialDeVacunacion[i] != null)
                {
                    sb.AppendLine(historialDeVacunacion[i]);
                }
                
            }

            return sb.ToString();
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            sb.AppendLine($"Nombre: {nombre} Especie: {especie}");
            sb.AppendLine($"Fecha de nacimiento: {fechaNacimiento.ToShortDateString()}");
            sb.AppendLine(GetVacunas());

            return sb.ToString();
        }

    }
}
