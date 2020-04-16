using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {
                
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set;}
        public DateTimeOffset? OrderDate { get; set; }

        /// <summary>
        /// Retrieves All Orders
        /// </summary>
        /// <return></return>

        public List<Order> Retrieves()
        {

            return new List<Order>();

        }

        /// <summary>
        /// Retrieves the order data
        /// </summary>

        public Order Retrieve(int orderId)
        {
            //Code that retrieve one customer
            return new Order();
        }

        /// <summary>
        /// Saves the order data.
        /// </summary>
        /// <return></return>

        public bool Save()
        {
            //Code that saves the defined order

            return true;

        }

        /// <summary>
        /// Validate the order data
        /// </summary>
        /// <return></return>

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;

        }

    }
}
