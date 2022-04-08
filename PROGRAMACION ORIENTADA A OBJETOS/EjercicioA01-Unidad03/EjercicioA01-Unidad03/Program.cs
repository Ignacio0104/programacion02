using System;
using BibliotecaDeClases;

namespace EjercicioA01_Unidad03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Conductor[] listaConductores = new Conductor[3];
            int[] arrayKms1 =  { 1, 56, 120, 0, 70, 540, 10 ,20};
            int[] arrayKms2 = { 1, 126, 120, 0, 1700, 20, 178,56 };
            int[] arrayKms3 =  { 23, 5, 600, 0, 120, 45, 10,76 };

            listaConductores[0] = new Conductor("Pedro", arrayKms1);
            listaConductores[1] = new Conductor("Juan", arrayKms2);
            listaConductores[2] = new Conductor("Pedro", arrayKms3);

            Console.WriteLine(Logica.MasKilometrosSemana(listaConductores));
            Console.WriteLine(Logica.MasKilometrosDia(listaConductores,3));
            Console.WriteLine(Logica.MasKilometrosDia(listaConductores,5));
        }
    }
}
