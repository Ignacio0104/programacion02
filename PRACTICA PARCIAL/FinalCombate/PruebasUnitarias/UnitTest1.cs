using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaDeClases;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void TestBusinnesException_SiInstancioUnPersonajeConNivelDemasiadoAlto_DebeArrojarExcepcion()
        {
            Personaje personajeAux = new Guerrero(12, "Prueba", 1000);
        }

        [TestMethod]
        [ExpectedException(typeof(BusinessException))]
        public void TestBusinnesException_SiInstancioUnPersonajeConNivelDemasiadoBajo_DebeArrojarExcepcion()
        {
            Personaje personajeAux = new Guerrero(12, "Prueba", 0);
        }

        [TestMethod]
        public void TestAtaquet_SiUnJugadorRecibeAtaqueNoPuedeQuedarEnNegativo_DebeQuedarEnCero()
        {
            Guerrero personajeAuxUno = new Guerrero(1, "PruebaUno", 2);
            int expected = 0;
            personajeAuxUno.RecibirAtaque(600000);

            Assert.AreEqual(expected, personajeAuxUno.PuntosDeVida);
        }


        [TestMethod]
        public void TestDefensa_LosPuntosDeDefensaDeLosHechiceros_DebeSerNivelPor100()
        {
            Hechicero personajeAuxUno = new Hechicero(1, "PruebaUno",2);
            int expected = 200;

            Assert.AreEqual(expected, personajeAuxUno.PuntosDeDefensa);
        }

        [TestMethod]
        public void TestDefensa_LosPuntosDeDefensaDeLosGuerreros_DebeSerNivelPor100Mas100Porciento()
        {
            Guerrero personajeAuxUno = new Guerrero(1, "PruebaUno", 2);
            int expected = 200 + (int)((200 * 10) / 100);
            

            Assert.AreEqual(expected, personajeAuxUno.PuntosDeDefensa);
        }



    }
}
