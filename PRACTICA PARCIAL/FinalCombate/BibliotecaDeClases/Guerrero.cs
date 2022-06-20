using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Guerrero : Personaje
    {
        public Guerrero()
        {
        }

        public Guerrero(decimal id, string nombre) : base(id, nombre)
        {
        }

        public Guerrero(decimal id, string nombre, short nivel) : base(id, nombre, nivel)
        {
        }
        public Guerrero(decimal id, string nombre, short nivel,string titulo) : base(id, nombre, nivel, titulo)
        {
        }

        protected override void AplicarBeneficiosDeClase()
        {
            this.puntosDeDefensa += (int)((this.puntosDeDefensa * 10) / 100);
        }
    }
}
