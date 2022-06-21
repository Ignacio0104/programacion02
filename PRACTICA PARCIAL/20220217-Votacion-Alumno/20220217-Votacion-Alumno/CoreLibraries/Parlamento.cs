using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoreLibraries
{
    public enum EVoto { Indefinido,Abstencion,Positivo,Negativo}
    public delegate void FinalizarRegistro();
    public class Parlamento <T>  where T: IParlamentario
    {
        public delegate void InformarCambioEstado(T banca);

        public event FinalizarRegistro FinVotacion;
        public event FinalizarRegistro ParlamentariosRegistrados;
        public event InformarCambioEstado OcupaBanca;
        public event InformarCambioEstado VotoEmitido;
        public CancellationTokenSource cts;

        private List<T> bancas;
        private bool estadoSesion;
        private T presidente;
        public Parlamento(T presidente)
        {
            this.presidente = presidente;
            this.bancas = new List<T>();
            cts = new CancellationTokenSource();
        }



        public List<T> Bancas { get => bancas; set => bancas = value; }
        public bool EstadoSesion 
        {
            set 
            {
                estadoSesion = value;
                Task.Run(() =>
                {
                    foreach (T t in Bancas)
                    {
                        t.AperturaSesion = estadoSesion;
                        OcupaBanca?.Invoke(t);
                        Thread.Sleep(50);
                    }
                    ParlamentariosRegistrados?.Invoke(); //Ese signo de pregunta es lo mismo que poner if not null
                });
            } 
        }
        public T Presidente { get => presidente; }
        public int VotoAbstenciones { get => ContarVotos(EVoto.Abstencion); }
        public int VotosNegativos { get => ContarVotos(EVoto.Negativo); }
        public int VotosAfirmativos { get => ContarVotos(EVoto.Positivo); }

        public void CancelarVotacion()
        {

        }
        public int ContarVotos(EVoto voto)
        {
            int cantidadVotos = 0;
            foreach (T item in bancas)
            {
                if(item.Voto == voto)
                {
                    cantidadVotos++;
                }
            }
            return cantidadVotos;
        }

        public void DesempatePresidente()
        {
            if (VotosAfirmativos==VotosNegativos)
            {
                presidente.EmitirVoto();
            }
            else
            {
                throw new NoNecesitaDesempateException("La votación no necesita desempate");
            }
        }

        public void IniciarVotacion()
        {
            Task.Run(() =>
            {
                foreach (T item in bancas)
                {
                    if (!cts.IsCancellationRequested)
                    {
                        if (item.Presentismo)
                        {
                            item.EmitirVoto();
                            VotoEmitido?.Invoke(item);
                            Thread.Sleep(new Random().Next(400, 1001));
                        }
                    }
                }
                try
                {
                    DesempatePresidente();
                }
                catch 
                {
                  
                }
                FinVotacion.Invoke();
                JsonManager<Parlamento<T>>.Guardar(this);
            },cts.Token);
        }


    }
}
