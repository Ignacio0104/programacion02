using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class ClaseSerializadora<T>
    {
        static string ruta;
        static ClaseSerializadora()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            ruta = path;
        }

        public static void EscribirXml(T datos)
        {
            string completa = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Bombero.xml");

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
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

        public static T LeerXml()
        {
            T datos = default;
            string completa = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Bombero.xml");

            try
            {
                if (Directory.Exists(ruta))
                {
                    if (completa != null)
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
