using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void FinDeSalida(int bomberoIndex);
    public class Bombero : IArchivo<Bombero>, IArchivo<string>
    {
        private string nombre;
        private List<Salida> salidas;
        public event FinDeSalida MarcarFin;
        private static Random random;

        public Bombero()
        {
            salidas = new List<Salida>();
        }

        public Bombero(string nombre):this()
        {
            this.nombre = nombre;
            random = new Random();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Salida> Salidas { get => salidas; set => salidas = value; }

        void IArchivo<string>.Guardar(string info)
        {
            MetodosSql.GuardarLog(info);
        }

        public void Guardar(Bombero info)
        {
            ClaseSerializadora<Bombero>.EscribirXml(info);
        }

        string IArchivo<string>.Leer()
        {
            return MetodosSql.LeerLog();
        }

        public Bombero Leer()
        {
            return ClaseSerializadora<Bombero>.LeerXml();
        }

        public void AtenderSalida(int bomberoIndex)
        {
            Salida salida = new Salida();
            salidas.Add(salida);

            Thread.Sleep(random.Next(2000, 4000));

            salida.FinalizarSalida();

            string log = $"Salida finalizada. Inicio: {salida.FechaInicio.ToLongTimeString()}. " +
                            $"Fin: {salida.FechaFin.ToLongTimeString()}. Duración: {salida.TiempoTotal} segundos.";
            ((IArchivo<string>)this).Guardar(log);

            MarcarFin(bomberoIndex);
        }
    }
}
