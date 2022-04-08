using System;

namespace ClassLibrary
{
    public class Fahrenheit
    {
        private double grados;

        public Fahrenheit (double grados)
        {
            this.grados = grados;
        }

        public static implicit operator Fahrenheit(double numero)
        {
            return new Fahrenheit(numero);
        }

        public static implicit operator double(Fahrenheit grados)
        {
            return grados.grados;
        }

        public static explicit operator Celsius(Fahrenheit gradoIngresado)
        {
            return new Celsius(((gradoIngresado.grados - 32)* 5/9));
        }
        public static explicit operator Kelvin(Fahrenheit gradoIngresado)
        {
            return new Kelvin(((gradoIngresado.grados - 32) * 5 / 9) + 273.15);
        }

    }
}
