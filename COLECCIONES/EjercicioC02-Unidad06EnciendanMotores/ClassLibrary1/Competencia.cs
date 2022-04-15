using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short vueltas, short competidores): this()
        {
            this.cantidadVueltas = vueltas;
            this.cantidadCompetidores = competidores;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Competidores: {cantidadCompetidores}. Cantidad de vueltas: {cantidadVueltas}");
            sb.AppendLine($"Competidores: ");
            foreach (var item in competidores)
            {
                sb.AppendLine($"- {item.MostrarDatos()}");
            }

            return sb.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random rnd = new Random();
            if(c.cantidadCompetidores > c.competidores.Count())
            {
                foreach (var item in c.competidores)
                {
                    if(a == item)
                    {
                        return false;
                    }
                }
                a.SetEnCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVueltas);
                a.SetCantidadCombustible((short)rnd.Next(15, 100));
                c.competidores.Add(a);

                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            if (c == a)
            {
                c.competidores.Remove(a);
                return true;
            }

            return false;
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
          
            foreach (var item in c.competidores)
            {
                if (a == item)
                {
                    return true;
                }
            }

            return false ;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {

            foreach (var item in c.competidores)
            {
                if (a == item)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
