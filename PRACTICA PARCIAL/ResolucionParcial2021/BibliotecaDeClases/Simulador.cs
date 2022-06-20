using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public delegate void DelegadoMostrarInfo();
    public class Simulador
    {
        Task hilo;
        public event DelegadoMostrarInfo MostrarInformacion;
        Comercio comercio;
        public CancellationTokenSource cts;
        CancellationToken token;
        public int atendidos;
        Random rnd;

        public Simulador(Comercio comercio)
        {
            this.comercio = comercio;
            cts = new CancellationTokenSource();
            token = cts.Token;
            rnd = new Random();
            hilo = new Task(() =>
            {
                int contador = 0;
                
                while (!token.IsCancellationRequested)
                {
                    if(MostrarInformacion is not null)
                    {
                        MostrarInformacion();
                        Thread.Sleep(3000);
                        contador++;
                        if (rnd.Next(2) == 0)
                        {
                            atendidos++;
                        }
                    }
                }

            },token);
        }

        public void ComenzarSimulacion()
        {
            hilo.Start();
        }
    }
}
