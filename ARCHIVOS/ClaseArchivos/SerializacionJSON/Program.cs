using System;
using System.Collections.Generic;

namespace SerializacionJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mascota mascota = new Mascota("Moro", "Boxer", 7, true, true);

            List<Mascota> listaMascotas = new List<Mascota>()
            {
                new Mascota("Moro", "Boxer", 7, true, true),
                new Mascota("Pepe", "Callejero", 10, true, true),
                new Mascota("Juana", "Loba", 9, false, true)
            };

            ClaseSerializadoraDos<Mascota>.Escribir(mascota, "Mascota");
            ClaseSerializadoraDos<List<Mascota>>.Escribir(listaMascotas, "Lista");


           Mascota mascotaAux = ClaseSerializadoraDos<Mascota>.Leer("Mascota");
            List<Mascota> listaAux = ClaseSerializadoraDos<List<Mascota>>.Leer("Lista");

            Console.WriteLine("Mascota unica: " + mascota.ToString());
            Console.WriteLine("Mascotas: ");
            foreach (var item in listaAux)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
