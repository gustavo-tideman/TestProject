using Xunit;
using UnitTest.Library;

namespace Unit.Test
{
    public class CalculadoraTest
    {
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Somar(2, 2);

            //Assert
            Assert.Equal(4, resultado);
        }

        [Fact]
        public void Calculadora_Subtrair_RetornarValorSubtracao()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Subtrair(10, 5);

            //Assert
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Calculadora_Multiplicar_RetornarValorMultiplicacao()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Multiplicar(9, 3);

            //Assert
            Assert.Equal(27, resultado);
        }

        [Fact]
        public void Calculadora_Dividir_RetornarValorDivisao()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Dividir(26, 2);

            //Assert
            Assert.Equal(13, resultado);
        }
    }
}
