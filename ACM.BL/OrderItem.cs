using System.Collections.Generic;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
             
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
              
        }

        public int OrderItemId { get; private set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Retrieves All OrderItems
        /// </summary>
        /// <return></return>

        public List<OrderItem> Retrieves()
        {

            return new List<OrderItem>();

        }

        /// <summary>
        /// Retrieves the ordeItem data
        /// </summary>

        public OrderItem Retrieve(int orderItemId)
        {
            //Code that retrieve one ordeItem
            return new OrderItem();
        }

        /// <summary>
        /// Saves the orderItem data.
        /// </summary>
        /// <return></return>

        public bool Save()
        {
            //Code that saves the defined orderItem

            return true;

        }

        /// <summary>
        /// Validate the orderItem data
        /// </summary>
        /// <return></return>

        public bool Validate()
        {
            var isValid = true;

            if (PurchasePrice== null) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (Quantity <= 0) isValid = false;

            return isValid;

        }

    }
}