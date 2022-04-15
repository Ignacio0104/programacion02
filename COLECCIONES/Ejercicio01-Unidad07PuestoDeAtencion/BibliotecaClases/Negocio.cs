using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }

            set
            {
                _ = this + value;
            }
           
        }

        public int ClientesPendientes => this.clientes.Count();

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);

        }

        public Negocio (string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            if (n is not null && c is not null)
            {
                foreach (var item in n.clientes)
                {
                    if (item == c)
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            if (n.clientes.Count > 0)
            {
                return (n.caja.Atender(n.Cliente));
            }
            else
            {
                Console.WriteLine("No hay mas clientes esperando");
                return false;
            }

            
        }
    }
}
