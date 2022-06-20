using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Gripe : Microrganismo
    {

        public Gripe(string nombre, Enumerados.ETipo tipo, Enumerados.EContagiosidad contagiosidad) : base(nombre, tipo, contagiosidad)
        {
        }

        public override long IndiceDeContagios { get => base.contador * 2; }
    }
}
