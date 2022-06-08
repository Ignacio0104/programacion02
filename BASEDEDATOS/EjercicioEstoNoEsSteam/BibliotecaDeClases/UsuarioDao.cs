using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class UsuarioDao
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;
        
        static UsuarioDao()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.CommandType = System.Data.CommandType.Text; //Siempre recibe strings
            comando.Connection = conexion;
        }

        public static List<Usuario> Leer()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                conexion.Open();
                comando.CommandText = "SELECT CODIGO_USUARIO,USERNAME FROM USUARIOS";
                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        usuarios.Add(new Usuario(dataReader["USERNAME"].ToString(), Convert.ToInt32(dataReader["CODIGO_USUARIO"])));
                    }
                }

                return usuarios;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
