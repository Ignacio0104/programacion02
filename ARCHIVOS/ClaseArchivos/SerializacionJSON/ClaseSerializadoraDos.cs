using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializacionJSON
{
    public class ClaseSerializadoraDos <T>
    {
        static string ruta;
        static ClaseSerializadoraDos()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//Conseguir la ruta desde cualquier PC
            ruta += @"/Archivos-Serializacion"; //Crea una carpeta
        }

        public static void Escribir(T datos, string archivo)
        {
            string completa = ruta + @"/SerializadoraJSON" + archivo + ".json";

            try
            {
                if (!Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
                {
                    Directory.CreateDirectory(ruta); //Aca la creamos
                }
                string objetoJson = JsonSerializer.Serialize(datos);

                File.WriteAllText(completa, objetoJson);

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }


        public static  T Leer(string nombre)
        {
            string archivo = string.Empty;
            T datos = default;
            string completa = ruta + @"/SerializadoraArquero.xml";

            try
            {
                if (Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
                {
                    string[] archivos = Directory.GetFiles(ruta); //Trae todas las rutas de los archivos

                    foreach (string item in archivos)
                    {
                        if (item.Contains(nombre))
                        {
                            archivo = item;
                            break;
                        }
                    }
                    if (archivo != null)
                    {
                        string archivoJson = File.ReadAllText(archivo);
                        datos = JsonSerializer.Deserialize<T>(archivoJson);

                    }
                }
                return datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }
    }
}
