using System;
using BibliotecaDeClases;

namespace EjercicioI04_Unidad03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dibujo;

            Boligrafo lapi = new Boligrafo(ConsoleColor.Blue,100);
            Boligrafo lapi2 = new Boligrafo(ConsoleColor.Red,50);

            Console.ForegroundColor = lapi2.GetColor();
            Console.WriteLine(lapi2.GetTinta());

            lapi2.Recargar();
            Console.ForegroundColor = lapi2.GetColor();
            Console.WriteLine(lapi2.GetTinta());
            
            lapi.Pintar(45,out dibujo);
            Console.ForegroundColor = lapi.GetColor();
            Console.WriteLine(dibujo);

            lapi2.Pintar(52, out dibujo);
            Console.ForegroundColor = lapi2.GetColor();
            Console.WriteLine(dibujo);

        }
    }
}
