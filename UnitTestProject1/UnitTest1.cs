using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevAPP.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var valuesController = new ValuesController();

            //act
            var result = valuesController.calculeBmi(0, 0);
            //assert
            Assert.AreEqual(0, result);
        }

        public void TestMethod2()
        {
            // Arrange
            var valuesController = new ValuesController();

            //act
            var result = valuesController.calculeBmi(2,2);
            //assert
            Assert.AreEqual(0.5, result);
        }

        public void TestMethod3()
        {
            // Arrange
            var valuesController = new ValuesController();

            //act
            var result = valuesController.calculeBmi(0, 0);
            //assert
            Assert.AreEqual(0, result);
        }
    }
}
