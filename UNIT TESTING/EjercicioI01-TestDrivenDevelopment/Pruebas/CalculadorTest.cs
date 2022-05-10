using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioI01_TestDrivenDevelopment;

namespace Pruebas
{
    [TestClass]
    public class CalculadorTest
    {
        [TestMethod]
        public void Add_CuandoSeIngresaUnUnoYUnDos_DeberaDeVolverTres()
        {
            int expected = 3;
            string cadena = "1,2";

            int actual = Calculadora.Add(cadena);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_CuandoSeIngresaUnUnoSolamente_DeberaDeVolverUno()
        {
            int expected = 1;
            string cadena = "1";

            int actual = Calculadora.Add(cadena);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_CuandoSeIngresaCadenaVacia_DeberaDevolverCero()
        {
            int expected = 0;
            string cadena = "";

            int actual = Calculadora.Add(cadena);

            Assert.AreEqual(expected, actual);
        }
    }
}
