using System;

namespace BibliotecaDeClases
{
    public enum EPosicion
    {
        Arquero,
        Defensor,
        Mediocampista,
        Delantero
    }
    public class Jugador
    {
        private static int ultimoId;
        private int id;
        private string nombre;
        private string apellido;
        private int dni;
        private EPosicion posicion;
        private int numeroCamiseta;

        public string Nombre
        {
            get { return nombre; }
            //set { nombre = value; } 
        }

        static Jugador()
        {
            ultimoId = 1;
        }

        public Jugador(string nombre, string apellido, string dni, EPosicion posicion, string numeroCamiseta)
        {
            this.id = ultimoId;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = int.Parse(dni);
            this.posicion = posicion;
            this.numeroCamiseta = int.Parse(numeroCamiseta);
            ultimoId++;
        }

    }
}
