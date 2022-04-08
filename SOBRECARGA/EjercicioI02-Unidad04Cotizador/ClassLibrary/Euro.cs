using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            cotzRespectoDolar = 1.09;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public static explicit operator Dolar(Euro euroIngresado)
        {
            return new Dolar(euroIngresado.cantidad / cotzRespectoDolar);
        }

        public static explicit operator Peso(Euro euroIngresado)
        {
            return (Peso)((Dolar)euroIngresado);
        }

        public static implicit operator Euro(double numero)
        {
            return new Euro(numero);
        }

        public static bool operator !=( Euro euroIngresado,Dolar dolarIngresado)
        {
            return euroIngresado != (Euro)dolarIngresado;
        }

        public static bool operator ==(Euro euroIngresado, Dolar dolarIngresado)
        {
            return euroIngresado== (Euro)dolarIngresado;
        }

        public static bool operator != (Euro euroIngresado, Peso pesoIngresado)
        {
            return euroIngresado != (Euro)pesoIngresado;
        }

        public static bool operator ==(Euro euroIngresado, Peso pesoIngresado)
        {
            return euroIngresado == (Euro)pesoIngresado;
        }

        public static bool operator !=(Euro euroIngresado, Euro euroIngresado2)
        {
            return euroIngresado.cantidad != euroIngresado2.cantidad;
        }

        public static bool operator ==(Euro euroIngresado, Euro euroIngresado2)
        {
            return euroIngresado.cantidad == euroIngresado2.cantidad;
        }

        public static Euro operator - (Euro euroIngresado , Dolar dolarIngresado)
        {
            return new Euro(euroIngresado.cantidad - ((Euro)dolarIngresado).cantidad);
        }

        public static Euro operator -(Euro euroIngresado , Peso pesoIngresado)
        {
            return new Euro(euroIngresado.cantidad - ((Euro)pesoIngresado).cantidad);
        }

        public static Euro operator +(Euro euroIngresado, Dolar dolarIngresado)
        {
            return new Euro(euroIngresado.cantidad + ((Euro)dolarIngresado).cantidad);
        }

        public static Euro operator +(Euro euroIngresado , Peso pesoIngresado)
        {
            return new Euro(euroIngresado.cantidad + ((Euro)pesoIngresado).cantidad);
        }

    }
}
