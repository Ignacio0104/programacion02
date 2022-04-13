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
        private float promedioGoles;
        private int cantidadGoles;

        private Jugador()
        {
            partidosJugados = 0;
            promedioGoles = 0;
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

        public float GetPromedio()
        {
            this.promedioGoles = (float)this.cantidadGoles / this.partidosJugados;
            return this.promedioGoles;
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
            sb.AppendLine($"Promedio de goles:{GetPromedio()}");

            return sb.ToString();
        }

    }
}
