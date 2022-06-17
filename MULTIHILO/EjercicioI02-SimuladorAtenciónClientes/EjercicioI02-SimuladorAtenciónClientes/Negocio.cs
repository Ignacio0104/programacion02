using NHibernate.Hql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameGenerator.Generators;
using System.Collections.Concurrent;
using System.Threading;

namespace EjercicioI02_SimuladorAtenciónClientes
{
    public class Negocio
    {
        static RealNameGenerator nombreAutoGenerado;
        ConcurrentQueue<string> clientes;
        List<Caja> cajas;

        static Negocio()
        {
            nombreAutoGenerado = new RealNameGenerator();
        }

        public Negocio(List<Caja> listaDeCajas)
        {
            clientes = new ConcurrentQueue<string>();
            cajas = listaDeCajas;
        }

        public List<Task> ComenzarAtencion()
        {
            List<Task> hilos = new List<Task>();
            hilos.AddRange(AbrirCajas());

            hilos.Add(Task.Run(GenerarClientes));
            hilos.Add(Task.Run(AsignarCajas));

            return hilos;
        }

        private List<Task> AbrirCajas()
        {
            List<Task> hilos = new List<Task>();

            foreach (Caja caja in cajas)
            {
                hilos.Add(caja.IniciarAtencion());
            }

            return hilos;
        }

        private void GenerarClientes()
        {
            do
            {
                clientes.Enqueue(nombreAutoGenerado.Generate());
                Thread.Sleep(1000);
            } while (true);
        }
        private void AsignarCajas()
        {
            do
            {
                Caja caja = cajas.OrderBy(c => c.CantidadDeClientesALaEspera).First();
                clientes.TryDequeue(out string cliente);
                if (!string.IsNullOrWhiteSpace(cliente))
                {
                    caja.AgregarCliente(cliente);
                }
            } while (true);
        }
    }
}
