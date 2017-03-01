using BusinessLibrary.Business;
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

namespace COMP2614Assign06f
{
    /// <summary>
    /// Class to display the YTDSales and CreditHoldCount Totals
    /// </summary>
    public partial class TotalsForm : Form
    {
        /// <summary>
        /// Constructor to initialize a TotalsForm object and its components
        /// </summary>
        public TotalsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the TotalsForm
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void TotalsForm_Load(object sender, EventArgs e)
        {
            Totals();
        }

        /// <summary>
        /// Method to generate YTDSales and CreditHoldCount Totals
        /// </summary>
        private void Totals()
        {
            ClientCollection totals = ClientValidation.GetClients();

            textBoxTotalYTDSales.Text = totals.TotalYTDSales.ToString();
            textBoxCreditHoldCount.Text = totals.CreditHoldCount.ToString();
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