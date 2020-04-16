using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Adress
    {
        public Adress()
        {
                
        }

        public Adress(int adressId)
        {
            AdressId = adressId;
        }

        public int AdressId { get; private set; }
        public int AdressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        ///<summary>
        /// Validate the AdressData
        /// </summary>
        /// <return></return>
        
        public bool Validate()
        {
            bool isValid = true;

            if (PostalCode==null) isValid = false;

            return isValid;
        }
        
    }
}
