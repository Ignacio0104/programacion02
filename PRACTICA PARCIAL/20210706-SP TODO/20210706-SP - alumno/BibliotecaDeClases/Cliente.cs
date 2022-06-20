using System;

namespace BibliotecaDeClases
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Numero { get => numero; set => numero = value; }

        public Cliente()
        {

        }

        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
