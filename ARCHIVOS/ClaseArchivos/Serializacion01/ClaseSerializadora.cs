using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializacion01
{
    public class ClaseSerializadora
    {
        static string ruta;
        static ClaseSerializadora()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//Conseguir la ruta desde cualquier PC
            ruta += @"/Archivos-Serializacion"; //Crea una carpeta
        }

        public static void Escribir(Personaje pj)
        {
            string completa = ruta + @"/Serializador_" + DateTime.Now.ToString("HH_mm_ss") + ".xml";

            try
            {
                if (!Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
                {
                    Directory.CreateDirectory(ruta); //Aca la creamos
                }
                
                using (StreamWriter sw = new StreamWriter(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Personaje));
                    xmlSerializer.Serialize(sw, pj);
                }


            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static void EscribirLista(List<Personaje> lista)
        {
            string completa = ruta + @"/Serializador_" + DateTime.Now.ToString("HH_mm_ss") + ".xml";

            try
            {
                if (!Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
                {
                    Directory.CreateDirectory(ruta); //Aca la creamos
                }

                using (StreamWriter sw = new StreamWriter(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Personaje>));
                    xmlSerializer.Serialize(sw, lista);
                }


            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        public static Personaje Leer()
        {
            string completa = ruta + @"/Serializador.xml";
            Personaje pj = null;

            try
            {
                if (!Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
                {
                    Directory.CreateDirectory(ruta); //Aca la creamos
                }

                using (StreamReader sr = new StreamReader(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Personaje));
                    pj = (Personaje)xmlSerializer.Deserialize(sr);
                }
                return pj;

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }
        public static List<Personaje> LeerLista()
        {
            string completa = ruta + @"/SerializadorLista.xml";
            List<Personaje> lista = null;

            try
            {
                if (!Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
                {
                    Directory.CreateDirectory(ruta); //Aca la creamos
                }

                using (StreamReader sr = new StreamReader(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Personaje>));
                    lista = (List<Personaje>)xmlSerializer.Deserialize(sr);
                }
                return lista;

            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }
    }
}
