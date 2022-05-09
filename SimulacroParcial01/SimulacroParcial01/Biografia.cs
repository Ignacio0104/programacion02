using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial01
{
    public class Biografia : Publicacion
    {
        public Biografia(string nombre) : base(nombre)
        {
        }

        public Biografia(string nombre, int stock) : base(nombre, stock)
        {
        }

        public Biografia(string nombre, int stock, float importe) : base(nombre, stock, importe)
        {
        }

        protected override bool EsColor { get => false; }
        public override bool HayStock { get => this.stock > 0; }

        public static explicit operator Biografia(string nombre)
        {
            return new Biografia(nombre);
        }
    }
}
