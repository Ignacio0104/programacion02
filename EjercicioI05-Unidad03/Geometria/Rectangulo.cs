using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        private float perimetro;
        private float area;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());

           
            this.area = Math.Abs(vertice2.GetX() - vertice1.GetX()) * Math.Abs(vertice2.GetY() - vertice3.GetY());
        }

        public float GetPerimetro()
        {
            if (this.perimetro != 0)
            {
                this.perimetro = (Math.Abs(vertice2.GetX() - vertice1.GetX()) + Math.Abs(vertice2.GetY() - vertice3.GetY())) / 2;
            }
            
            return this.perimetro;
        }

        public float GetArea()
        {
            if (this.area != 0)
            {
                this.area = Math.Abs(vertice2.GetX() - vertice1.GetX()) * Math.Abs(vertice2.GetY() - vertice3.GetY());
            }

            return this.area;
        }



    }
}
