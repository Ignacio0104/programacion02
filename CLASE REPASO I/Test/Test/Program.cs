using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataProcessor<string> p = new DataProcessor<string>();
            p.Process(1000);
        }

        class Processor<T>
        {
            public void Process(T value)
            {
                Console.WriteLine(value.GetType().Name);
            }
        }

        class DataProcessor <U> : Processor<int>
        {

        }
    }
}
