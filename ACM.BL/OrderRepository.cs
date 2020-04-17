using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieves the order data
        /// </summary>

        public Order Retrieve(int orderId)
        {
            //Code that retrieve one customer
            var order = new Order(orderId);
            if(order.OrderId == 1)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year,4,14,10,00,00,new TimeSpan(7, 0, 0));
            }
            return order;
        }

        /// <summary>
        /// Saves the order data.
        /// </summary>
        /// <return></return>

        public bool Save(Order order)
        {
            //Code that saves the defined order
            var success = true;

            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
                    {
                        //Call Create new order 
                    }
                    else
                    {
                        //Call Update existing order
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;

        }
    }
}
