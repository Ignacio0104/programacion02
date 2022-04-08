using System;
using ClassLibrary;
namespace EjercicioA02_Unidad03Veterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cliente[] clientes = new Cliente[3];
            
            Cliente cliente1 = new Cliente("Pedro", "Perez", "Argentina", 524252424);
            Mascota mascota1 = new Mascota("Perro", "Roger", new DateTime(2010, 10, 10));
            cliente1.SetMascotas(mascota1);
            clientes[0] = cliente1;

            Cliente cliente2 = new Cliente("Sandro", "Gonzales", "Brazil", 1244144);
            Mascota mascota2 = new Mascota("Gato", "Mishi", new DateTime(2015, 12, 10));
            cliente2.SetMascotas(mascota2);
            mascota2.SetVacuna("Triple Felina");
            clientes[1] = cliente2;

            Cliente cliente3 = new Cliente("Sara", "Sanchze", "Peru", 14256624);
            Mascota mascota3 = new Mascota("Gato", "Garfield", new DateTime(2018, 8, 15));
            Mascota mascota4 = new Mascota("Perro", "Mili", new DateTime(2004, 4, 4));
            cliente3.SetMascotas(mascota3);
            cliente3.SetMascotas(mascota4);
            mascota4.SetVacuna("Antirabica");
            clientes[2] = cliente3;

            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine(clientes[i].Mostrar());
            }

        }
    }
}
