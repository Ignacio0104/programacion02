using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        private AutoF1()
        {
            enCompetencia = false;
            cantidadCombustible = 0;
            vueltasRestantes = 0;
        }

        public AutoF1(short numero, string escuderia):this()
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero: {numero}");
            sb.AppendLine($"Escuderia: {escuderia}");
            sb.AppendLine($"Combustible: {cantidadCombustible}");
            sb.AppendLine($"En competencia?: {(enCompetencia? "Si":"No")}");
            sb.AppendLine($"Vueltas restantes: {vueltasRestantes}");

            return sb.ToString();
        }

        public short GetCantidadCombustible()
        {
            return cantidadCombustible;
        }

        public void SetCantidadCombustible(short combustible)
        {
            this.cantidadCombustible = combustible;
        }

        public bool GetEnCompetencia()
        {
            return enCompetencia;
        }

        public void SetEnCompetencia(bool competencia)
        {
            this.enCompetencia = competencia;
        }

        public short GetVueltasRestantes()
        {
            return vueltasRestantes;
        }

        public void SetVueltasRestantes(short vueltas)
        {
            this.vueltasRestantes = vueltas;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.numero == a2.numero) && (a1.escuderia == a2.escuderia);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
