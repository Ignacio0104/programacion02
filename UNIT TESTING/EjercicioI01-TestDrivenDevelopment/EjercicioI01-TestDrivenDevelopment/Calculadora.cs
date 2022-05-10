using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EjercicioI01_TestDrivenDevelopment
{
    public static class Calculadora
    {
        public static int Add(string numeros)
        {
            char nuevoDelimitador = ',';
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == '/')
                {
                    nuevoDelimitador = numeros[i + 2];
                    break;
                }
            }
            char[] delimitadores = { ',', '\n', nuevoDelimitador};
            string[] numerosArray = numeros.Split(delimitadores);
            int numeroAux = 0;
            int acumulador = 0;
            
            if(numerosArray.Length>0 && numerosArray is not null)
            {
                try
                {
                    for (int i = 0; i < numerosArray.Length; i++)
                    {
                        int.TryParse(numerosArray[i], out numeroAux);
                        if (numeroAux < 0)
                        {
                            throw new NegativoNoPermitidoException("No se permiten valores negativos");
                        }
                        acumulador += numeroAux;
                    }

                    return acumulador;
                }
                catch(NegativoNoPermitidoException e)
                {
                    Console.WriteLine(e.Message);
                }
     
            }
            return 0;
        }
    }
}
