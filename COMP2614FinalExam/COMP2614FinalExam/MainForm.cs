using BusinessLibrary.Common;
using BusinessLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614FinalExam
{
    /// <summary>
    /// Class that contains MainForm methods
    /// </summary>
    public partial class MainForm : Form
    {
        private InvoiceViewModel invoiceVM;

        /// <summary>
        /// Constructor to initialize a MainForm object and its components
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the MainForm
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            invoiceVM = new InvoiceViewModel(InvoiceRepository.GetInvoices());
            setBindings();
            labelTotals.Text = string.Empty;
        }

        /// <summary>
        /// Sets bindings for Invoice
        /// </summary>
        private void setBindings()
        {
            textBoxQuantity.DataBindings.Add("Text", invoiceVM, "Quantity", false, DataSourceUpdateMode.OnValidation, "");
            textBoxSku.DataBindings.Add("Text", invoiceVM, "Sku", false, DataSourceUpdateMode.OnValidation, "");
            textBoxDescription.DataBindings.Add("Text", invoiceVM, "Description", false, DataSourceUpdateMode.OnValidation, "");
            textBoxPrice.DataBindings.Add("Text", invoiceVM, "Price", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            textBoxExtended.DataBindings.Add("Text", invoiceVM, "Extended", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            checkBoxTaxable.DataBindings.Add("Checked", invoiceVM, "Taxable", false, DataSourceUpdateMode.OnValidation, "");

            listBoxSku.DataSource = invoiceVM.Invoices;
            listBoxSku.DisplayMember = "Sku";
        }

        /// <summary>
        /// List of invoices that have been updated or saved internally
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void listBoxSku_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Math.Max(0, listBoxSku.SelectedIndex);
            Invoice invoice = invoiceVM.Invoices[selectedIndex];
            invoiceVM.SetDisplayInvoice(invoice);
        }

        /// <summary>
        /// Button to save upon click
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            int index = listBoxSku.SelectedIndex;
            Invoice invoice = invoiceVM.SaveInvoice(index);
            invoiceVM.Invoices.ResetItem(index);
            InvoiceCollection invoices = invoiceVM.Invoices;
            string outputTotals;                       

            outputTotals = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}"
                               , invoices.SubTotal.ToString("N2")
                               , invoices.TotalGST.ToString("N2")
                               , invoices.TotalPST.ToString("N2")
                               , invoices.GrandTotal.ToString("N2"));
                        
            labelTotals.Text = outputTotals;
        }
    }
}