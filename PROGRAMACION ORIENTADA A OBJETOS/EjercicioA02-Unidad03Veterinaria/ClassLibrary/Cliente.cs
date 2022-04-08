using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class Cliente
    {
        private string domicilio;
        private string nombre;
        private string apellido;
        private int telefono;
        private Mascota[] mascotas = new Mascota[10];

        public Cliente(string nombre, string apellido, string domicilio, int telefono)
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }

        public string GetDomicilio()
        {
            return domicilio;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public string GetApellido()
        {
            return apellido;
        }
        public int GetTelefono()
        {
            return telefono;
        }

        public void SetMascotas(Mascota mascotaIngresada)
        {
            for (int i = 0; i < mascotas.Length; i++)
            {
                if (mascotas[i] == null)
                {
                    mascotas[i] = mascotaIngresada;
                    break;
                }
            }
        }

        public string GetMascotas()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < mascotas.Length; i++)
            {
                if (mascotas[i] != null)
                {
                    sb.AppendLine(mascotas[i].Mostrar());
                }

            }

            return sb.ToString();
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cliente: {nombre} {apellido}");
            sb.AppendLine($"Telefono: {telefono} Domicilio: {domicilio}");
            sb.AppendLine($"Mascotas: {GetMascotas()} ");

            return sb.ToString();
        }
    }
}
