using System;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public delegate void DelegadoTemporizador();
    public class Temporizador
    {
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;
        private Task hilo;
        private int intervalo;
        public event DelegadoTemporizador TiempoCumplido;
        public event DelegadoTemporizador YaEstaPrendido;
        public event DelegadoTemporizador YaEstaApagado;

        public Temporizador(int intervalo)
        {
            this.intervalo = intervalo;

        }

        public bool EstaActivo
        {
            get
            {
                return hilo is not null &&
                    (hilo.Status == TaskStatus.Running ||
                    hilo.Status == TaskStatus.WaitingToRun ||
                    hilo.Status == TaskStatus.WaitingForActivation);
            }
        }
        public int Intervalo { get => intervalo; set => intervalo = value; }

        public void IniciarTemporizador()
        {

            if (hilo is null || hilo.IsCompleted)
            {
                cancellationTokenSource = new CancellationTokenSource();
                cancellationToken = cancellationTokenSource.Token;
                hilo = new Task(CorrerTiempo, cancellationToken);
            }
            if (!EstaActivo)
            {
                hilo.Start();
            }
            else
            {
                YaEstaPrendido();
            }
        }

        public void DetenerTemporizador()
        {
            if (hilo is not null && !hilo.IsCompleted)
            {
                cancellationTokenSource.Cancel();
            }
            else
            {
                YaEstaApagado();
            }
        }

        private void CorrerTiempo()
        {
            do
            {
                if (TiempoCumplido is not null)
                {
                    TiempoCumplido.Invoke();
                }
                Thread.Sleep(intervalo);
            } while (!cancellationToken.IsCancellationRequested);
        }

    }
}
