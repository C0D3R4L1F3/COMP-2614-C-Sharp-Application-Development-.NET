using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign05
{
    /// <summary>
    /// Class that contains MainForm methods
    /// </summary>
    public partial class MainForm : Form
    {
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
            labelResult.Text = string.Empty;
        }

        /// <summary>
        /// Method that confirms a valid or invalid date when
        /// buttonCheckDate is clicked
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonCheckDate_Click(object sender, EventArgs e)
        {
            dateValidation(DateValidator.Validate(textBoxYear.Text, textBoxMonth.Text, textBoxDay.Text));
        }

        /// <summary>
        /// Method that selects all the characters in a textBox when
        /// entered via tab, or mnemonic 
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void textBoxYear_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        /// <summary>
        /// Method to hold validation values
        /// </summary>
        /// <param name="valid">the valid values to set</param>
        private void dateValidation(bool isValid)
        {
            if (isValid)
            {
                labelResult.ForeColor = Color.Green;
                labelResult.Text = "Valid";
                toolTipResult.SetToolTip(labelResult, "Entered Date is Valid");
            }
            else
            {
                labelResult.ForeColor = Color.Red;
                labelResult.Text = "Invalid";
                toolTipResult.SetToolTip(labelResult, "Entered Date is NOT Valid");
            }
        }
    }
}