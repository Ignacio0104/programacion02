using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBaseDeDatos
{
    public static class PersonaAccesoDatos
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static PersonaAccesoDatos()
        {
            connectionString = @"Data Source=.;Initial Catalog=EMPRESA_DB;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM EMPLEADOS";
                using(SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        personas.Add(new Persona(dataReader["NOMBRE"].ToString(), Convert.ToInt32(dataReader["ID_EMPLEADO"])));
                    }
                }

                return personas;

            }catch(Exception)
            {
                throw;
            }
            finally
            {
                connection.Close(); 
            }
        }

        public static Persona Leer(int id)
        {
            Persona persona = null;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM EMPLEADOS WHERE ID_EMPLEADO=@ID";
                command.Parameters.AddWithValue("@ID", id);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        persona = new Persona(dataReader["NOMBRE"].ToString(), Convert.ToInt32(dataReader["ID_EMPLEADO"]));
                    }
                }

                return persona;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Guardar(Persona persona)
        {
            try
            {
                connection.Open();
                command.CommandText = $"INSERT INTO EMPLEADOS (NOMBRE) VALUES ('{persona.Nombre}')";
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Modificar(string nuevoNombre, int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE EMPLEADOS SET NOMBRE  = @nombre WHERE ID_EMPLEADO =@ID";
                command.Parameters.AddWithValue("@nombre", nuevoNombre);
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Eliminar(int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM EMPLEADOS WHERE ID_EMPLEADO = @ID";
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
