using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{
    /// <summary>
    /// This class represents the InvoiceDetailLine of an item
    /// </summary>
    class InvoiceDetailLine
    {
        private int quantity;
        private decimal totalItemPrice;
        private string provincialSalesTax;
        private string skuNumber;
        private string itemDescription;
        private const int MAXIMUM_QUANTITY = 999;
        private const int MAXIMUM_SKU_NUMBER_LENGTH = 8;
        private const int MAXIMUM_DESCRIPTION_LENGTH = 20;
        private const string SKU_NUMBER_ERROR = "Invalid Sku";
        private const string DESCRIPTION_ERROR = "Invalid Description";

        /// <summary>
        /// Returns and sets ItemPrice
        /// </summary>
        public decimal ItemPrice { get; set; }

        /// <summary>
        /// Returns and sets provincialSalesTax
        /// </summary>
        public string ProvincialSalesTax
        {
            get { return provincialSalesTax.ToUpper(); }
            set { provincialSalesTax = value; }
        }

        /// <summary>
        /// Returns and sets quantity if less than or equal to MAXIMUM_QUANTITY 
        /// value if over will return MAXIMUM_QUANTITY
        /// </summary>
        public int Quantity
        {
            get
            {
                if (quantity <= MAXIMUM_QUANTITY)
                {
                    return quantity;
                }
                else
                {
                    return MAXIMUM_QUANTITY;
                }
            }
            set { quantity = value; }
        }

        /// <summary>
        /// Returns and sets skuNumber if less than or equal to 
        /// MAXIMUM_SKU_NUMBER_LENGTH otherwise will 
        /// return SKU_NUMBER_ERROR message
        /// </summary>
        public string SkuNumber
        {
            get
            {
                if (skuNumber.Length <= MAXIMUM_SKU_NUMBER_LENGTH)
                {
                    return skuNumber.ToUpper();
                }
                else
                {
                    return SKU_NUMBER_ERROR;
                }
            }
            set { skuNumber = value; }
        }

        /// <summary>
        /// Returns and sets itemDescription if within MAXIMUM_DESCRIPTION_LENGTH
        /// otherwise will return DESCRIPTION_ERROR message
        /// </summary>
        public string ItemDescription
        {
            get
            {
                if (itemDescription.Length <= MAXIMUM_DESCRIPTION_LENGTH)
                {
                    return itemDescription;
                }
                else
                {
                    return DESCRIPTION_ERROR;
                }
            }
            set { itemDescription = value; }
        }

        /// <summary>
        /// Returns totalItemPrice
        /// </summary>
        public decimal TotalItemPrice
        {
            get
            {
                totalItemPrice = this.ItemPrice * quantity;

                return totalItemPrice;
            }
        }

        /// <summary>
        /// String format of InvoiceDetailLine
        /// </summary>
        /// <returns>ToString()</returns>
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", quantity, skuNumber, itemDescription, this.ItemPrice, provincialSalesTax);
        }
    }
}