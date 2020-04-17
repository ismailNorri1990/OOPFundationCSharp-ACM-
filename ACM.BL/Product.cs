﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product: EntityBase
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

        public string ProductName { get; set; }
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

    }
}
