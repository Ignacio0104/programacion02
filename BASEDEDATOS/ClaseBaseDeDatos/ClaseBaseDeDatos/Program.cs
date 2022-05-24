using System;
using System.Collections.Generic;

namespace ClaseBaseDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Persona> listaPersonas = PersonaAccesoDatos.Leer();

                foreach (Persona item in listaPersonas)
                {
                    Console.WriteLine(item.ToString());
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Persona persona = PersonaAccesoDatos.Leer(6);

                Console.WriteLine(persona.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                PersonaAccesoDatos.Guardar(new Persona("Nacho", 24));
                PersonaAccesoDatos.Eliminar(2);
                PersonaAccesoDatos.Modificar("Ignacio", 8);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }
}
