using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaUniversidad;
using System.Collections.Generic;

namespace PruebasDos
{
    [TestClass]
    public class Test_Universidad
    {
        List<Alumno> listaAlum;

        [TestInitialize]
        public void TestInitialize()
        {
            listaAlum = Universidad.Alumnos;
        }
        [TestMethod]
        public void Test_Login_Correcto()
        {
            int id = 123123;
            string pass = "lucas123";

            bool resultado = Universidad.Loguear(id, pass);

            Assert.IsTrue(resultado);
        }

        [DataRow(10,"asd1")] //me permite llamar muchas veces al metodo, pasandole paramentros
        [DataRow(1,"pepe")]
        [DataRow(33,"juan")]
        [DataRow(13,"op")]
        [ExpectedException(typeof(System.UnauthorizedAccessException))] //Se indica que se espera una exepcion
        [TestMethod]
        public void Test_Login_Error(int idPrueba, string passPrueba)
        {
            bool resultado = Universidad.Loguear(idPrueba, passPrueba);
        }

        [TestMethod]
        public void Test_Lista_AlumnosLlena_Success()
        {
            List<Alumno> listaAlum = Universidad.Alumnos;
            Assert.IsNotNull(listaAlum);
            Assert.IsTrue(listaAlum.Count > 0);
            System.Console.WriteLine("Cantidad alumnos " + listaAlum.Count);
        }

        [ExpectedException(typeof(System.NullReferenceException))]
        [TestMethod]
        public void Test_MostrarAlumno_Error()
        {
            List<Alumno> listaAux = new List<Alumno>() //Esto se crea para forzar el error en caso de que la lista venga bien cargada
            {
                new Alumno(1,11,null, null,10),
                new Alumno(2,3,null, "Sandro",15),
                new Alumno(1,11,"pepe", null,10)
            };
            foreach (Alumno item in listaAlum)
            {
                item.ToString();
            }
        }
    }
}
