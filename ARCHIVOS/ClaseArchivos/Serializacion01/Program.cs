using System;
using System.Collections.Generic;

namespace Serializacion01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personaje pj = new Personaje("Lautaro", 50);
            Personaje pj1 = new Personaje("Lucas", 100);
            Personaje pj2 = new Personaje("Pedro", 23);
            Personaje pj3 = new Personaje("Juan", 90);

            List<Personaje> personajes = new List<Personaje>();

            personajes.Add(pj);
            personajes.Add(pj1);
            personajes.Add(pj2);
            personajes.Add(pj3);
            ClaseSerializadora.EscribirLista(personajes);

            Console.WriteLine(ClaseSerializadora.Leer());

            personajes = ClaseSerializadora.LeerLista();

            foreach (var item in personajes)
            {
                Console.WriteLine(item);
            }



        }
    }
}
