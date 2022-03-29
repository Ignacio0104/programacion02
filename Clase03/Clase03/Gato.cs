using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Gato
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private double peso;

        public Gato(string nombre,DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public void AsignarPeso(double peso)
        {
            this.peso = peso;
        }

        public string obtenerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos del gato: ");
            sb.AppendFormat("Nombre: {0}", nombre);
            sb.Append("Fecha de nacimiento: ");
            sb.Append(fechaNacimiento.ToString("dd/MM/yyyy"));
            sb.AppendLine($"Peso: {peso}");

            return sb.ToString();
  
        }



    }
}
