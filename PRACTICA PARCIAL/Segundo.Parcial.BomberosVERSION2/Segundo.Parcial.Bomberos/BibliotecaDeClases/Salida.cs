using System;

namespace BibliotecaDeClases
{
    public class Salida
    {
        private DateTime fechaFin;
        private DateTime fechaInicio;

        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public double TiempoTotal { get => fechaInicio.DiferenciaTiempo(fechaFin); }
        public Salida()
        {
            fechaInicio = DateTime.Now;
        }

        public void FinalizarLlamada()
        {
            fechaFin = DateTime.Now;
        }
    }
}
