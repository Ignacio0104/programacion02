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
    public class StringExtensionTest
    {
        [TestMethod]
        public void ContarVocales_CuandoNoTieneVocales_DeberiaRetornarCero()
        {
            int expected = 0;
            string text = "gkmhmhlhlmh";
            char caracter = ';';

            int actual = text.ContarCaracteres(caracter);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ContarVocales_CuandoTieneDosVocales_DeberiaRetornarDos()
        {
            int expected = 2;
            string text = "casa";

            int actual = StringExtension.ContarVocales(text);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ContarVocales_CuandoTieneTresVocalesEnMayuscula_DeberiaRetornarTres()
        {
            int expected = 3;
            string text = "LA COSA";

            int actual = StringExtension.ContarVocales(text);
            //int actual = text.ContarVocales(); Esto se puede gracias al this. Se permite utilizarlo como si fuese de instancia

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void ContarVocales_CuandoElTextEsNulo_DeberiaLanzarBusinessException()
        {
            
            string text = null;

            text.ContarVocales();

        }

        [TestMethod]
        public void ContarVocales_CuandoTieneElCaracterDosVeces_DeberiaRetornarDos()
        {
            int expected = 2;
            string text = "casa. agagagw.";
            char caracter = '.';

            int actual = text.ContarCaracteres(caracter);

            Assert.AreEqual(expected, actual);

        }
    }
}
