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

        [TestMethod]
        public void SaveTestValid()
        {
            //--Arrange
            var productRep = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Produit1",
                ProductDescription = "Produit1 Description",
                CurrentPrice = 100,
                HasChanges = true
            };

            //--Act
            var actual = productRep.Save(updatedProduct);
            //--Assert
            Assert.AreEqual(true, actual);
         }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //--Arrange
            var productRep = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                ProductName = "Produit1",
                ProductDescription = "Produit1 Description",
                CurrentPrice = null,
                HasChanges = true
            };

            //--Act
            var actual = productRep.Save(updatedProduct);
            //--Assert
            Assert.AreEqual(false, actual);
        }

    }
}
