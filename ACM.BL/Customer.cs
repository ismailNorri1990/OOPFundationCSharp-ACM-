using System;

namespace ACM.BL
{
    public class Customer
    {
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
    }
}
 