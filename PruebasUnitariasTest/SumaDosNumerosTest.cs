using PruebasUnitarias;

namespace PruebasUnitariasTest
{
    [TestClass]
    public class SumaDosNumerosTest
    {
        [TestMethod]
        public void SumarDosNumerosExitos()
        {
            Calculadora calculadora = new Calculadora();
            int expected = 7; // El resultado esperado de la suma de 2 y 5

            int actual = calculadora.SumaDosNumeros();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SumarDosNumerosFaild()
        {
            Calculadora calculadora = new Calculadora();
            int expected = 10; // El resultado esperado de la suma de 2 y 5

            int actual = calculadora.SumaDosNumeros();

            Assert.AreNotEqual(expected, actual);
        }
    }
}