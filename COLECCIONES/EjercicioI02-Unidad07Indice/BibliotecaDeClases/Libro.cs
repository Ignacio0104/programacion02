using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this[int index]
        {
            get
            {
                if(index >=0 && index<this.paginas.Count)
                {
                    return paginas[index];
                }
                else
                {
                    return "Pagina no valida";
                }
                
            }

            set
            {
                if (index > this.paginas.Count)
                {
                    this.paginas.Add(value);
                }
                else if (index >=0)
                {
                    paginas.Insert(index,value);
                }
            }
        }
    }
}
