using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class AdressRepository
    {
        /// <summary>
        /// Retrieve one Adress
        /// </summary>
        /// <param name="idAdress"></param>
        /// <returns></returns>

        public Adress Retrieve(int idAdress)
        {
            //Create instance of Adress Class
            //Pass in the request id
            var adress = new Adress(idAdress);

            //code that retrieve the defined adress

            //Hardcode value coded to return populated adress
            if(adress.AdressId == 1)
            {
                adress.AdressType = 1 ;
                adress.City = "Casablanca";
                adress.Country = "Maroc";
                adress.PostalCode = "20390";
                adress.StateProvince ="Casa-Settat";
                adress.StreetLine1 ="19, Rue Lacordière";
                adress.StreetLine2 ="France Ville 2";

            }

            return adress;
        }

        /// <summary>
        /// Retrieve AdressList by cutomerId
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>

        public IEnumerable<Adress> RetrieveByCustomerId (int customerId)
        {
            var adressList = new List<Adress>();
            Adress adress = new Adress(1)
            {
                AdressType = 1,
                City = "Casablanca",
                Country = "Maroc",
                PostalCode = "20390",
                StateProvince = "Casa-Settat",
                StreetLine1 = "19, Rue Lacordière",
                StreetLine2 = "France Ville 2",
            };
            adressList.Add(adress);

            adress = new Adress(2)
            {
                AdressType = 2,
                City = "Casablanca",
                Country = "Maroc",
                PostalCode = "21500",
                StateProvince = "Casa-Settat",
                StreetLine1 = "Shore 5, Casanearshore",
                StreetLine2 = "Sidi Maarouf",
            };
            adressList.Add(adress);

            return adressList;
        }


        /// <summary>
        /// Saves the adress data.
        /// </summary>
        /// <param name="adress"></param>
        /// <returns></returns>

        public bool Save(Adress adress)
        {
            //Code that saves the defined order

            return true;

        }
    }
}
