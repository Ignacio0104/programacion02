using System;
using System.Collections.Generic;
using System.Threading;

namespace ClaseDelegados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Receptor carpinchoReceptor = new Receptor("Carpincho receptor");
            Receptor lautiReceptor = new Receptor("Lauti receptor");

            Emisor.Destinatarios.Add(new DelegadoDestinatario(carpinchoReceptor.RecibirNotificacion));
            //Emisor.Destinatarios.Add(CambiarColorConsola);
            Emisor.Destinatarios.Add(()=> Console.BackgroundColor = ConsoleColor.Blue); //Lambda
            Emisor.Destinatarios.Add(lautiReceptor.RecibirNotificacion);
            Emisor.Destinatarios.Add(Notificar);

       

            Emisor.ProducirNotificacion();

        }

        public delegate void DelegadoDestinatario();

        public static bool Filtrar(DelegadoDestinatario delegados)
        {
            return delegados.Method.Name.StartsWith('N') || delegados.Method.Name.StartsWith('S');
        }

        public static class Emisor
        {
            public static List<DelegadoDestinatario> Destinatarios = new List<DelegadoDestinatario>();

            public static void ProducirNotificacion()
            {
                Console.WriteLine("Produciendo notifiacion...");
              
                foreach (DelegadoDestinatario item in Destinatarios)
                {
                    Thread.Sleep(2000);
                    item();
                }
            }

            /*public static void ProducirNotificacion()
            {

            }*/
        }

        public static void Notificar()
        {
            Console.WriteLine("Se envio una notificacion");
        }

        public static void CambiarColorConsola()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }
        public class Receptor
        {
            string nombre;
            public Receptor(string nombre)
            {
                this.nombre = nombre;
            }

            public void RecibirNotificacion()
            {
                Console.WriteLine($"Yo {nombre} Recibi una notificacion a las {DateTime.Now}");
            }
        }
    }
}
