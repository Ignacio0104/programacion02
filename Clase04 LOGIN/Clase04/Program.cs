using System;
using Logica;

namespace Clase04

    //User Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(Sistema.CheckLogIn("Pedro", "12346"))
            {
                Console.WriteLine("Usuario logueado");
            }
            else
            {
                Console.WriteLine("Error");
            }
            
  
        }
           
    }
}
