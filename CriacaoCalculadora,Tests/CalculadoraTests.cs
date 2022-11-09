using CriacaoCalculadora;
using Shouldly;
using System.Xml.Schema;


Calculadora calc = new Calculadora();

namespace CriacaoCalculadoraTests
{
    
    public class CalculadoraTests
    {
        Calculadora calc = new Calculadora();

        [Theory]
        [InlineData(16, 4, 20)]
        [InlineData(-16, 2, -14)]
        [InlineData(500000, 100000, 600000)]

        public void SomeNumeros_Sucesso(int pNum, int sNum, int resultadoEsperado)
        {
            // Arrange

            // Act
            int result = calc.Adicao(pNum, sNum);

            // Assert
            result.ShouldBe(resultadoEsperado);
        }

        [Theory]
        [InlineData(16, 4, 12)]
        [InlineData(-16, 2, -18)]
        [InlineData(500000, 100000, 400000)]


        public void SubtracaoNumeros_Sucesso(int pNum, int sNum, int resultadoEsperado)
        {
            // Arrange

            // Act
            int result = calc.Subtracao(pNum, sNum);

            // Assert
            result.ShouldBe(resultadoEsperado);
        }

        [Theory]
        [InlineData(16, 4, 64)]
        [InlineData(-16, 2, -32)]
        [InlineData(50, 100000, 5000000)]

        public void MultiplicaNumeros_Sucesso(int pNum, int sNum, int resultadoEsperado)
        {
            // Arrange

            // Act
            int result = calc.Multiplicacao(pNum, sNum);

            // Assert
            result.ShouldBe(resultadoEsperado);
        }

        [Theory]
        [InlineData(16, 4, 4)]
        [InlineData(-16, 2, -8)]
        [InlineData(500000, 100000, 5)]

        public void DivisaoNumeros_Sucesso(int pNum, int sNum, int resultadoEsperado)
        {
            // Arrange

            // Act
            int result = calc.Divisao(pNum, sNum);

            // Assert
            result.ShouldBe(resultadoEsperado);
        }
    }
}