using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetName()
        {
            return this.titular;
        }

        public decimal GetAmount()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Titular: {titular} Monto: $ {cantidad}");

            return sb.ToString();

        }

        public void Ingresar(decimal monto)
        {
            if (monto > 0)
            {
                this.cantidad += monto;
            }
        }

        public void Retirar(decimal monto)
        {
            this.cantidad -= monto;
        }
    }
}
