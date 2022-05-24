using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioI01_TestDrivenDevelopment;
using Excepciones;

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

        [TestMethod]
        public void Add_CuandoSeIngresanOtroSeparadores_DeberaDevolverElResultadoDeLosNumeros()
        {
            int expected = 3;
            string cadena = "//; \n1; 2";

            int actual = Calculadora.Add(cadena);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]
        public void Add_CuandoRecibeNumerosNegativos_DeberiaLanzarExcepcion()
        {
            string cadena = "//; \n1;-2";

            int actual = Calculadora.Add(cadena);
        }
    }
}
