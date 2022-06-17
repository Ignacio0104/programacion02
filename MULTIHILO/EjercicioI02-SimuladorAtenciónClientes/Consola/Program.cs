using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EjercicioI02_SimuladorAtenciónClientes;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caja.DelegadoCreado delegado = new Caja.DelegadoCreado((caja, texto) =>
            {
                Console.WriteLine($"Hora: {DateTime.Now:HH:MM:ss} - Hilo {Task.CurrentId} - Caja: {caja.NombreCaja} - " +
                    $"Atendiendo a {texto}. Quedan {caja.CantidadDeClientesALaEspera} clientes en esta caja");
            });

            Caja cajaUno = new Caja("Caja principal", delegado);
            Caja cajaDos = new Caja("Caja secundaria", delegado);

            List<Caja> listaDeCajas = new List<Caja>();
            listaDeCajas.Add(cajaUno);
            listaDeCajas.Add(cajaDos);

            Negocio negocioCreado = new Negocio(listaDeCajas);
            Console.WriteLine("Asignando cajas");

            List<Task> hilos = negocioCreado.ComenzarAtencion();

            Task.WaitAll(hilos.ToArray());
        }

        
    }
}
