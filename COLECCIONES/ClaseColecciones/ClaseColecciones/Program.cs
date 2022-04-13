using System;
using System.Collections.Generic;

namespace ClaseColecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();

            nombres.Add("Lautaro");
            nombres.Add("Matias");
            nombres.Add("Lucas");

            //ombres.Remove("Lautaro");
            //nombres.RemoveAt(2);

            nombres.Sort();


            foreach (var item in nombres)
            {
                Console.WriteLine(item);
            }

            Dictionary<string, int> agenda = new Dictionary<string, int>();

            agenda.Add("Lautaro", 1424421);
            agenda.Add("Mauricio", 4141242);
            agenda.Add("Pedro", 5969500);

            foreach(KeyValuePair<string,int> item in agenda)
            {
                Console.WriteLine(item.Key, item.Value);
            }

            Queue<string> autosCola = new Queue<string>();

            autosCola.Enqueue("Fiat");
            autosCola.Enqueue("Peugeot");
            autosCola.Enqueue("Audi");

            Console.WriteLine(autosCola.Peek()); //Primer elemento de la cola
            Console.WriteLine(autosCola.Dequeue()); //Borrar el primer elemento de la lista
            autosCola.Enqueue("Palio");
            Console.WriteLine("Comienzo lista: ");
            foreach (var item in autosCola)
            {
                Console.WriteLine(item);
            }

            Stack<string> comidas = new Stack<string>();

            comidas.Push("Risoto");
            comidas.Push("Hamburguesa");
            comidas.Push("Atun");
            comidas.Push("Milanesa");

            foreach (var item in comidas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(comidas.Peek());
            Console.WriteLine(comidas.Pop());

            Console.WriteLine("Comienzo lista: ");

            foreach (var item in comidas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(comidas.Contains("Atun"));

        }

        public static int Comparacion(int a, int b)
        {
            return a - b;
        }
    }
}
