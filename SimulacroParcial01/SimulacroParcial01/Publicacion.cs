using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacroParcial01
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }

        public Publicacion(string nombre, int stock) : this(nombre)
        {
            this.stock = stock;
        }

        public Publicacion (string nombre,int stock, float importe) : this(nombre, stock)
        {
            this.importe = importe;
        }

        protected abstract bool EsColor { get; }
        public virtual bool HayStock { get => (stock>0&&importe>0); }
        public float Importe { get =>this.importe ; }
        public int Stock { get => this.stock; set { if (value > 0) { this.stock = value; } } }

        public override string ToString()
        {
            return this.nombre;
        }

        public string ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0} \n", this.nombre.ToUpper());
            sb.AppendLine($"Stock: {this.Stock}");
            sb.Append($"Es color: {this.EsColor}\n");
            sb.AppendLine($"Valoe: {this.Importe}");

            return sb.ToString();
        }
    }
}
