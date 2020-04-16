using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Ismail",
                LastName = "Norri"
            };

            string expected = "Norri, Ismail";

            //--Act
            string actual = customer.FullName;
            //--Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                LastName = "Norri"
            };

            string expected = "Norri";

            //--Act
            string actual = customer.FullName;
            //--Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //--Arrange
            Customer customer = new Customer
            {
                FirstName = "Ismail"
            };


            string expected = "Ismail";

            //--Act
            string actual = customer.FullName;
            //--Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //--Arrange
            Customer customer1 = new Customer();
            customer1.FirstName = "Ismail";
            Customer.InstanceCount += 1;

            Customer customer2 = new Customer();
            customer2.FirstName = "Badr";
            Customer.InstanceCount += 1;

            Customer customer3 = new Customer();
            customer3.FirstName = "Issam";
            Customer.InstanceCount += 1;

            //--Act
            
            //--Assert

            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }
}
