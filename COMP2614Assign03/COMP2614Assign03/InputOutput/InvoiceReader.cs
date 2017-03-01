using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Assign03
{
    /// <summary>
    /// This class parses the invoicedata.txt file
    /// </summary>
    class InvoiceReader
    {
        private List<Invoice> invoices;
        private const int TERMS_LENGTH = 3;
        private const int NUMBER_OF_ELEMENTS = 0;
        private const int MAXIMUM_NUMBER_OF_ITEMS = 19;

        /// <summary>
        /// Constructor to initialize an InvoiceReader object
        /// </summary>
        public InvoiceReader()
        {
            invoices = new List<Invoice>();
        }

        /// <summary>
        /// Method to read and parse the invoicedata.txt file
        /// </summary>
        /// <param name="lineData">file to parse</param>
        public void ReadLineData(string lineData)
        {
            string[] line = lineData.Split('|', ':');
            Invoice invoice = new Invoice();
            List<InvoiceDetailLine> items = new List<InvoiceDetailLine>();
            int element = NUMBER_OF_ELEMENTS;

            invoice.InvoiceNumber = line[element++];

            DateFormatter dateFormatter = new DateFormatter();
            invoice.InvoiceDate = dateFormatter.Date(line[element++]);

            // If line[element].Length does not equal TERMS_LENGTH invoice will not generate
            // and will return error message
            if (line[element].Length == TERMS_LENGTH)
            {
                invoice.DiscountAmount = int.Parse(line[element].Substring(0, 1));

                int discountDays = int.Parse(line[element++].Substring(1, 2));

                invoice.DiscountPeriod = discountDays;
                invoice.DiscountDate = dateFormatter.AddDays(discountDays);
            }
            else
            {
                ConsolePrinter.PrintError("Error with data file. Unable to parse the invoice's terms " + line[element], " - An invoice not generated, terms must only be 3 numeric characters.");
                return;
            }

            while (line.Length > element)
            {
                InvoiceDetailLine item = new InvoiceDetailLine();

                item.Quantity = int.Parse(line[element++]);
                item.SkuNumber = line[element++];
                item.ItemDescription = line[element++];
                item.ItemPrice = decimal.Parse(line[element++]);
                item.ProvincialSalesTax = line[element++];

                // If items.Count is greater than MAXIMUM_NUMBER_OF_ITEMS invoice will not generate
                // and will return error message
                if (items.Count <= MAXIMUM_NUMBER_OF_ITEMS)
                {
                    items.Add(item);
                }
                else if (items.Count > MAXIMUM_NUMBER_OF_ITEMS)
                {
                    ConsolePrinter.PrintError("Error with data file. Unable to parse the invoice's items list", " - An invoice not generated, total of items must be less than or equal to " + items.Count);
                    return;
                }
            }

            invoice.Items = items.ToArray();
            invoices.Add(invoice);
        }

        /// <summary>
        /// Returns a list of invoices
        /// </summary>
        /// <returns>invoices</returns>
        public List<Invoice> Invoices
        {
            get
            {
                return invoices;
            }
        }
    }
}