using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class NumeroDecimal
    {
        private double numero;

        public NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public static implicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        public static explicit operator double(NumeroDecimal numero)
        {
            return numero.numero;
        }

        public static double operator +(NumeroDecimal d,NumeroBinario b)
        {
            double result = Conversor.ConvertirBinarioADecimal((string)b) + d.numero;
            return result;
        }

        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            double result = Conversor.ConvertirBinarioADecimal((string)b) - d.numero;
            return result;
        }

        public static bool operator ==(NumeroDecimal d, NumeroBinario b)
        { 
            return Conversor.ConvertirBinarioADecimal((string)b) == d.numero;
        }

        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            return !(b == d);
        }
    }
}
