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

        public static void Guardar(Juego juego)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"INSERT INTO JUEGOS (CODIGO_USUARIO,NOMBRE,PRECIO,GENERO) " +
                    $"VALUES (@codigo,@nombre,@precio, @genero)";
                comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@codigo", juego.CodigoUsuario);
                comando.Parameters.AddWithValue("@precio", juego.Precio);
                comando.Parameters.AddWithValue("@genero", juego.Genero);
                comando.ExecuteNonQuery();//No queremos que nos devuelva el registro

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
                        biblioteca.Add(new Biblioteca(dataReader["usuario"].ToString(), dataReader["genero"].ToString(), dataReader["juego"].ToString(), Convert.ToInt32(dataReader["codigoJuego"])));
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


        /* public static List<Juego> Leer()
         {
             List<Juego> juegos = new List<Juego>();
             try
             {
                 conexion.Open();
                 comando.CommandText = $"SELECT * FROM JUEGOS";
                 using (SqlDataReader dataReader = comando.ExecuteReader())
                 {
                     while (dataReader.Read())
                     {
                         juegos.Add(new Juego(dataReader["NOMBRE"].ToString(), Convert.ToDouble(dataReader["PRECIO"]), dataReader["GENERO"].ToString(),Convert.ToInt32(dataReader["CODIGO_JUEGO"]), Convert.ToInt32(dataReader["CODIGO_USUARIO"])));
                     }
                 }

                 return juegos;

             }
             catch (Exception)
             {
                 throw;
             }
             finally
             {
                 conexion.Close();
             }
         }*/





    }

}
