using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{
    /// <summary>
    /// This class is to output the invoice data to console
    /// </summary>
    class ConsolePrinter
    {
        private string SEPARATOR = new string('-', 67);
        private string INVOICE_HEADER = string.Format("{0, -3} {1, -12} {2, -20} {3, 10} {4, 7} {5, 10}", "Qty", "SKU", "Description", "Price", "PST", "Ext");
        private string INVOICE_DETAIL_LINE_FORMAT = "{0, 3} {1, -12} {2, -20} {3, 10:N2} {4, 6} {5, 11:N2}";
        private const int ERROR_SEPARATOR = 55;
        private const int PST_ITEMS = 0;
        private const string HEADER = "Invoice Listing";

        /// <summary>
        /// Prints the invoices in predefined format
        /// </summary>
        /// <param name="invoices">invoices to print</param>
        public void PrintInvoices(Invoice[] invoices)
        {
            Console.WriteLine(HEADER);
            Console.WriteLine($"{SEPARATOR}\n");

            foreach (Invoice invoice in invoices)
            {
                Console.WriteLine("Invoice Number:  {0} ", invoice.InvoiceNumber);
                Console.WriteLine("Invoice Date:    {0} ", invoice.InvoiceDate);
                Console.WriteLine("Discount Date:   {0} ", invoice.DiscountDate);
                Console.WriteLine("Terms:           {0}% {1} days ADI ", invoice.DiscountAmount, invoice.DiscountPeriod);
                Console.WriteLine(SEPARATOR);
                Console.WriteLine(INVOICE_HEADER);
                Console.WriteLine(SEPARATOR);

                foreach (InvoiceDetailLine item in invoice.Items)
                {
                    Console.WriteLine(INVOICE_DETAIL_LINE_FORMAT, item.Quantity, item.SkuNumber, item.ItemDescription, item.ItemPrice, item.ProvincialSalesTax, item.TotalItemPrice);
                }

                Console.WriteLine(SEPARATOR);
                Console.WriteLine("{0, 16} {1, -12} {2, 37:N2}", " ", "Subtotal:", invoice.SubtotalOfItems);
                Console.WriteLine("{0, 16} {1, -12} {2, 37:N2}", " ", "GST:", invoice.GovernmentSalesTaxOnSubtotalOfItems);

                if (invoice.TotalProvincialSalesTax > PST_ITEMS)
                {
                    Console.WriteLine("{0, 16} {1, -12} {2, 37:N2}", " ", "PST:", invoice.TotalProvincialSalesTax);
                }

                Console.WriteLine(SEPARATOR);
                Console.WriteLine("{0, 16} {1, -12} {2, 37:N2}\n", " ", "Total:", invoice.GrandTotal);
                Console.WriteLine("{0, 16} {1, -12} {2, 37:N2}\n\n", " ", "Discount:", invoice.DiscountTotal);
            }
        }

        /// <summary>
        /// Method used to print errors
        /// </summary>
        /// <param name="errorMsg">Error message</param>
        /// <param name="error">Error reason</param>
        public static void PrintError(string errorMsg, string error)
        {
            Console.WriteLine(new string('=', ERROR_SEPARATOR));
            Console.WriteLine("ERROR!!!");
            Console.WriteLine("{0} {1}", errorMsg, error);
            Console.WriteLine(new string('=', ERROR_SEPARATOR));
        }
    }
}