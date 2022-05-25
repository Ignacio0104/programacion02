using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class JuegoDao
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static JuegoDao()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static void Eliminar(int codigoJuego)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"DELETE FROM JUEGOS WHERE CODIGO_JUEGO = @codigoJuego";
                comando.Parameters.AddWithValue("@codigoJuego", codigoJuego);
                comando.ExecuteNonQuery();

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

        public static void Modificar(Juego juego)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE JUEGOS SET NOMBRE = @nombre AND PRECIO = @precio AND GENERO=@genero WHERE CODIGO_JUEGO=@codigoJuego";
                comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@precio", juego.Precio);
                comando.Parameters.AddWithValue("@genero", juego.Genero);
                comando.Parameters.AddWithValue("@codigoJuego", juego.CodigoJuego);
                comando.ExecuteNonQuery();

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

        public static void Guardar(Juego juego)
        {
            try
            {
                conexion.Open();
                comando.CommandText = $"INSERT INTO JUEGOS (CODIGO_USUARIO,NOMBRE,PRECIO,GENERO) " +
                    $"VALUES ({juego.CodigoUsuario},'{juego.Nombre}',{juego.Precio}, '{juego.Genero}')";
                comando.ExecuteNonQuery();

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

        public static Juego Leer(int codigoJuego)
        {
            Juego juego = null;
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"SELECT * FROM JUEGOS WHERE CODIGO_JUEGO=@codigoJuego";
                comando.Parameters.AddWithValue("@codigoJuego", codigoJuego);
                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        juego = new Juego(dataReader["NOMBRE"].ToString(),Convert.ToDouble(dataReader["PRECIO"]), 
                            dataReader["GENERO"].ToString(), Convert.ToInt32(dataReader["CODIGO_JUEGO"]), 
                            Convert.ToInt32(dataReader["CODIGO_USUARIO"]));
                    }
                }

                return juego;

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
