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
            
            bool dateValidator = DateValidator.Validate(year, month, day);           
            
            if (dateValidator)
            {
                displayValid("Valid");
            }
            else
            {
                displayInvalid("Invalid");
            }           
        }
        
        private void displayValid(string validMessage)
        {
            labelResult.ForeColor = Color.Green;
            labelResult.Text = validMessage;
            toolTipResult.SetToolTip(labelResult, "Entered Date is Valid");
        }

        private void displayInvalid(string invalidMessage)
        {
            labelResult.ForeColor = Color.Red;
            labelResult.Text = invalidMessage;
            toolTipResult.SetToolTip(labelResult, "Entered Date is NOT Valid");
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }
    }
}
