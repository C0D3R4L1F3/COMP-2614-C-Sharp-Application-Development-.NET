using BusinessLibrary.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614FinalExam
{
    /// <summary>
    /// Representation class for Invoice objects
    /// </summary>
    class InvoiceViewModel : INotifyPropertyChanged
    {
        public int detailId;
        public int quantity;
        public string sku;
        public string description;
        public decimal price;
        public bool taxable;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Method to change property from an event
        /// </summary>
        /// <param name="propertyName">the propertyName to set</param>
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Constructor to inialize a InvoiceViewModel Object
        /// </summary>
        /// <param name="invoices">the invoice to set</param>
        public InvoiceViewModel(InvoiceCollection invoices)
        {
            this.Invoices = invoices;
        }

        /// <summary>
        /// Property field DetailId
        /// </summary>
        public int DetailId
        {
            get { return detailId; }
            set
            {
                detailId = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property field Quantity
        /// </summary>
        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property field Sku
        /// </summary>
        public string Sku
        {
            get { return sku; }
            set
            {
                sku = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property field Description
        /// </summary>
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property field Price
        /// </summary>
        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Property field Taxable
        /// </summary>
        public bool Taxable
        {
            get { return taxable; }
            set
            {
                taxable = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Method to calculate Extended
        /// </summary>
        public decimal Extended
        {
            get { return this.price * this.quantity; }
        }

        /// <summary>
        /// Returns and set the Invoices
        /// </summary>
        public InvoiceCollection Invoices { get; set; }

        /// <summary>
        /// Method to set display Invoice
        /// </summary>
        /// <param name="invoice">the invoice to set</param>
        public void SetDisplayInvoice(Invoice invoice)
        {
            this.DetailId = invoice.DetailId;
            this.Quantity = invoice.Quantity;
            this.Sku = invoice.Sku;
            this.Description = invoice.Description;
            this.Price = invoice.Price;
            this.Taxable = invoice.Taxable;
        }

        /// <summary>
        /// Method to save Invoice changes of information
        /// </summary>
        /// <param name="collectionIndex">collectionIndex to set</param>
        /// <returns>Invoices[collectionIndex]</returns>
        public Invoice SaveInvoice(int collectionIndex)
        {
            this.Invoices[collectionIndex].DetailId = this.DetailId;
            this.Invoices[collectionIndex].Quantity = this.Quantity;
            this.Invoices[collectionIndex].Sku = this.Sku;
            this.Invoices[collectionIndex].Description = this.Description;
            this.Invoices[collectionIndex].Price = this.Price;
            this.Invoices[collectionIndex].Taxable = this.Taxable;

            return this.Invoices[collectionIndex];
        }
    }
}