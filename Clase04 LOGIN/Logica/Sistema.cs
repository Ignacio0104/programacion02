using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public static class Sistema
    {
        static Usuario[] arrayUsuarios;

        static Sistema()
        {
            arrayUsuarios = new Usuario[8];
            CargarUsuariosHardcodeados();
        }

        private static void CargarUsuariosHardcodeados()
        {
            arrayUsuarios[0] = new Usuario("Pedro", "1234");
            arrayUsuarios[1] = new Usuario("Juan", "abcde");
            arrayUsuarios[2] = new Usuario("Matias", "asd123");
        }

        public static bool CheckLogIn(string nombre, string password)
        {
            bool check = false;

            if(string.IsNullOrEmpty(nombre.Trim()) || string.IsNullOrEmpty(password.Trim()))
            {
                check = false;
            }

            for (int i = 0; i < arrayUsuarios.Length; i++)
            {
                if (arrayUsuarios[i] != null)
                {
                    if (nombre == arrayUsuarios[i].GetNombre())
                    {
                        check = arrayUsuarios[i].CheckPassword(password);
                    }
                }

                    
            }
            return check;

        }

    }
}
