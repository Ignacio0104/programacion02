using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EjercicioI02_SimuladorAtenciónClientes
{
    
    public class Caja
    {
        public delegate void DelegadoCreado(Caja caja, string cadena);

        static Random numeroRandom;
        Queue<string> clientesALaEspera;
        string nombreCaja;
        DelegadoCreado delegadoClienteAtendido;
        CancellationTokenSource cts = new CancellationTokenSource();
        static Caja()
        {
            numeroRandom = new Random();
        }

        public Caja(string nombreCaja, DelegadoCreado delegado)
        {
            clientesALaEspera = new Queue<string>();
            this.nombreCaja = nombreCaja;
            delegadoClienteAtendido = delegado;
        }

        public string NombreCaja { get => nombreCaja; }
        public int CantidadDeClientesALaEspera { get => clientesALaEspera.Count; }

        internal void AgregarCliente(string cliente)
        {
            clientesALaEspera.Enqueue(cliente);
        }
        internal Task IniciarAtencion()
        {
            return Task.Run(AtenderClientes);
        }

        private void AtenderClientes()
        {
            do
            {
                if (clientesALaEspera.Any())
                {
                    delegadoClienteAtendido.Invoke(this, clientesALaEspera.Dequeue());
                }
                Thread.Sleep(numeroRandom.Next(1000, 5000));
            } while (true);
        }

    }
}
