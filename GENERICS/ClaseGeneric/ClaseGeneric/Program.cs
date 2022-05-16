using System;
using System.Collections.Generic;

namespace ClaseGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Galpon<Avion, Juguetes, string> inventario = new Galpon<Avion, Juguetes, string>();

            /*Galpon<Avion> hangar = new Galpon<Avion>();
            Galpon<Autos> taller = new Galpon<Autos>();
            Galpon<Juguetes> deposito = new Galpon<Juguetes>();

            hangar.primerElemento(); //Devuelve un avion
            taller.primerElemento(); //Devuelve un auto
            deposito.primerElemento();//Devuelve un juguete

            //hangar.GuardarObjeto() Pide un avion*/
        }
    }
}
