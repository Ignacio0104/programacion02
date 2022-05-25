using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Usuario
    {
        private int codigoUsuario;
        private string username;

        public int CodigoUsuario { get => codigoUsuario; }

        public Usuario(string username,int codigoUsuario)
        {
            this.username = username;
            this.codigoUsuario = codigoUsuario;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Username : {username}");

            return sb.ToString();

        }
    }
}
