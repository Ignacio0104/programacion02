using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseArchivos
{
    public static class Archivo
    {
        static string ruta;
        static Archivo()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//Conseguir la ruta desde cualquier PC
            ruta += @"/Archivos"; //Crea una carpeta
        }
        public static void Escribir()
        {
            //string rutaProyecto = AppDomain.CurrentDomain.BaseDirectory; //Conseguir la ruta desde donde se ejecuta el programa
            //string nombreArchivo = @"/Laboratorio.txt";
            string completa = ruta + @"/Laboratorio" + DateTime.Now.ToString("HH_mm_ss") + ".txt";

            try
            {
                if (!Directory.Exists(ruta))//Esto significa que la carpeta NO EXISTE
                {
                    Directory.CreateDirectory(ruta); //Aca la creamos
                }
                using (StreamWriter sw = new StreamWriter(completa))//Si se le agrega un segundo parametro (true), si el archivo existe se le va a appendar
                {
                    sw.WriteLine("Estoy");
                    sw.WriteLine("codeando");
                }
            }catch(Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }


           /* StreamWriter sw = new StreamWriter(ruta + nombreArchivo); //Intenta crear un archivo. Si no existe lo crea, si está lo pisa

            sw.WriteLine("Estoy");
            sw.WriteLine("En laboratorio");

            sw.Close(); //Importante siempre CERRAR el archivo*/
        
        }

        public static string Leer(string archivo)
        { 
            try
            {
                string datos = string.Empty;
                if (Directory.Exists(ruta))
                {
                    using (StreamReader sr = new StreamReader(ruta + @$"\{archivo}" + ".txt"))
                    {
                        string line;

                        line = sr.ReadToEnd();

                        datos += line;
                       /* while ((line = sr.ReadLine()) != null)
                        {
                            datos += "\n" + line;
                        }*/
                    }
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
