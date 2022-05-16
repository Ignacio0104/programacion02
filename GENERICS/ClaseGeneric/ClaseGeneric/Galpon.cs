using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseGeneric
{
    public class Galpon <T,U,V> 
        where T : class 
        where U : struct //Esto se hace para restringir (struct igual int, bool, etc. Por valor)
        where V : class //los tipos de datos que se pueden recibir

    {
        List<T> listaDeElementos;
        U objetoPrincipal;
        V[] arrayDeAlgo;


        public string Mostrar()
        {
            return objetoPrincipal.ToString();
        }
       /* public Galpon()
        {
            listaDeElementos = new List<T>();
        }

       public int CantidadElementos
        {
            get { return listaDeElementos.Count; }
        }

        public T primerElemento()
        {
            return listaDeElementos[0];
        }

        public bool GuardarObjeto (T objetoAGuardar)
        {
            return true;
        }*/

    }
}
