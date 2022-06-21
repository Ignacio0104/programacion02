using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaDeClases
{
    public delegate void ManejadorCombate(IJugador jugadorUno, IJugador jugadorDos);
    public delegate void ManejadorFinal(IJugador jugadorGanador);
    public sealed class Combate
    {
        private IJugador atacado;
        private IJugador atacante;
        private static Random random;
        public event ManejadorCombate RondaIniciada;
        public event ManejadorFinal CombateFinalizado;

        static Combate()
        {
            random = new Random();
        }

        public Combate()
        {

        }

        public Combate(IJugador jugadorUno,IJugador jugadorDos)
        {
            atacante = SeleccionarJugadorAletoriamente(jugadorUno, jugadorDos);
            atacado = jugadorDos;
            if (atacado == atacante)
                atacado = jugadorUno;
        }

        public void Combatir()
        {
            IniciarRonda();
            IJugador resultadoAux;
            do
            {
                atacante.RecibirAtaque(atacado.Atacar());
                resultadoAux = EvaluarGanador();
            }while (resultadoAux is null);

            if (CombateFinalizado is not null)
            {
                CombateFinalizado(atacante);
                ResultadoCombate result = new ResultadoCombate(atacante.ToString(), atacado.ToString(), DateTime.Now);
                try
                {
                    using (StreamWriter sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}prueba.xml"))
                    {
                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(ResultadoCombate));
                        xmlSerializer.Serialize(sw, result);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Error al guardar el archivo");
                }
            }           
        }

        public IJugador EvaluarGanador()
        {
            if(atacado.PuntosDeVida == 0)
            {
                return atacante;
            }
            else
            {
                IJugador jugadorAux = atacado;
                atacado = atacante;
                atacante = jugadorAux;
                return null;              
            }
        }

        public Task IniciarCombate()
        {
            Task nuevaTarea = new Task(() =>
            {
                Combatir();
            });

            nuevaTarea.Start();
            return nuevaTarea;
        }

        public void IniciarRonda()
        {
            if(RondaIniciada is not null)
            {
                RondaIniciada(atacante, atacado);
            }
        }

        public IJugador SeleccionarJugadorAletoriamente(IJugador jugadorUno, IJugador jugadorDos)
        {
            int moneda = (int)random.TirarUnaMoneda();
            if(moneda == 1)
            {
                return jugadorUno;
            }
            else
            {
                return jugadorDos;
            }
        }

        public IJugador SeleccionarPrimerAtacante(IJugador jugadorUno, IJugador jugadorDos)
        {
            if(jugadorUno.Nivel > jugadorDos.Nivel)
            {
                return jugadorUno;
            }
            else if(jugadorUno.Nivel < jugadorDos.Nivel)
            {
                return jugadorDos;
            }
            else
            {
                return SeleccionarJugadorAletoriamente(jugadorUno, jugadorDos);
            }
        }
    }
}
