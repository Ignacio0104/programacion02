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

        public Usuario(int codigoUsuario, string username)
        {
            this.codigoUsuario = codigoUsuario;
            this.username = username;
        }

        public override string ToString()
        {
            return username;
        }
    }
}
