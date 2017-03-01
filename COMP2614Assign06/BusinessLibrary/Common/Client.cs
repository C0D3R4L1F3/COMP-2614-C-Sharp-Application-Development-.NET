using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Common
{
    /// <summary>
    /// Data class for client
    /// </summary>
    public class Client
    {
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