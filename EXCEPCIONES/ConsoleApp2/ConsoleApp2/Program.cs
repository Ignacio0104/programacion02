using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcular();
        }

        static void Calcular()
        {
            Division(0);
        }
        static void Division(int numero)
        {
            try
            {
                float resultado = 10 / numero;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Termino la operacion");
            }
            
        }
    }
}
