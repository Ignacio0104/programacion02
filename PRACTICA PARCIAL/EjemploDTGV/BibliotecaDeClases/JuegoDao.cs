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
                conexion.Open();
                comando.Parameters.Clear();
                comando.CommandText = $"DELETE FROM JUEGOS WHERE CODIGO_JUEGO = @codigo";
                comando.Parameters.AddWithValue("@codigo", codigoJuego);
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
                comando.Parameters.Clear();
                comando.CommandText = $"INSERT INTO JUEGOS (CODIGO_USUARIO,NOMBRE,PRECIO,GENERO) VALUES" +
                    $"(@codigoUsuario,@nombre,@precio,@genero)";
                comando.Parameters.AddWithValue("@codigoUsuario", juego.CodigoUsuario);
                comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@precio", juego.Precio);
                comando.Parameters.AddWithValue("@genero", juego.Genero);
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

        public static List<Biblioteca> Leer()
        {
            List<Biblioteca> biblioteca = new List<Biblioteca>();
            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT JUEGOS.NOMBRE as juego,JUEGOS.GENERO as genero, JUEGOS.CODIGO_JUEGO as codigoJuego, " +
                    $"USUARIOS.USERNAME as usuario FROM JUEGOS JOIN USUARIOS ON JUEGOS.CODIGO_USUARIO = USUARIOS.CODIGO_USUARIO ";
                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        biblioteca.Add(new Biblioteca(Convert.ToInt32(dataReader["codigoJuego"]), dataReader["genero"].ToString(),
                            dataReader["juego"].ToString(), dataReader["usuario"].ToString()));
                    }
                }

                return biblioteca;

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

        public static Juego LeerPorId(int codigoJuego)
        {
            Juego juegoAux = null;
            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT CODIGO_JUEGO as codigoJuego,CODIGO_USUARIO as codigoUsuario" +
                    $",NOMBRE as nombre,PRECIO as precio,GENERO as genero FROM JUEGOS WHERE CODIGO_JUEGO = @codigo";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codigo", codigoJuego);
                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        juegoAux = new Juego(dataReader["nombre"].ToString(), Convert.ToDouble(dataReader["precio"]),
                            dataReader["genero"].ToString(), Convert.ToInt32(dataReader["codigoJuego"]), 
                            Convert.ToInt32(dataReader["codigoUsuario"]));
                    }
                }

                return juegoAux;

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
                comando.CommandText = $"UPDATE JUEGOS SET NOMBRE = @nombre, PRECIO = @precio, GENERO = @genero WHERE CODIGO_JUEGO=@codigoJuego";//El where no está en el ejemplo
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
    }
}
