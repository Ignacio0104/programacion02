using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial01
{
    public class Comic : Publicacion
    {
        private bool esColor;
        public Comic(string nombre, bool esColor, int stock, float importe) : base(nombre, stock, importe)
        {
            this.esColor = esColor;
        }
    }
}
