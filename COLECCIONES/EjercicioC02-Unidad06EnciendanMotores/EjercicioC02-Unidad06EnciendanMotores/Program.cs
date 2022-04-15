using System;
using ClassLibrary1;

namespace EjercicioC02_Unidad06EnciendanMotores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Competencia competenciaUno = new Competencia(35, 10);
            AutoF1 autoUno = new AutoF1(10, "Red Bull");
            AutoF1 autoDos = new AutoF1(12, "Ferrar");
            AutoF1 autoTres = new AutoF1(8, "Audi");
            AutoF1 autoCuatro = new AutoF1(4, "ABB");
            AutoF1 autoCinco = new AutoF1(56, "Posche");
            AutoF1 autoSeis = new AutoF1(100, "Red Bull");
            AutoF1 autoSiete = new AutoF1(12, "Red Bull");
            AutoF1 autoOcho = new AutoF1(90, "Ferrari (voy a borrarlo)");
            AutoF1 autoNueve = new AutoF1(87, "Lamborghini");
            AutoF1 autoDiez = new AutoF1(23, "Red Bull");
            AutoF1 autoOnce = new AutoF1(17, "Ferrari");

            Console.WriteLine(competenciaUno + autoUno);
            Console.WriteLine(competenciaUno + autoDos);
            Console.WriteLine(competenciaUno + autoTres);
            Console.WriteLine(competenciaUno + autoCuatro);
            Console.WriteLine(competenciaUno + autoCinco);
            Console.WriteLine(competenciaUno + autoSeis);
            Console.WriteLine(competenciaUno + autoSiete);
            Console.WriteLine(competenciaUno + autoOcho);
            Console.WriteLine(competenciaUno + autoNueve);
            Console.WriteLine(competenciaUno + autoDiez);
            Console.WriteLine(competenciaUno + autoOnce);

            Console.WriteLine(competenciaUno.MostrarDatos());
            Console.WriteLine(autoOnce.MostrarDatos());
            Console.WriteLine(competenciaUno-autoOnce);
            Console.WriteLine(competenciaUno == autoOnce);
            Console.WriteLine(competenciaUno == autoOcho);
            Console.WriteLine(competenciaUno - autoOcho);
            Console.WriteLine(competenciaUno.MostrarDatos());

        }
    }
}
