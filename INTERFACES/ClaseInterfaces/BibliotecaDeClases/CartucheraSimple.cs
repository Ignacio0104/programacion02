using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class CartucheraSimple
    {
        public List<Boligrafo> listaDeBoligrafos;
        public List<Lapiz> listaDeLapices;

        public CartucheraSimple()
        {
            listaDeBoligrafos = new List<Boligrafo>();
            listaDeLapices = new List<Lapiz>();
        }

        public bool RecorrerElementos()
        {
            foreach (Boligrafo item in listaDeBoligrafos)
            {
                if (item.UnidadesDeEscritura < 1)
                {
                    item.Recargar(20);
                    return false;
                }
                item.Escribir("o");
            }

          foreach (Lapiz item in listaDeLapices)
            {
                if (((IAcciones)item).UnidadesDeEscritura > 1)
                {
                    ((IAcciones)item).Escribir("o");
                }
                else
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
