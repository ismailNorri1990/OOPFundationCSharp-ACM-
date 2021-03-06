﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using acme.Common;

namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {

        public Customer(): this(0)
        {
                    
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AdressList = new List<Adress>(); 
        }

        public override string ToString() => FullName;


        public List<Adress> AdressList { get; set; }

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

        /*        public string Log()
                {
                    var logString = CustomerId + ":" + FullName + " " + "Email: " + EmailAdress + " " + "Status: " + EntityState.ToString();

                    return logString;
                }*/

        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAdress} Status: {EntityState.ToString()}";

        /// <summary>
        /// Validate the customer data
        /// </summary>
        /// <return></return>

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdress)) isValid = false;

            return isValid;

        }
    }
}
 