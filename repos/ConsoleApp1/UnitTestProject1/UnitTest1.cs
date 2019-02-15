using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Preparacion
            var numero = 5;
            var resultadoEsperado = 120;
            ConsoleApp1.Program factorial = new ConsoleApp1.Program();

            //Ejecucion
            var resultado = factorial.Factorial(numero);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
