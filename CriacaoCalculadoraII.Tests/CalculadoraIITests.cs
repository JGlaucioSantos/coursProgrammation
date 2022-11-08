using Shouldly;
using System.Xml.Schema;

namespace CriacaoCalculadoraII.Tests
{
    public class CalculadoraIITests

    {
        CalculadoraII calcII = new CalculadoraII();

        [Theory]

        [InlineData(16, 4, 4)]
        [InlineData(-16, 2, -8)]
        [InlineData(500000, 100000, 5)]

        public void DivideNumeros_Sucesso(int pNum, int sNum, int resultadoEsperado)
        {
            // Arrange

            // Act

            int result = calcII.DivideDoisNumeros(pNum, sNum);

            // Assert

            result.ShouldBe(resultadoEsperado);
        }

        [Theory]

        [InlineData(16, 4, 20)]
        [InlineData(-16, 2, -14)]
        [InlineData(500000, 100000, 600000)]

        public void SomaNumeros_Sucesso(int pNum, int sNum, int resultadoEsperado)
        {
            // Arrange

            // Act

            int result = calcII.SomaDoisNumeros(pNum, sNum);

            // Assert

            result.ShouldBe(resultadoEsperado);
        }

        [Theory]

        [InlineData(16, 4, 64)]
        [InlineData(-16, 2, -32)]
        [InlineData(500, 100000, 50000000)]

        public void MultipliqueDoisNumeros(int pNum, int sNum, int resultadoEsperado)
        {
            // Arrange

            // Act

            int result = calcII.MultiplicaDoisNumeros(pNum, sNum);

            // Assert

            result.ShouldBe(resultadoEsperado);
        }

        [Theory]

        [InlineData(16, 4, 12)]
        [InlineData(-16, 2, -18)]
        [InlineData(500000, 100000, 400000)]

        public void SubtraiDoisNumeros(int pNum, int sNum, int resultadoEsperado)
        {
            // Arrange

            // Act

            int result = calcII.SubtraiDoisNumeros(pNum, sNum);

            // Assert

            result.ShouldBe(resultadoEsperado);
        }


    }

}