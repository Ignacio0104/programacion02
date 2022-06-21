using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class PersonajeDAO
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static PersonajeDAO()
        {
            connectionString = @"Data Source=.;Initial Catalog=COMBATE_DB;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }
        public static Personaje ObtenerPersonajePorId(decimal id)
        {
            Personaje personajeAux = null;

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM PERSONAJES WHERE id=@idIngresada";
                command.Parameters.AddWithValue("@idIngresada", id);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    
                    while (dataReader.Read())
                    {
                        if (Convert.ToInt32(dataReader["clase"]) == 1)
                        {
                            personajeAux = new Guerrero(Convert.ToDecimal(dataReader["id"]), dataReader["nombre"].ToString(),
                                Convert.ToInt16(dataReader["nivel"]), dataReader["titulo"].ToString());
                        }
                        else
                        {
                            personajeAux = new Hechicero(Convert.ToDecimal(dataReader["id"]), dataReader["nombre"].ToString(),
                              Convert.ToInt16(dataReader["nivel"]), dataReader["titulo"].ToString());
                        }                   
                    }
                }

                return personajeAux;

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
