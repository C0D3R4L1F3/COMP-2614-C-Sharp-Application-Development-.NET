using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign05
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelResult.Text = string.Empty;
        }

        private void buttonCheckDate_Click(object sender, EventArgs e)
        {
            string year = textBoxYear.Text;
            string month = textBoxMonth.Text;
            string day = textBoxDay.Text;

            dateValidation(DateValidator.Validate(year, month, day));
        }

        private void dateValidation(bool valid)
        {
            if (valid)
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

        private void textBoxYear_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        private void textBoxMonth_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        private void textBoxDay_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }
    }
}
