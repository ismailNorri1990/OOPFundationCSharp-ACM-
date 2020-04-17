using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using ACM.BL;
using acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //--Arange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAdress = "ismail.norri.24@gmail.com",
                FirstName = "Ismail",
                LastName = "Norri",
                AdressList = null
            };
            changedItems.Add(customer);

            var product = new Product(1)
            {
                ProductName = "Produit1",
                ProductDescription = "Produit1 Description",
                CurrentPrice = 100
            };
            changedItems.Add(product);
            //--Act
            LoggingService.WriteToFile(changedItems);
            //--Assert
            
            //Nothing to Assert - Look to OutPut Console to see the result
        }
    }
}
