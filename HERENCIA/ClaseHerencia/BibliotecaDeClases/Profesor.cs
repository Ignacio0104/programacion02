using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Profesor : Persona
    {
        private string catedra;
        public Profesor(string nombre, string apellido, long dni,string catedra) : base(nombre, apellido, dni)
        {
            this.Catedra = catedra;
        }

        public string Catedra { get => catedra; set => catedra = value; }
    }
}
