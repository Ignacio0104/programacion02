using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibraries
{
    public static class MetodoSQL
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;
        static string logErrores;

        static MetodoSQL()
        {
            connectionString = @"Data Source=.;Initial Catalog=votacion-finales-202112;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static void GuardarResultado(Parlamento<Senador> parlamento)
        {
            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = $"INSERT INTO RESULTADOS (fecha,positivos,negativos,abstenciones,alumno) " +
                    $"VALUES(@fecha,@positivos,@negativos,@abstenciones,@alumno)";
                command.Parameters.AddWithValue("@fecha", DateTime.Now.ToShortDateString());
                command.Parameters.AddWithValue("@positivos",parlamento.VotosAfirmativos);
                command.Parameters.AddWithValue("@negativos", parlamento.VotosNegativos);
                command.Parameters.AddWithValue("@abstenciones", parlamento.VotoAbstenciones);
                command.Parameters.AddWithValue("@alumno", "Ignacio Smirlian");
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
