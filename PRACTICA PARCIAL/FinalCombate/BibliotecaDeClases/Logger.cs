using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Logger
    {
        private string ruta;

        public Logger(string ruta)
        {
            this.ruta = ruta;
        }

        public void Guardar(string text)
        {
            using (StreamWriter outputfile = File.AppendText(ruta))
            {
                outputfile.WriteLine(text);
            }
        }
    }
}
