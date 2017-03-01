using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign02
{
    /// <summary>
    /// Data class for contacts
    /// </summary>
    class Contact
    {
        /// <summary>
        /// Constructor to initialize Contact object
        /// </summary>
        /// <param name="firstName">First name of contact</param>
        /// <param name="lastName">Last name of contact</param>
        /// <param name="address">Address of contact</param>
        /// <param name="city">City of contact</param>
        /// <param name="province">Province of contact</param>
        /// <param name="postalCode">Postal code of contact</param>
        public Contact(string firstName, string lastName, string address, string city, string province, string postalCode)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.Province = province;
            this.PostalCode = postalCode;
        }

        /// <summary>
        /// Sets and returns first name
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Sets and returns last name
        /// </summary>
        public string LastName { get; set; }
       
        /// <summary>
        /// Sets and returns address
        /// </summary>
        public string Address { get; set; }
       
        /// <summary>
        /// Sets and returns city
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Sets and returns province
        /// </summary>
        public string Province { get; set; }
       
        /// <summary>
        /// Sets and returns postal code
        /// </summary>
        public string PostalCode { get; set; }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public Contact()
        {
        }

        /// <summary>
        /// Method to override ToString
        /// </summary>
        /// <returns>ToString</returns>
        public override string ToString()
        {
            return string.Format("{0} {1}", this.LastName, this.FirstName);
        }
    }
}