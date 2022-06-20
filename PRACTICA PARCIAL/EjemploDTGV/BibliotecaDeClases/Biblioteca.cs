using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Biblioteca
    {
        private int codigoJuego;
        private string genero;
        private string juego;
        private string usuario;

        public Biblioteca(int codigoJuego, string genero, string juego, string usuario)
        {
            this.codigoJuego = codigoJuego;
            this.genero = genero;
            this.juego = juego;
            this.usuario = usuario;
        }

        public int CodigoJuego { get => codigoJuego; set => codigoJuego = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Juego { get => juego; set => juego = value; }
        public string Usuario { get => usuario; set => usuario = value; }
    }
}
