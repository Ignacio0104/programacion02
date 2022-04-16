using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int cantidadGoles;

        private Jugador()
        {
            partidosJugados = 0;
            cantidadGoles = 0;
        }

        public Jugador (int dni, string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador (int dni,string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.cantidadGoles = totalGoles;
            this.partidosJugados = totalPartidos;
            
        }

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }

        public float PromedioGoles
        {
            get
            {
                return (float)this.cantidadGoles / this.partidosJugados;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.cantidadGoles;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }

            set
            {
                this.dni = value;
            }
        }


        public static bool operator ==(Jugador j1, Jugador j2)
        {
            //Falta validar NULL
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre:{nombre}");
            sb.AppendLine($"DNI:{dni}");
            sb.AppendLine($"Cantidad Goles:{cantidadGoles}");
            sb.AppendLine($"Partidos Jugados:{partidosJugados}");
            sb.AppendLine($"Promedio de goles:{PromedioGoles}");

            return sb.ToString();
        }

    }
}
