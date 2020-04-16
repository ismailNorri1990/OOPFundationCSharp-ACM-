using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class Product
    {
        public Product()
        {
                
        }

        public Product(int productId)
        {
            ProductId = productId;       
        }

        public int ProductId { get; private set; }

        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set; }

        /// <summary>
        /// Retrieves All Products
        /// </summary>
        /// <return></return>

        public List<Product> Retrieves()
        {

            return new List<Product>();

        }

        /// <summary>
        /// Retrieves the product data
        /// </summary>

        public Product Retrieve(int productId)
        {
            //Code that retrieve one product
            return new Product();
        }

        /// <summary>
        /// Saves the product data.
        /// </summary>
        /// <return></return>

        public bool Save()
        {
            //Code that saves the defined customer

            return true;

        }

        /// <summary>
        /// Validate the customer data
        /// </summary>
        /// <return></return>

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;

        }

    }
}
