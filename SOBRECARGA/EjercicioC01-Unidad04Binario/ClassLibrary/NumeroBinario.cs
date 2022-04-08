using System;

namespace ClassLibrary
{
    public class NumeroBinario
    {
        private string numero;

        public NumeroBinario(string numero)
        {
            this.numero = numero;
        }
        public static implicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        public static explicit operator string(NumeroBinario numero)
        {
            return numero.numero;
        }

        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            double result = Conversor.ConvertirBinarioADecimal(b.numero) + (double)d;
            string final = Conversor.ConvertirDecimalABinario(result);
            return final;
        }

        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            double result = Conversor.ConvertirBinarioADecimal(b.numero) - (double)d;
            string final = Conversor.ConvertirDecimalABinario(result);
            return final;
        }

        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            return Conversor.ConvertirBinarioADecimal(b.numero) == (double)d; ;
        }

        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return !(b==d) ;
        }
    }
}
