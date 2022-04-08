using System;

namespace ClassLibrary
{
    public class Celsius
    {
        private double grados;

        public Celsius(double grados)
        {
            this.grados = grados;
        }

        public static implicit operator Celsius(double numero)
        {
            return new Celsius(numero);
        }

        public static implicit operator double(Celsius grados)
        {
            return grados.grados;
        }
        public static explicit operator Kelvin(Celsius gradoIngresado)
        {
            return new Kelvin(gradoIngresado.grados + 273.15);
        }
        public static explicit operator Fahrenheit(Celsius gradoIngresado)
        {
            return new Fahrenheit((gradoIngresado.grados*9/5)+32);
        }

        public static Celsius ConvertirFaC(Fahrenheit gradoF)
        {
            return (Celsius)gradoF;
;        }

    }
}
