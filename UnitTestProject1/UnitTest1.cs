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
            var result = valuesController.calculeBmi(1,1);
            //assert
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            var valuesController = new ValuesController();

            //act
            var result = valuesController.calculeBmi(2, 2);
            //assert
            Assert.AreEqual(0.5, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            var valuesController = new ValuesController();

            //act
            var result = valuesController.calculeBmi(2, 4);
            //assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            var valuesController = new ValuesController();

            //act
            var result = valuesController.calculeBmi(3, 9);
            //assert
            Assert.AreEqual(1, result);
        }
    }
}
