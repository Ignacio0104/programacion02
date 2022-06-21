using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Hechicero : Personaje
    {
        public Hechicero()
        {
            this.puntosDePoder += (int)((this.puntosDePoder * 10) / 100);
        }

        public Hechicero(decimal id, string nombre) : base(id, nombre)
        {
            this.puntosDePoder += (int)((this.puntosDePoder * 10) / 100);
        }

        public Hechicero(decimal id, string nombre, short nivel) : base(id, nombre, nivel)
        {
            this.puntosDePoder += (int)((this.puntosDePoder * 10) / 100);
        }

        public Hechicero(decimal id, string nombre, short nivel, string titulo) : base(id, nombre, nivel, titulo)
        {
            this.puntosDePoder += (int)((this.puntosDePoder * 10) / 100);
        }

        protected override void AplicarBeneficiosDeClase()
        {
            this.puntosDePoder += (int)((this.puntosDePoder * 10) / 100);
        }
    }
}
