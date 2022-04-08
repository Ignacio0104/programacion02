using System;

namespace ClassLibrary
{
    public class Kelvin
    {
        private double grados;

        public Kelvin(double grados)
        {
            this.grados = grados;
        }

        public static implicit operator Kelvin(double numero)
        {
            return new Kelvin(numero);
        }
        public static implicit operator double(Kelvin grados)
        {
            return grados.grados;
        }

        public static explicit operator Celsius(Kelvin gradoIngresado)
        {
            return new Celsius(gradoIngresado.grados - 273.15);
        }
        public static explicit operator Fahrenheit(Kelvin gradoIngresado)
        {
            return new Fahrenheit(((gradoIngresado.grados - 273.15) * 9/5) + 32);
        }

    }
}
