using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{
    /// <summary>
    /// This class represents one Invoice
    /// </summary>
    class Invoice
    {
        private int discountPeriod;
        private decimal totalProvincialSalesTax;
        private decimal subtotalOfItems;
        private decimal governmentSalesTaxOnSubtotalOfItems;
        private decimal grandTotal;
        private decimal discountTotal;
        private string invoiceNumber;
        private const int DENOMINATOR = 100;
        private const int MAXIMUM_INVOICE_LENGTH = 8;
        private const int MINIMUM_DISCOUNT_PERIOD = 10;
        private const int PRETOTAL_PROVINCIAL_SALES_TAX = 0;
        private const decimal GOVERNMENT_SALES_TAX_RATE = .05m;
        private const decimal PROVINCIAL_SALES_TAX_RATE = .07m;
        private const string INVOICE_NUMBER_ERROR = "Invalid Invoice Number";
        private const string TAXABLE = "Y";

        /// <summary>
        /// Returns and sets an array of InvoiceDetailLine Items
        /// </summary>
        public InvoiceDetailLine[] Items { get; set; }

        /// <summary>
        /// Returns and sets the DiscountDate
        /// </summary>
        public string DiscountDate { get; set; }

        /// <summary>
        /// Returns and sets the InvoiceDate
        /// </summary>
        public string InvoiceDate { get; set; }

        /// <summary>
        /// Returns and sets the DiscountAmount
        /// </summary>
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// Returns and sets the invoiceNumber if less than or equal to MAXIMUM_INVOICE_LENGTH
        /// of eight alpha numeric characters otherwise will return INVOICE_NUMBER_ERROR message
        /// </summary>
        public string InvoiceNumber
        {
            get
            {
                if (invoiceNumber.Length <= MAXIMUM_INVOICE_LENGTH)
                {
                    return invoiceNumber;
                }
                else
                {
                    return INVOICE_NUMBER_ERROR;
                }
            }
            set { invoiceNumber = value; }
        }

        /// <summary>
        /// Returns and sets discountPeriod if greater or equal than MINIMUM_DISCOUNT_PERIOD
        /// otherwise will return to the MINIMUM_DISCOUNT_PERIOD
        /// </summary>
        public int DiscountPeriod
        {
            get
            {
                if (discountPeriod >= MINIMUM_DISCOUNT_PERIOD)
                {
                    return discountPeriod;
                }
                else
                {
                    return MINIMUM_DISCOUNT_PERIOD;
                }
            }
            set { discountPeriod = value; }
        }

        /// <summary>
        /// Returns subtotalOfItems
        /// </summary>
        public decimal SubtotalOfItems
        {
            get
            {
                foreach (InvoiceDetailLine item in this.Items)
                {
                    subtotalOfItems += item.TotalItemPrice;
                }
                return subtotalOfItems;
            }
        }

        /// <summary>
        /// Returns governmentSalesTaxOnSubtotalOfItems
        /// </summary>
        public decimal GovernmentSalesTaxOnSubtotalOfItems
        {
            get
            {
                governmentSalesTaxOnSubtotalOfItems = subtotalOfItems * GOVERNMENT_SALES_TAX_RATE;

                return governmentSalesTaxOnSubtotalOfItems;
            }
        }

        /// <summary>
        /// Returns totalProvincialSalesTax
        /// </summary>
        public decimal TotalProvincialSalesTax
        {
            get
            {
                totalProvincialSalesTax = PRETOTAL_PROVINCIAL_SALES_TAX;

                foreach (InvoiceDetailLine item in this.Items)
                {
                    if (item.ProvincialSalesTax == TAXABLE)
                    {
                        totalProvincialSalesTax += (item.ItemPrice * item.Quantity) * PROVINCIAL_SALES_TAX_RATE;
                    }
                }
                return totalProvincialSalesTax;
            }
        }

        /// <summary>
        /// Returns grandTotal
        /// </summary>
        public decimal GrandTotal
        {
            get
            {
                grandTotal = subtotalOfItems + governmentSalesTaxOnSubtotalOfItems + TotalProvincialSalesTax;

                return grandTotal;
            }
        }

        /// <summary>
        /// Returns discountTotal
        /// </summary>
        public decimal DiscountTotal
        {
            get
            {
                discountTotal = (this.GrandTotal * this.DiscountAmount) / DENOMINATOR;

                return discountTotal;
            }
        }

        /// <summary>
        /// String format of Invoice
        /// </summary>
        /// <returns>ToString()</returns>
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", invoiceNumber, this.InvoiceDate, this.DiscountAmount, this.DiscountPeriod);
        }
    }
}