using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary.Common
{
    /// <summary>
    /// Class to hold collection of Invoice
    /// </summary>
    public class InvoiceCollection : BindingList<Invoice>
    {
        private const decimal GST_RATE = 0.05m;
        private const decimal PST_RATE = 0.07m;

        /// <summary>
        /// Method to return subtotal
        /// </summary>
        public decimal SubTotal
        {
            get
            {
                decimal subtotal = 0.00m;

                foreach (Invoice invoice in this)
                {
                    subtotal += invoice.Price * invoice.Quantity;
                }

                return subtotal;
            }
        }

        /// <summary>
        /// Method to return TotalGST
        /// </summary>
        public decimal TotalGST
        {
            get
            {
                return SubTotal * GST_RATE;
            }
        }

        /// <summary>
        /// Method to return TotalPST
        /// </summary>
        public decimal TotalPST
        {
            get
            {
                decimal totalPST = 0.00m;

                foreach (Invoice invoice in this)
                {
                    decimal invoiceSubTotal;

                    if (invoice.Taxable)
                    {
                        invoiceSubTotal = invoice.Price * invoice.Quantity;
                        totalPST += invoiceSubTotal * PST_RATE;
                    }
                }

                return totalPST;
            }
        }

        /// <summary>
        /// Method to return the GrandTotal
        /// </summary>
        public decimal GrandTotal
        {
            get
            {
                return SubTotal + TotalPST + TotalGST;
            }
        }
    }
}