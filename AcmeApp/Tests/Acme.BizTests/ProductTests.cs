using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void SayHalloTest()
        {
            //Arrange
            var currentProduct = new Product();
            currentProduct.ProductName = "Saw";
            currentProduct.ProductID = 1;
            currentProduct.Description = "15-inch steel blade hand saw";
            var expected = "Hello Saw (1): 15-inch steel blade hand saw";

            //Act
            var actual = currentProduct.SayHallo();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SayHallo_ParametrizedConstructorTest()
        {
            //Arrange
            var currentProduct = new Product(1, "Saw", "15-inch steel blade hand saw");
            var expected = "Hello Saw (1): 15-inch steel blade hand saw";

            //Act
            var actual = currentProduct.SayHallo();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}