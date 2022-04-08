using System;
using BibliotecaDeClases;

namespace EjercicioI03_Unidad03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Matias", "Perez", "10001");
            Estudiante estudiante2 = new Estudiante("Ignacio", "Martin", "10002");
            Estudiante estudiante3 = new Estudiante("Pedro", "Perez", "10003");

            estudiante1.SetNotaPrimerParcial(10);
            estudiante1.SetNotaSegundoParcial(6);

            estudiante2.SetNotaPrimerParcial(8);
            estudiante2.SetNotaSegundoParcial(6);

            estudiante3.SetNotaPrimerParcial(3);
            estudiante3.SetNotaSegundoParcial(3);

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());
        }
    }
}
