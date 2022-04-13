using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar (double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static explicit operator Euro(Dolar dolarIngresado)
        {
            return new Euro(dolarIngresado.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Peso(Dolar dolarIngresado)
        {
            return new Peso(dolarIngresado.cantidad / Peso.GetCotizacion());
        }

        public static implicit operator Dolar(double numero)
        {
            return new Dolar(numero);
        }

        public static bool operator != (Dolar dolarIngresado, Euro euroIngresado)
        {
            return dolarIngresado != (Dolar)euroIngresado;
        }

        public static bool operator ==(Dolar dolarIngresado, Euro euroIngresado)
        {
            return dolarIngresado == (Dolar)euroIngresado;
        }

        public static bool operator !=(Dolar dolarIngresado, Peso pesoIngresado)
        {
            return dolarIngresado != (Dolar)pesoIngresado;
        }

        public static bool operator ==(Dolar dolarIngresado, Peso pesoIngresado)
        {
            return dolarIngresado == (Dolar)pesoIngresado;
        }

        public static bool operator !=(Dolar dolarIngresado, Dolar dolarIngresado2)
        {
            return dolarIngresado.cantidad != dolarIngresado2.cantidad;
        }

        public static bool operator ==(Dolar dolarIngresado, Dolar dolarIngresado2)
        {
            return dolarIngresado.cantidad == (Dolar)dolarIngresado2.cantidad;
        }

        public static Dolar operator - (Dolar dolarIngresado, Euro euroIngresado)
        {
            return new Dolar (dolarIngresado.cantidad - ((Dolar)euroIngresado).cantidad);
        }

        public static Dolar operator - (Dolar dolarIngresado, Peso pesoIngresado)
        {
            return new Dolar(dolarIngresado.cantidad - ((Dolar)pesoIngresado).cantidad);
        }

        public static Dolar operator +(Dolar dolarIngresado, Euro euroIngresado)
        {
            return new Dolar(dolarIngresado.cantidad + ((Dolar)euroIngresado).cantidad);
        }

        public static Dolar operator +(Dolar dolarIngresado, Peso pesoIngresado)
        {
            return new Dolar(dolarIngresado.cantidad + ((Dolar)pesoIngresado).cantidad);
        }


    }
}
