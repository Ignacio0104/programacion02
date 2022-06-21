using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public delegate void ManejadorAtaques(Personaje personaje, int numero);
    public abstract class Personaje :IJugador
    {
        private decimal id;
        private short nivel;
        private string nombre;
        protected int puntosDeDefensa;
        protected int puntosDePoder;
        private int puntosDeVida;
        private static Random random;
        private string titulo;
        private const int nivelMaximo = 100;
        private const int nivelMinimo = 1;
        public event ManejadorAtaques AtaqueLanzado;
        public event ManejadorAtaques AtaqueRecibido;

        public string Titulo { get => titulo;}
        public int PuntosDeVida { get => puntosDeVida;}
        public short Nivel { get => nivel; }
        public int PuntosDeDefensa { get => puntosDeDefensa; }

        static Personaje()
        {
            random = new Random();
        }
        public Personaje()
        {
            this.nivel = 1;
            this.puntosDeDefensa = 100 * nivel;
            this.puntosDePoder = 100 * nivel;
            this.puntosDeVida = 500 * nivel;
        }

        public Personaje(decimal id,string nombre):this()
        {
            this.id = id;
            if(nombre is not null)
            {
                this.nombre = nombre.Trim();
            }
            else
            {
                throw new ArgumentNullException();
            }
            
        }

        public Personaje(decimal id, string nombre,short nivel) : this(id,nombre)
        {
            if(nivel<=nivelMaximo && nivel >= nivelMinimo)
            {
                this.nivel = nivel;
            }
            else
            {
                throw new BusinessException("Nivel de poder inválido");
            }
            this.puntosDeDefensa = 100 * nivel;
            this.puntosDePoder = 100 * nivel;
            this.puntosDeVida = 500 * nivel;
        }

        public Personaje(decimal id, string nombre, short nivel,string titulo) : this(id, nombre, nivel)
        {
            this.titulo = titulo;
        }

        protected abstract void AplicarBeneficiosDeClase();

        public static bool operator ==(Personaje personajeUno, Personaje personajeDos)
        {
            return personajeUno.id == personajeDos.id;
        }

        public static bool operator !=(Personaje personajeUno, Personaje personajeDos)
        {
            return !(personajeUno == personajeDos);
        }


        public int Atacar()
        {
            int porcentajeAtaque = (int)random.Next(10, 100);
            int ataqueFinal = ((puntosDePoder * porcentajeAtaque) / 100);
            Thread.Sleep(random.Next(1000, 5000));
            if(AtaqueLanzado is not null)
            {
                AtaqueLanzado(this, ataqueFinal);
            }

            return ataqueFinal;
        }

        public void RecibirAtaque(int numero)
        {
            int porcentajeDefensa = (int)random.Next(10, 100);
            int ataqueDefendido = numero - ((numero * porcentajeDefensa) / 100);
            if(this.puntosDeVida - ataqueDefendido >= 0)
            {
                this.puntosDeVida -= ataqueDefendido;
            }
            else
            {
                this.puntosDeVida = 0;
            }

            if(AtaqueRecibido is not null)
            {
                AtaqueRecibido(this, ataqueDefendido);
            }
        }

        public override string ToString()
        {
            if(titulo is not null)
            {
                return $" {nombre},{titulo}";
            }
            else
            {
                return $" {nombre}";
            }
        }


    }
}
