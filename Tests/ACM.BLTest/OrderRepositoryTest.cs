using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetreiveOrderDisplayTest()
        {
            //--Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(1)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };
            //--Act
            var actual = orderRepository.Retrieve(1);
            //--Assert
            Assert.AreEqual(expected.OrderId, actual.OrderId);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

        }

        [TestMethod]
        public void OrderSaveTest()
        {
            //--Arrange
            var orderRepository = new OrderRepository();
            var updated = new Order(1)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
                HasChanges = true
            };
            //--Act
            var actual = orderRepository.Save(updated);
            //--Assert
            Assert.AreEqual(true, actual);

        }

        [TestMethod]
        public void OrderSaveTestInvalid()
        {
            //--Arrange
            var orderRepository = new OrderRepository();
            var updated = new Order(1)
            {
                OrderDate = null,
                HasChanges = true
            };
            //--Act
            var actual = orderRepository.Save(updated);
            //--Assert
            Assert.AreEqual(false, actual);

        }
    }
}
