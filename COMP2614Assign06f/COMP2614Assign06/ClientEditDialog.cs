using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign06b
{
    /// <summary>
    /// Class that contains ClientEditDialog methods
    /// </summary>
    public partial class ClientEditDialog : Form
    {
        /// <summary>
        /// Returns and sets ClientVM
        /// </summary>
        public ClientViewModel ClientVM { get; set; }

        /// <summary>
        /// Constructor to initialize a ClientEditDialog object and its components
        /// </summary>
        public ClientEditDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the ClientEditDialog
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void ClientEditDialog_Load(object sender, EventArgs e)
        {
            setBindings();
        }

        /// <summary>
        /// Sets the binding for a client object
        /// </summary>
        private void setBindings()
        {
            textBoxCompanyName.DataBindings.Add("Text", ClientVM, "CompanyName", false, DataSourceUpdateMode.OnValidation, "");
            textBoxAddress1.DataBindings.Add("Text", ClientVM, "Address1", false, DataSourceUpdateMode.OnValidation, "");
            textBoxAddress2.DataBindings.Add("Text", ClientVM, "Address2", false, DataSourceUpdateMode.OnValidation, "");
            textBoxCity.DataBindings.Add("Text", ClientVM, "City", false, DataSourceUpdateMode.OnValidation, "");
            textBoxProvince.DataBindings.Add("Text", ClientVM, "Province", false, DataSourceUpdateMode.OnValidation, "");
            textBoxPostalCode.DataBindings.Add("Text", ClientVM, "PostalCode", false, DataSourceUpdateMode.OnValidation, "");
            textBoxYTDSales.DataBindings.Add("Text", ClientVM, "YTDSales", false, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            checkBoxCreditHold.DataBindings.Add("Checked", ClientVM, "CreditHold");
            textBoxNotes.DataBindings.Add("Text", ClientVM, "Notes", false, DataSourceUpdateMode.OnValidation, "");

            //textBoxCompanyName.DataBindings.Add("Text", clientVM, "CompanyName");
            //textBoxAddress1.DataBindings.Add("Text", clientVM, "Address1");
            //textBoxAddress2.DataBindings.Add("Text", clientVM, "Address2");
            //textBoxCity.DataBindings.Add("Text", clientVM, "City");
            //textBoxProvince.DataBindings.Add("Text", clientVM, "Province");
            //textBoxPostalCode.DataBindings.Add("Text", clientVM, "PostalCode");
            //textBoxYTDSales.DataBindings.Add("Text", clientVM, "YTDSales", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            //checkBoxCreditHold.DataBindings.Add("Checked", clientVM, "CreditHold");
            //textBoxNotes.DataBindings.Add("Text", clientVM, "Notes");

        }

        /// <summary>
        /// Method to save the changes on a client when Ok button is clicked
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}