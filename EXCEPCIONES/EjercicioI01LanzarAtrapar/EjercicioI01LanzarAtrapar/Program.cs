using System;

namespace EjercicioI01LanzarAtrapar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtraClase pruebaClase = new OtraClase();

            try
            {
                pruebaClase.InstanciarMiClase();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, ex.InnerException);
            }
           
        }
    }
}
