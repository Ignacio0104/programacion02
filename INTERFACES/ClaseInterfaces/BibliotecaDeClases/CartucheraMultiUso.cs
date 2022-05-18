using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class CartucheraMultiUso
    {
        public List<IAcciones> listaElementos;

        public CartucheraMultiUso()
        {
            listaElementos = new List<IAcciones>();
        }

        public bool RecorrerElementos()
        {
            foreach (IAcciones item in listaElementos)
            {
                if (item.UnidadesDeEscritura < 1)
                {
                    item.Recargar(20);
                    return false;
                }
                item.Escribir("o");                    
            }
            return true;
        }
    }
}
