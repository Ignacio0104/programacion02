using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class CentralitaException :Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase { get => nombreClase;}
        public string NombreMetodo { get => nombreMetodo; }

        public CentralitaException(string mensaje,string clase, string metodo):this(mensaje,clase,metodo,null)
        {

        }

        public CentralitaException(string mensaje, string clase, string metodo,Exception inneException) : base(mensaje,inneException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
    }
}
