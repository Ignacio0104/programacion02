using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante (int cantidad)
        {
            this.productos = new Producto[cantidad];
        }

        public Estante(int cantidad, int ubicacion): this(cantidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante (Estante e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"El estant esta en la ubicacion {e.ubicacionEstante}");
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] is not null)
                {
                    sb.AppendLine($"{Producto.MostrarProducto(e.productos[i])}");
                }
            }

            return sb.ToString();

        }

        public static bool operator ==(Estante e, Producto p)
        {
            bool check = false;
            Producto[] lista = e.GetProductos();

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] is not null)
                {
                    if(lista[i] == p)
                    {
                        check = true;
                        return check;
                    }
                }
            }

            return check;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool check = false;
            Producto[] lista = e.productos;
            if (e != p)
            {
                for (int i = 0; i < lista.Length; i++)
                {
                    if (lista[i] is null)
                    {
                        if (i <= lista.Length - 1)
                        {
                            lista[i] = p;
                            check = true;
                            return check;
                        }
                    }
                }
            }

            return check;
        }

        public static Estante operator - (Estante e, Producto p)
        {
            Producto[] lista = e.productos;
            if (e == p)
            {
                for (int i = 0; i < lista.Length; i++)
                {
                    if (lista[i] is not null)
                    {
                        if (lista[i] == p)
                        {
                            lista[i] = null;
                            return e;
                        }
                    }
                }
            }

            return e;
        }
    }
}
