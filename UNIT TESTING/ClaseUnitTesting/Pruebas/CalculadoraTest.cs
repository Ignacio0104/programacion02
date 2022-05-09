using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaseUnitTesting;


namespace Pruebas
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void Dividir_CuandoElDivisorEsCero_DerberiaRetornarDoubleMinValue()
        {
            double divisor = 0;
            Calculadora calculadora = new Calculadora();
            double resultadoEsperado = double.MinValue;

            double resultado = calculadora.Dividir(2, divisor);

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Dividir_CuandoElDivisorEsIgualAlDividendo_DerberiaRetornarDoubleMinValue()
        {
            double divisor = 2;
            Calculadora calculadora = new Calculadora();
            double resultadoEsperado = 1;

            double resultado = calculadora.Dividir(2, divisor);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        public void Dividir_CuandoElDivisorNoEsIgualAlDividendo_DerberiaRetornarDoubleMinValue()
        {
            double divisor = 2;
            Calculadora calculadora = new Calculadora();
            double resultadoEsperado = 1.5;

            double resultado = calculadora.Dividir(3, divisor);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
