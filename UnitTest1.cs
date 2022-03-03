using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrenge - Organizar
            double num1 = 1;
            double num2 = 1;

            //Act - Agir
            var resultado = Operacoes.somar(num1, num2);

            //Assert - verificar
            Assert.AreEqual(2, resultado);
        }

        [DataTestMethod]
        [DataRow(1,1,2)]
        [DataRow(1,1,3)]
        [DataRow(1,2,3)]
        public void somar(double num1, double num2, double num3)
        {
            var resultado = num1 + num2;
            Assert.AreEqual(num3, resultado);
        }
    }
}