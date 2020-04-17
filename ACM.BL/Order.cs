using System;
using System.Collections.Generic;
using System.Text;
using acme.Common;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
        { 
        public Order():this(0)
        {
                
        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public override string ToString() => $"{OrderDate.Value.Date}({OrderId})";
        public List<OrderItem> OrderItems { get; set; }
        public int CustomerId { get; set; }
        public int CustomerType { get; set; }
        public int ShippingAdressId { get; set; }
        public int OrderId { get; private set;}
        public DateTimeOffset? OrderDate { get; set; }
                

        /// <summary>
        /// Validate the order data
        /// </summary>
        /// <return></return>

        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;

        }

        public string Log() => $"{OrderId}: Date: {this.OrderDate.Value.Date} Status: {this.EntityState.ToString()}";
    }
}
