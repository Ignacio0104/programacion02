using System;
using System.Text;

namespace ClassLibrary1
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Alumno {nombre}");
            sb.AppendLine($"Edad {edad} ");
            sb.AppendLine($"Genero {genero}");
            sb.AppendLine($"Pais {pais}");
            sb.AppendLine($"Direccion {direccion}");
            if (cursos is not null)
            {
                sb.AppendLine("Curso: ");
                for (int i = 0; i < cursos.Length; i++)
                {
                    if(cursos[i]is not null) 
                    {
                        sb.AppendLine($"{cursos[i]}");
                    }
                }
            }
            else
            {
                sb.AppendLine("No está inscripto en ningún curso");
            }

            return sb.ToString();
 
        }
    }
}
