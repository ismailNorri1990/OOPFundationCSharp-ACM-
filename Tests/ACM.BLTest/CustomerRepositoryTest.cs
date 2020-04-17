using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "Ismail",
                LastName = "Norri",
                EmailAdress = "ismail.norri.24@gmail.com"
            };
            

            //--Act
            var actual = customerRepository.Retrieve(1);

            //--Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAdress, actual.EmailAdress);


        }


        [TestMethod]
        public void RetrieveExistingWithAdress()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "Ismail",
                LastName = "Norri",
                EmailAdress = "ismail.norri.24@gmail.com",
                AdressList = new List<Adress>()
                {
             new Adress()
            {
                AdressType = 1,
                City = "Casablanca",
                Country = "Maroc",
                PostalCode = "20390",
                StateProvince = "Casa-Settat",
                StreetLine1 = "19, Rue Lacordière",
                StreetLine2 = "France Ville 2",
            },
            new Adress()
            {
                AdressType = 2,
                City = "Casablanca",
                Country = "Maroc",
                PostalCode = "21500",
                StateProvince = "Casa-Settat",
                StreetLine1 = "Shore 5, Casanearshore",
                StreetLine2 = "Sidi Maarouf",
            }
        }

            };

            //--Act
            var actual = customerRepository.Retrieve(1);

            //--Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAdress, actual.EmailAdress);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AdressList[i].AdressType, actual.AdressList[i].AdressType);
                Assert.AreEqual(expected.AdressList[i].City, actual.AdressList[i].City);
                Assert.AreEqual(expected.AdressList[i].Country, actual.AdressList[i].Country);
                Assert.AreEqual(expected.AdressList[i].PostalCode, actual.AdressList[i].PostalCode);
                Assert.AreEqual(expected.AdressList[i].StateProvince, actual.AdressList[i].StateProvince);
                Assert.AreEqual(expected.AdressList[i].StreetLine1, actual.AdressList[i].StreetLine1);
                Assert.AreEqual(expected.AdressList[i].StreetLine2, actual.AdressList[i].StreetLine2);
            }


        }

        [TestMethod]
        public void SaveTestValid()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var updatedCustomer = new Customer(1)
            {
                FirstName = "Ismail",
                LastName = "Norri",
                EmailAdress = "ismail.norri.24@gmail.com",
                HasChanges = true,
                AdressList = new List<Adress>()
                {
             new Adress()
            {
                AdressType = 1,
                City = "Casablanca",
                Country = "Maroc",
                PostalCode = "20390",
                StateProvince = "Casa-Settat",
                StreetLine1 = "19, Rue Lacordière",
                StreetLine2 = "France Ville 2",
            },
            new Adress()
            {
                AdressType = 2,
                City = "Casablanca",
                Country = "Maroc",
                PostalCode = "21500",
                StateProvince = "Casa-Settat",
                StreetLine1 = "Shore 5, Casanearshore",
                StreetLine2 = "Sidi Maarouf",
            }
        }

            };

            //--Act
            var actual = customerRepository.Save(updatedCustomer);

            //--Assert
            Assert.AreEqual(true, actual);

        }

        [TestMethod]
        public void SaveTestInvalidLastname()
        {
            //--Arrange
            var customerRepository = new CustomerRepository();
            var updatedCustomer = new Customer(1)
            {
                FirstName = "Ismail",
                LastName = "",
                EmailAdress = "ismail.norri.24@gmail.com",
                HasChanges = true,
                AdressList = new List<Adress>()
                {
             new Adress()
            {
                AdressType = 1,
                City = "Casablanca",
                Country = "Maroc",
                PostalCode = "20390",
                StateProvince = "Casa-Settat",
                StreetLine1 = "19, Rue Lacordière",
                StreetLine2 = "France Ville 2",
            },
            new Adress()
            {
                AdressType = 2,
                City = "Casablanca",
                Country = "Maroc",
                PostalCode = "21500",
                StateProvince = "Casa-Settat",
                StreetLine1 = "Shore 5, Casanearshore",
                StreetLine2 = "Sidi Maarouf",
            }
        }

            };

            //--Act
            var actual = customerRepository.Save(updatedCustomer);

            //--Assert
            Assert.AreEqual(false, actual);

        }
    }
}
