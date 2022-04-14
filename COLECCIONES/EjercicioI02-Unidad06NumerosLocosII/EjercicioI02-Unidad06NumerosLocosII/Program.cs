using System;
using System.Collections.Generic;

namespace EjercicioI02_Unidad06NumerosLocosII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Stack<int> pilaPositivo = new Stack<int>();
            Stack<int> pilaNegativo = new Stack<int>();
            Queue<int> colaPositivo = new Queue<int>();
            Queue<int> colaNegativo = new Queue<int>();

            for (int i = 0; i < 20; i++)
            {
                Random rnd = new Random();
                lista.Add(rnd.Next(-100, 100));
            }

            Console.WriteLine("Lista ---------------------------");
            MostrarLista(lista);
            lista.Sort(Criterio);
            Console.WriteLine("Lista ordenada descendente");
            foreach (var item in lista)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }

                pilaNegativo.Push(item);
                colaPositivo.Enqueue(item);
            }
            lista.Sort();
            Console.WriteLine("Lista ordenada ascendente");
            foreach (var item in lista)
            {
                if (item < 0)
                {
                    Console.WriteLine(item);
                }

                pilaPositivo.Push(item);
                colaNegativo.Enqueue(item);
            }

            Console.WriteLine("Pila ---------------------------");
            Console.WriteLine("Pila ordenada descendente");
            foreach (var item in pilaPositivo)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("Pila ordenada ascendente");
            foreach (var item in pilaNegativo)
            {
                if (item < 0)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("Cola ---------------------------");
            Console.WriteLine("Cola ordenada descendente");
            foreach (var item in colaPositivo)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("Cola ordenada ascendente");
            foreach (var item in colaNegativo)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }
            }

        }

       public static int Criterio(int elemento1, int elemento2)
        {
            return elemento2 - elemento1;
        }


        public static void MostrarLista(List<int> coleccion)
        {
            foreach (var item in coleccion)
            {
                Console.WriteLine(item);
            }
        }

        /*public static Stack <int> OrdenarStack(Stack<int> coleccion)
        {
            int[] arrayInt = new int[coleccion.Count];

            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = coleccion.Pop();
            }

            Array.Sort(arrayInt,Criterio);

            for (int i = 0; i < arrayInt.Length; i++)
            {
                coleccion.Push(arrayInt[i]);
            }

            return coleccion;

        }

        public static Stack<int> OrdenarStackDesc(Stack<int> coleccion)
        {
            int[] arrayInt = new int[coleccion.Count];

            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = coleccion.Pop();
            }

            Array.Sort(arrayInt);

            for (int i = 0; i < arrayInt.Length; i++)
            {
                coleccion.Push(arrayInt[i]);
            }

            return coleccion;

        }

        public static Queue<int> OrdenarQueue(Queue<int> coleccion)
        {
            int[] arrayInt = new int[coleccion.Count];

            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = coleccion.Dequeue();
            }

            Array.Sort(arrayInt);

            for (int i = 0; i < arrayInt.Length; i++)
            {
                coleccion.Enqueue(arrayInt[i]);
            }

            return coleccion;

        }

        public static Queue<int> OrdenarQueueDesc(Queue<int> coleccion)
        {
            int[] arrayInt = new int[coleccion.Count];

            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = coleccion.Dequeue();
            }

            Array.Sort(arrayInt,Criterio);

            for (int i = 0; i < arrayInt.Length; i++)
            {
                coleccion.Enqueue(arrayInt[i]);
            }

            return coleccion;

        }
       */


    }
}
