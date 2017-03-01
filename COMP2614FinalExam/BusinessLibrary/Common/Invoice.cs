using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Common
{
    /// <summary>
    /// Class to hold data
    /// </summary>
    public class Invoice
    {
        /// <summary>
        /// Returns and sets DetailId
        /// </summary>
        public int DetailId { get; set; }

        /// <summary>
        /// Returns and set Quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Returns and sets Sku
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// Returns and sets Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Returns and sets Price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Returns and sets Taxable
        /// </summary>
        public bool Taxable { get; set; }
    }
}