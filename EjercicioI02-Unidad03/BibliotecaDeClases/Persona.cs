using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private double dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, double dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public DateTime GetFechaNacimiento()
        {
            return this.fechaDeNacimiento;
        }

        public void SetFechaNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        public double GetDni()
        {
            return this.dni;
        }

        public void SetDni(double dni)
        {
            this.dni = dni;
        }

        private int CalcularEdad()
        {
            DateTime inicio = this.fechaDeNacimiento;

            DateTime final = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            int contadorAnos = 0;

            for (DateTime i = inicio; i < final; i = i.AddYears(1))
            {
                contadorAnos += 1;
            }

            return contadorAnos;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            string mayor;
            sb.AppendLine($"Nombre: {nombre} DNI: {dni} Fecha de nacimiento {fechaDeNacimiento.ToShortDateString()} Edad {CalcularEdad()}");
            mayor = MayorDeEdad() ? "Es mayor de edad" : "Es menor de edad";
            sb.AppendLine(mayor);
            return sb.ToString();
        }

        public bool MayorDeEdad()
        {
            return CalcularEdad() > 17;
        }

    }
}
