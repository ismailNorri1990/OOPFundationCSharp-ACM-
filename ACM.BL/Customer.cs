using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {

        public Customer()
        {
                    
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }


        public int CustomerId { get; private set; }
        public string EmailAdress { get; set; }

        public static int InstanceCount { get; set; }
        
        public string FirstName { get; set; }
        
        public string FullName
        {
            get
            {
                string FullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName)){
                    if (!string.IsNullOrWhiteSpace(FullName))
                    {
                        FullName += ", ";
                    }
                    FullName += FirstName; 
                }
                return FullName;
            }
        }

        private string _lastName;

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }

        }

        /// <summary>
        /// Retrieves All Customers
        /// </summary>
        /// <return></return>

        public List <Customer> Retrieves()
        {
            
            return new List<Customer>();

        }

        /// <summary>
        /// Retrieves the customer data
        /// </summary>

        public Customer Retrieve(int customerId)
        {
            //Code that retrieve one customer
            return new Customer();
        }

        /// <summary>
        /// Saves the customer data.
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

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdress)) isValid = false;

            return isValid;

        }
    }
}
 