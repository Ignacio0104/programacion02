using System;
using System.Text;

namespace BibliotecaDeClases
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private bool SetTinta(short tinta)
        {
            bool check;
            if (tinta >= 0)
            {
                if(this.tinta + tinta <= cantidadTintaMaxima)
                {
                    this.tinta += tinta;
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            else
            {
                if(this.tinta + tinta >= 0)
                {
                    this.tinta += tinta;
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public void Pintar(short gasto, out string dibujo) 
        {
            int i = 1;
            StringBuilder sb = new StringBuilder();
            while (gasto > 0)
            {
                if (!SetTinta(-1))
                {
                    break;
                }
                else
                {
                    sb.Append("*");
                }

                gasto--;
                i++;
            }

            dibujo = sb.ToString();
            
        }
    }
}
