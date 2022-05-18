using System;
using System.Collections.Generic;

namespace SerializacionHerenciaXml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arquero arquero = new Arquero("Legolas",20,true);
            Espadachin espadachin = new Espadachin("Aragorn", 100, false);

            ClaseSerializadoraDos<Arquero>.Escribir(arquero,"Arquero");
            ClaseSerializadoraDos<Espadachin>.Escribir(espadachin,"Espadachin");

            List<Personaje> listaPersonajes = new List<Personaje>();

            listaPersonajes.Add(arquero);
            listaPersonajes.Add(espadachin);
            ClaseSerializadoraDos<List<Personaje>>.Escribir(listaPersonajes, "Lista");
            Console.WriteLine(ClaseSerializadoraDos<Arquero>.Leer("rquero"));

            Arquero auxArquero = ClaseSerializadoraDos<Arquero>.Leer("Arquero");
            Espadachin auxEspadachin = ClaseSerializadoraDos<Espadachin>.Leer("Espadachin");
            List<Personaje> lista = ClaseSerializadoraDos<List<Personaje>>.Leer("Lista");

            Console.WriteLine("Arquero" + auxArquero);
            Console.WriteLine("Espadachin" + auxEspadachin);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
