using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBaseDeDatos
{
    public class Persona
    {
        string nombre;
        int id;

        public Persona(string nombre, int id)
        {
            this.nombre = nombre;
            this.id = id;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return nombre +" " + id.ToString();
        }
    }
}
