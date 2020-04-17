using System;
using System.Collections.Generic;
using System.Text;
using acme.Common;

namespace ACM.BL
{
    public class Product: EntityBase, ILoggable
    {
        public Product()
        {
                
        }

        public Product(int productId)
        {
            ProductId = productId;       
        }

        public override string ToString() => ProductName;
        public int ProductId { get; private set; }

        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }
        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set; }

        
        /// <summary>
        /// Validate the customer data
        /// </summary>
        /// <return></return>

        public override bool  Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;

        }

        public string Log() => $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {this.EntityState.ToString()}";
    }
}
