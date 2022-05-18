using System;
using BibliotecaDeClases;


namespace ClaseInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);
            Lapiz miLapizDos = new Lapiz(15);
            Boligrafo miBoligrafoDos = new Boligrafo(16, ConsoleColor.Red);
            Lapiz miLapizTres = new Lapiz(9);
            Boligrafo miBoligrafoTres = new Boligrafo(9, ConsoleColor.Yellow);
            Lapiz miLapizCuatro = new Lapiz(20);
            Boligrafo miBoligrafoCuatro = new Boligrafo(12, ConsoleColor.White);
            Lapiz miLapizCinco = new Lapiz(30);
            Boligrafo miBoligrafoCinco = new Boligrafo(20, ConsoleColor.Blue);
            Lapiz miLapizSeis = new Lapiz(20);
            Boligrafo miBoligrafoSeis = new Boligrafo(30, ConsoleColor.Cyan);
            Lapiz miLapizSiete = new Lapiz(19);
            Boligrafo miBoligrafoSiete = new Boligrafo(18, ConsoleColor.DarkMagenta);

            EscrituraWrapper eLapiz = ((IAcciones)miLapiz).Escribir("Hola");
            Console.ForegroundColor = eLapiz.color;
            Console.WriteLine(eLapiz.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.color;
            Console.WriteLine(eBoligrafo.texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo);

            CartucheraSimple cartuSimple = new CartucheraSimple();
            CartucheraMultiUso cartuMulti = new CartucheraMultiUso();

            cartuMulti.listaElementos.Add(miLapiz);
            cartuMulti.listaElementos.Add(miLapizDos);
            cartuMulti.listaElementos.Add(miLapizTres);
            cartuMulti.listaElementos.Add(miLapizCuatro);
            cartuMulti.listaElementos.Add(miLapizCinco);
            cartuMulti.listaElementos.Add(miLapizSeis);
            cartuMulti.listaElementos.Add(miLapizSiete);
            cartuMulti.listaElementos.Add(miBoligrafo);
            cartuMulti.listaElementos.Add(miBoligrafoDos);
            cartuMulti.listaElementos.Add(miBoligrafoTres);
            cartuMulti.listaElementos.Add(miBoligrafoCuatro);
            cartuMulti.listaElementos.Add(miBoligrafoCinco);
            cartuMulti.listaElementos.Add(miBoligrafoSeis);
            cartuMulti.listaElementos.Add(miBoligrafoSiete);

            cartuSimple.listaDeLapices.Add(miLapiz);
            cartuSimple.listaDeLapices.Add(miLapizDos);
            cartuSimple.listaDeLapices.Add(miLapizTres);
            cartuSimple.listaDeLapices.Add(miLapizCuatro);
            cartuSimple.listaDeLapices.Add(miLapizCinco);
            cartuSimple.listaDeLapices.Add(miLapizSeis);
            cartuSimple.listaDeLapices.Add(miLapizSiete);

            cartuSimple.listaDeBoligrafos.Add(miBoligrafo);
            cartuSimple.listaDeBoligrafos.Add(miBoligrafoDos);
            cartuSimple.listaDeBoligrafos.Add(miBoligrafoTres);
            cartuSimple.listaDeBoligrafos.Add(miBoligrafoCuatro);
            cartuSimple.listaDeBoligrafos.Add(miBoligrafoCinco);
            cartuSimple.listaDeBoligrafos.Add(miBoligrafoSeis);
            cartuSimple.listaDeBoligrafos.Add(miBoligrafoSiete);

            while (cartuSimple.RecorrerElementos())
            {
                cartuSimple.RecorrerElementos();
            }

            Console.ReadKey();
        }
    }
}
