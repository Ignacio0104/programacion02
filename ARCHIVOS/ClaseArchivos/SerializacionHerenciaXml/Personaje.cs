using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializacionHerenciaXml
{
    [XmlInclude(typeof(Arquero))]//Se indica que quiero serializar dentro de la relacion de herencia
    [XmlInclude(typeof(Espadachin))]
    public class Personaje
    {
        private string nombre;
        private int nivel;

        public Personaje() //Si o si, porque lo necesitamos para serializar
        {

        }

        public Personaje(string nombre, int nivel)
        {
            this.nombre = nombre;
            this.nivel = nivel;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Nivel { get => nivel; set => nivel = value; }

        public override string ToString()
        {
            return $"Nombre {nombre} - Nivel {nivel}";
        }
    }
}
