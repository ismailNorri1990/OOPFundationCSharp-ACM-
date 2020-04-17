using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        /// <summary>
        /// Retrieves the product data
        /// </summary>

        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            if(productId == 1)
            {
                product.CurrentPrice = 100;
                product.ProductName = "Produit1";
                product.ProductDescription = "Produit1 Description";
            }
            //Code that retrieve one product
            return product;
        }

        /// <summary>
        /// Saves the product data.
        /// </summary>
        /// <return></return>

        public bool Save(Product product)
        {
            //Code that saves the defined product

            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //Call an Insert stored procedure
                    }
                    else
                    {
                        //Call an Update stored procedure
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
