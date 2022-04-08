using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Conductor
    {
        private string nombreConductor;
        private int[] kilometros = new int [6];
        

        public Conductor(string nombreConductor, int[] kilometros)
        {
            this.nombreConductor = nombreConductor;
            this.kilometros = kilometros;
        }

        public string GetNombre()
        {
            return this.nombreConductor;
        }

        public int[] GetKilometro()
        {
            return this.kilometros;
        }
    }
}
