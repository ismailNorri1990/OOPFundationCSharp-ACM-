using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetreiveTest()
        {
            //--Arrange
            var productRep = new ProductRepository();
            var expected = new Product(1)
            {
                ProductName = "Produit1",
                ProductDescription = "Produit1 Description",
                CurrentPrice = 100
            };

            //--Act
            var actual = productRep.Retrieve(1);
            //--Assert
            Assert.AreEqual(expected.CurrentPrice,actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }
    }
}
