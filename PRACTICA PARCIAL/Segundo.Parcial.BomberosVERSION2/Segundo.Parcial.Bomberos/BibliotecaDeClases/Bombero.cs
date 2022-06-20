using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaDeClases
{
    public delegate void FinDeSalida(int bomberoIndex);
    public class Bombero : IArchivo<string>,IArchivo<Bombero>
    {
        private string nombre;
        private List<Salida> salidas;
        public event FinDeSalida MarcarFin;
        private Random rnd;

        public Bombero(string nombre)
        {
            this.nombre = nombre;
            salidas = new List<Salida>();
            rnd = new Random();
        }

        public void Guardar(Bombero info)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string completa = path + @"\" + "Bombero" + ".xml";
            try
            {
                if (!Directory.Exists(completa))
                {
                    Directory.CreateDirectory(completa);
                }

                using (StreamWriter sw = new StreamWriter(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));
                    xmlSerializer.Serialize(sw, info);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public Bombero Leer()
        {
            Bombero datos = default;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string completa = path + @"\" + "Bombero" + ".xml";
            try
            {
                if (Directory.Exists(completa))
                {
                    if (completa != null)
                    {
                        using (StreamReader sr = new StreamReader(completa))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));
                            datos = (Bombero)xmlSerializer.Deserialize(sr);
                        }
                    }
                }
                return datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

         void IArchivo<string>.Guardar(string info)
        {
            string connectionString = @"Data Source=.;Initial Catalog=bomberos-db;Integrated Security=True";
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                command.Parameters.Clear();
                command.CommandText = "INSERT INTO dbo.log(entrada, alumno) VALUES(@mensaje, 'Mauricio Cerizza')";
                command.Parameters.AddWithValue("@mensaje", info);
                command.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {

            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }

        string IArchivo<string>.Leer()
        {
            string connectionString = @"Data Source=.;Initial Catalog=bomberos-db;Integrated Security=True";
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
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
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public void AtenderLlamada(int bomberoIndex)
        {
            Salida salidaNueva = new Salida();
            salidas.Add(salidaNueva);
            Thread.Sleep(rnd.Next(2000, 4000));
            /*Task esperarLlamada = Task.Run(() =>
            {
                Thread.Sleep(rnd.Next(2, 4));
                salidaNueva.FinalizarLlamada();
            });*/

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Horario de inicio {salidaNueva.FechaInicio} - Horario de fin {salidaNueva.FechaFin} " +
                $"- Duracion total {salidaNueva.TiempoTotal}");

            ((IArchivo<string>)this).Guardar(sb.ToString());

            if(MarcarFin is not null)
            {
                MarcarFin.Invoke(bomberoIndex);
            }
        }
    }
}
