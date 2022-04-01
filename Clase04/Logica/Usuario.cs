using System;

namespace Logica
{
    public class Usuario
    {

        private string nombre;
        private string password;

        public Usuario(string nombre, string password)
        {
            this.nombre = nombre;
            this.password = password;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public bool CheckPassword(string pw)
        {
            return pw == this.password;
        }
    }
}
