using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioC01_PuedeFallar;

namespace UnitTesting
{
    [TestClass]
    public class ClasFizzBuzzTest
    {
        [TestMethod]
        public void FizzBuzz_AlIngresarDivisiblePorCinco_DeberiaRetornasBuzz()
        {
            string expected = "Buzz";
            int numeroIngresado = 5;

            string actual = ClaseFizzBuzz.FizzBuzz(numeroIngresado);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_AlIngresarDivisiblePorTres_DeberiaRetornasFizz()
        {
            string expected = "Fizz";
            int numeroIngresado = 3;

            string actual = numeroIngresado.FizzBuzz();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FizzBuzz_AlIngresarDivisiblePorTresYCinco_DeberiaRetornasBuzzFizz()
        {
            string expected = "Fizz Buzz";
            int numeroIngresado = 15;

            string actual = numeroIngresado.FizzBuzz();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FizzBuzz_AlIngresarNoDivisiblePorTresNiCinco_DeberiaRetornasElNumero()
        {
            int numeroIngresado = 2;
            string expected = numeroIngresado.ToString();

            string actual = numeroIngresado.FizzBuzz();

            Assert.AreEqual(expected, actual);
        }
    }
}
