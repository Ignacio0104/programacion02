using System;

namespace ClassLibrary
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Peso()
        {
            cotzRespectoDolar = 0.0089;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion): this(cantidad)
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

        public static void SetCotizacion(string cotizacion)
        {
            double cotizacionVerificada = 0;

            double.TryParse(cotizacion, out cotizacionVerificada);
            cotzRespectoDolar = cotizacionVerificada;
        }

        public static explicit operator Dolar(Peso pesoIngresado)
        {
            return new Dolar(pesoIngresado.cantidad / Peso.GetCotizacion());
        }

        public static explicit operator Euro(Peso pesoIngresado)
        {
            return (Euro)((Dolar)pesoIngresado);
               
        }

        public static implicit operator Peso(double numero)
        {
            return new Peso(numero);
        }

        public static bool operator != (Peso pesoIngresado , Dolar dolarIngresado)
        {
            return pesoIngresado != (Peso)dolarIngresado;
        }

        public static bool operator ==(Peso pesoIngresado, Dolar dolarIngresado)
        {
            return pesoIngresado == (Peso)dolarIngresado;
        }

        public static bool operator != (Peso pesoIngresado, Euro euroIngresado)
        {
            return pesoIngresado != (Peso)euroIngresado;
        }

        public static bool operator ==(Peso pesoIngresado, Euro euroIngresado)
        {
            return pesoIngresado == (Peso)euroIngresado;
        }

        public static bool operator !=(Peso pesoIngresado, Peso pesoIngresado2)
        {
            return pesoIngresado.cantidad != pesoIngresado2.cantidad;
        }

        public static bool operator ==(Peso pesoIngresado, Peso pesoIngresado2)
        {
            return pesoIngresado.cantidad == pesoIngresado2.cantidad;
        }

        public static Peso operator -(Peso pesoIngresado, Dolar dolarIngresado)
        {
            return new Peso(pesoIngresado.cantidad - ((Peso)dolarIngresado).cantidad);
        }

        public static Peso operator -(Peso pesoIngresado, Euro euroIngresado)
        {
            return new Peso(pesoIngresado.cantidad - ((Peso)euroIngresado).cantidad);
        }

        public static Peso operator +(Peso pesoIngresado, Dolar dolarIngresado)
        {
            return new Peso(pesoIngresado.cantidad + ((Peso)dolarIngresado).cantidad);
        }

        public static Peso operator +(Peso pesoIngresado, Euro euroIngresado)
        {
            return new Peso(pesoIngresado.cantidad + ((Peso)euroIngresado).cantidad);
        }


    }
}
