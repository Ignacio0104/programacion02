using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodosSql
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static MetodosSql()
        {
            connectionString = @"Data Source=.;Initial Catalog=bomberos-db;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static void GuardarLog(string mensaje)
        {
            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = "INSERT INTO dbo.log(entrada, alumno) VALUES(@mensaje, 'Mauricio Cerizza')";
                command.Parameters.AddWithValue("@mensaje", mensaje);
                command.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                
            }
            finally
            {
                if(connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }

        public static string LeerLog()
        {
            try
            {
                connection.Open();
                command.CommandText = "SELECT entrada FROM dbo.log;";
                StringBuilder sb = new StringBuilder();
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        sb.AppendLine(dataReader.GetString(0));
                    }
                }
                return sb.ToString();
            } finally
            {
                if(connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }
    }
}
