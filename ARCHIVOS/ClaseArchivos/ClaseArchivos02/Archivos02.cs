using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseArchivos02
{
    public static class Archivos02
    {
        static string ruta;
        static Archivos02()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//Conseguir la ruta desde cualquier PC
            ruta += @"/Archivos"; //Crea una carpeta
        }
        public static void Escribir()
        {
            //string rutaProyecto = AppDomain.CurrentDomain.BaseDirectory; //Conseguir la ruta desde donde se ejecuta el programa
            //string nombreArchivo = @"/Laboratorio.txt";
            string completa = ruta + @"/Laboratorio" + ".txt";

            try
            {
                if (!Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
                {
                    Directory.CreateDirectory(ruta); //Aca la creamos
                }
                string datos = DateTime.Now.ToString();
                //File.WriteAllText(completa, datos);
                File.AppendAllText(completa, datos);

            
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }

        }

        public static string Leer(string archivo)
        {
            try
            {
                string datos = string.Empty;
                if (Directory.Exists(ruta))
                {
                    string completa = ruta + @$"/{archivo}" + ".txt";
                    datos = File.ReadAllText(completa);
                }
                return datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {ruta}");
            }

        }
    }
}


