using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioI02_ContadorDeDigitos;

namespace UnitTesting
{
    [TestClass]
    public class ContadorDigitosTest
    {
        [TestMethod]
        public void ContadorDigitos_CuandoElNumeroEsUno_DerberiaRetornarUno()
        {
            long numero = 1;
            int resultadoEsperado = 1;

            double resultado = numero.CantidadDeDigitos();

            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        public void ContadorDigitos_CuandoElNumeroEsDiezNegativo_DerberiaRetornarDos()
        {
            long numero = -10;
            int resultadoEsperado = 2;

            double resultado = numero.CantidadDeDigitos();

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        //[TestMethod]
       /* public void ContadorDigitos_CuandoElNumeroEsCero_DerberiaRetornarCero()
        {
            int numero = 0;
            int resultadoEsperado = 0;

            double resultado = ContadorDigitos.CantidadDeDigitos(numero);

            Assert.AreEqual(resultadoEsperado, resultado);
        }*/

        [TestMethod]
        public void ContadorDigitos_CuandoElNumeroEsCien_DerberiaRetornarDos()
        {
            long numero = 100;
            int resultadoEsperado = 3;

            double resultado = numero.CantidadDeDigitos();

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
