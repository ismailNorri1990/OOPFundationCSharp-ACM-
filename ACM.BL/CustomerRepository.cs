﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {

        public CustomerRepository()
        {
            adressRepository = new AdressRepository();
        }
        public AdressRepository adressRepository { get; set; }

        /// <summary>
        /// Retrieves the customer data
        /// </summary>

        public Customer Retrieve(int customerId)
        {
            //Pass in the request Id
            Customer customer = new Customer(customerId);

            //Code that retreive the defined customer

            //Temporary HardCoded Value To return a populated customer
            if(customerId == 1)
            {
                customer.EmailAdress = "ismail.norri.24@gmail.com";
                customer.LastName = "Norri";
                customer.FirstName = "Ismail";
                customer.AdressList = adressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            //Code that retrieve one customer
            return customer;
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
    }
}