using BusinessLibrary.Business;
using BusinessLibrary.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign06
{
    /// <summary>
    /// Class to display the YTDSales and CreditHoldCount Totals
    /// </summary>
    public partial class TotalsDialog : Form
    {
        private static TotalsDialog instance;
        /// <summary>
        /// Constructor to initialize a TotalsForm object and its components
        /// </summary>
        public TotalsDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the TotalsForm
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void TotalsDialog_Load(object sender, EventArgs e)
        {
            totals();
        }

        /// <summary>
        /// Method to generate  ClientCount, CreditHoldCount YTDSales Totals
        /// </summary>
        private void totals()
        {
            ClientCollection totals = ClientValidation.GetClients();

            labelDisplayClientCount.Text = totals.ClientCount.ToString();
            labelDisplayCreditHoldCount.Text = totals.CreditHoldCount.ToString();
            labelDisplayYTDSalesTotal.Text = totals.TotalYTDSales.ToString();
        }

        /// <summary>
        /// Method to create a TotalsDialog Form 
        /// </summary>
        /// <returns>instance</returns>
        public static TotalsDialog CreateForm()   // create public static method with form type return
        {
            if (instance == null)
            {
                instance = new TotalsDialog();
            }

            return instance;
        }

        /// <summary>
        /// Method to make instance of form to null upon closing
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void TotalsDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        /// <summary>
        /// Method to close the TotalsForm
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}