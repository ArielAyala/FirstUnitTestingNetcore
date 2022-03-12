using FirstUnitTestingNetcore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstUnitTestingNetcoreTest
{
    [TestClass]
    public class CollectionSampleTest
    {
        [TestMethod]
        public void GetCustomer_ShouldGetSameCustomer()
        {
            //Arrange
            Customer[] customers = new Customer[2] { new Customer { FirstName = "Ariel", LastName = "Ayala" }, new Customer { FirstName = "Felix", LastName = "Ayala" } };

            int index = 1;
            Customer expect = customers[1];

            //Act
            Customer actual = CollectionsSample.GetCustomer(customers, index);

            //Assert
            Assert.IsInstanceOfType(actual, typeof(Customer));
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void GetCustomer_ShouldThrowIndexOutofRangeException()
        {
            //Arrange
            Customer[] customers = new Customer[2] { new Customer { FirstName = "Ariel", LastName = "Ayala" }, new Customer { FirstName = "Felix", LastName = "Ayala" } };

            int index = 3;

            //Act
            CollectionsSample.GetCustomer(customers, index);

            //Assert

        }
    }
}
