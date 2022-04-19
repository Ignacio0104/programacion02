using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        public float CostoLlamada
        {
            get
            {
               return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    return base.Duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    return base.Duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    return base.Duracion * 0.66f;
                    break;
            }

            return 0;
        }
    }
}
