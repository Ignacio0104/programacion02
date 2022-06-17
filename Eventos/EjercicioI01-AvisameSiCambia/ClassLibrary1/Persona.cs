using System;

namespace ClassLibrary1
{
    public delegate void DelegadoString(string texto);
    public class Persona
    {
        private string apellido;
        private string nombre;
        public event DelegadoString EventoString;

        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public string Mostrar()
        {
            if(EventoString is not null)
            {
                EventoString("Datos actualizados");
            }
            return nombre + " " + apellido;
        }
    }
}
