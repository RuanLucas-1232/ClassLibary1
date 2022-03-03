using ClassLibrary1;
using Xunit;

namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double num1 = 1;
            double num2 = 1;
            var resultado = Operacoes.somar(num1, num2);
            Assert.Equal(2, resultado);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, 1, 3)]
        [InlineData(1, 1, 3)]
        public void somarDoisNumerosLista(double num1, double num2, double num3)
        {
            var resultado = Operacoes.somar(num1, num2);

            Assert.Equal(num3, resultado);
        }
    }
}