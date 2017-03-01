using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign04
{
    /// <summary>
    /// Class for customer data
    /// </summary>
    class Customer
    {
        /// <summary>
        /// Constructor to initialize a Customer object
        /// </summary>
        /// <param name="companyName">the company name of customer</param>
        /// <param name="address">the address of customer</param>
        /// <param name="city">the city of customer</param>
        /// <param name="province">the province of customer</param>
        /// <param name="postalCode">the postal code of customer</param>
        /// <param name="creditHold">the credit hold false otherwise true</param>
        public Customer(string companyName, string address, string city, string province, string postalCode, bool creditHold)
        {
            this.CompanyName = companyName;
            this.Address = address;
            this.City = city;
            this.Province = province;
            this.PostalCode = postalCode;
            this.CreditHold = creditHold;
        }

        /// <summary>
        /// Returns the CompanyName
        /// </summary>
        public string CompanyName { get; }

        /// <summary>
        /// Returns the Address
        /// </summary>
        public string Address { get; }

        /// <summary>
        /// Returns the City
        /// </summary>
        public string City { get; }

        /// <summary>
        /// Returns the Province
        /// </summary>
        public string Province { get; }

        /// <summary>
        /// Returns the PostalCode
        /// </summary>
        public string PostalCode { get; }

        /// <summary>
        /// Returns the CreditHold isCreditHold
        /// </summary>
        public bool CreditHold { get; }
    }
}