using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign06b.Common
{
    /// <summary>
    /// Data class for client
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Constructor to initialize a Client object
        /// </summary>
        /// <param name="clientCode">the client code of client</param>
        /// <param name="companyName">the company name of client</param>
        /// <param name="address1">the first address of client</param>
        /// <param name="address2">the second address of client</param>
        /// <param name="city">the city of client</param>
        /// <param name="province">the province of client</param>
        /// <param name="postalCode">the postal code of client</param>
        /// <param name="ytdSales">the year to date sales of client</param>
        /// <param name="creditHold">true if client has credit hold otherwise false</param>
        /// <param name="notes">the notes for client</param>
        public Client(string clientCode, string companyName, string address1, string address2, string city, string province, string postalCode, decimal ytdSales, bool creditHold, string notes)
        {
            this.ClientCode = clientCode;
            this.CompanyName = companyName;
            this.Address1 = address1;
            this.Address2 = address2;
            this.City = city;
            this.Province = province;
            this.PostalCode = postalCode;
            this.YTDSales = ytdSales;
            this.CreditHold = creditHold;
            this.Notes = notes;
        }

        /// <summary>
        /// Returns and sets the ClientCode
        /// </summary>
        public string ClientCode { get; set; }

        /// <summary>
        /// Returns and sets the CompanyName
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Returns and sets Address1
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Returns and sets Address2
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Returns and sets City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Returns and sets Province
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// Returns and sets PostalCode
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns and sets YTDSales
        /// </summary>
        public decimal YTDSales { get; set; }

        /// <summary>
        /// Returns and sets CreditHold
        /// </summary>
        public bool CreditHold { get; set; }

        /// <summary>
        /// Returns and sets Notes
        /// </summary>
        public string Notes { get; set; }
    }
}