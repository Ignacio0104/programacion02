using System;

namespace BibliotecaDeClases
{
    public class Sumador
    {
        private int cantidadSumas;


        public Sumador(int numero)
        {
            this.cantidadSumas = numero;
        }

        public Sumador():this(0)
        {

        }

        public long Sumar(long numero, long numeroDos)
        {
            this.cantidadSumas++;
            return numero + numeroDos;

        }

        public string Sumar(string palabra, string palabraDos)
        {
            this.cantidadSumas++;
            return palabra + palabraDos;

        }

        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
        }

        public string Mostrar()
        {
            return $"La cantida de sumas es {cantidadSumas}";
           
        }

        public static bool operator | (Sumador uno, Sumador dos)
        {
            return (int)uno == (int)dos;
        }

        public static long operator +(Sumador uno, Sumador dos)
        {
            return (int)uno + (int)dos;
        }
    }
}
