using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid() 
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName ="Bilbo";
            customer.LastName = "Baggins";
            string expected = "Baggins, Bilbo";

            //-- Act
            string actual = customer.FullName;

            //-- Assert

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.LastName = "Baggins";
            string expected = "Baggins";

            //--Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            string expected = "Bilbo";

            //--Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            //-- Act

            int expected = 3;


            //-- Assert

            Assert.AreEqual(expected, Customer.InstanceCount);
        }


    }
}
