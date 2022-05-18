using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializacionHerenciaXml
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
            string completa = ruta + @"/Serializadora" + archivo + ".xml";

            try
            {
                if (!Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
                {
                    Directory.CreateDirectory(ruta); //Aca la creamos
                }
                
                using (StreamWriter sw = new StreamWriter(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(sw, datos);
                }


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
                        using (StreamReader sr = new StreamReader(completa))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            datos = (T)xmlSerializer.Deserialize(sr);
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
    }
}
