using BusinessLibrary.Business;
using BusinessLibrary.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign06
{
    /// <summary>
    /// Class that contains ClientEditDialog methods
    /// </summary>
    public partial class ClientDetailsDialog : Form
    {
        private const int CURSOR_POSITION = 0;
        private bool keyHandled;

        /// <summary>
        /// Returns and sets ClientVM
        /// </summary>
        public ClientViewModel ClientVM { get; set; }

        /// <summary>
        /// Constructor to initialize a ClientEditDialog object and its components
        /// </summary>
        public ClientDetailsDialog()
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
            maskedTextBoxClientCode.DataBindings.Add("Text", ClientVM, "ClientCode", false, DataSourceUpdateMode.OnValidation, "");
            textBoxCompanyName.DataBindings.Add("Text", ClientVM, "CompanyName", false, DataSourceUpdateMode.OnValidation, "");
            textBoxAddress1.DataBindings.Add("Text", ClientVM, "Address1", false, DataSourceUpdateMode.OnValidation, "");
            textBoxAddress2.DataBindings.Add("Text", ClientVM, "Address2", false, DataSourceUpdateMode.OnValidation, "");
            textBoxCity.DataBindings.Add("Text", ClientVM, "City", false, DataSourceUpdateMode.OnValidation, "");
            comboBoxProvinces.DataBindings.Add("Text", ClientVM, "Province", false, DataSourceUpdateMode.OnValidation, "");
            maskedTextBoxPostalCode.DataBindings.Add("Text", ClientVM, "PostalCode", false, DataSourceUpdateMode.OnValidation, "");
            textBoxYTDSales.DataBindings.Add("Text", ClientVM, "YTDSales", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            checkBoxCreditHold.DataBindings.Add("Checked", ClientVM, "CreditHold");
            textBoxNotes.DataBindings.Add("Text", ClientVM, "Notes", false, DataSourceUpdateMode.OnValidation, "");
        }

        /// <summary>
        /// Method to save client when Ok button is clicked
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            string errorMessage;

            errorProviderClientDetailsDialog.SetError(buttonOk, "");

            if (ClientValidation.Validate(ClientVM.GetDisplayClient()))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                errorMessage = ClientValidation.ErrorMessage;
                errorProviderClientDetailsDialog.SetError(buttonOk, errorMessage);
            }
        }

        /// <summary>
        /// Sets the cursor postion upon mouse click 
        /// when entering maskedTextBoxClientCode
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void maskedTextBoxClientCode_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBoxClientCode.Text))
            {
                maskedTextBoxClientCode.Select(CURSOR_POSITION, CURSOR_POSITION);
            }
            else
            {
                maskedTextBoxClientCode.Select(maskedTextBoxClientCode.Text.Length, CURSOR_POSITION);
            }
        }

        /// <summary>
        /// Sets the cursor postion upon mouse click 
        /// when entering maskedTextBoxPostalCode
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void maskedTextBoxPostalCode_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBoxPostalCode.Text))
            {
                maskedTextBoxPostalCode.Select(CURSOR_POSITION, CURSOR_POSITION);
            }
            else
            {
                maskedTextBoxPostalCode.Select(maskedTextBoxPostalCode.Text.Length, CURSOR_POSITION);
            }
        }

        /// <summary>
        /// Displays a list of provinces to select in a comboBox
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void comboBoxProvinces_Enter(object sender, EventArgs e)
        {
            ProvinceCollection provinces = ClientValidation.GetProvinces();

            try
            {
                comboBoxProvinces.DataSource = provinces;
                comboBoxProvinces.DisplayMember = "Abbreviation";
                comboBoxProvinces.ValueMember = "Abbreviation";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method to check if keys are pressed in comboBoxProvince
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void comboBoxProvinces_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (keyHandled)
            {
                e.Handled = true;
            }
            else
            {
                keyHandled = false;
            }
        }

        /// <summary>
        /// Method to forces the comboBoxProvince to upper case if keys are pressed down
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void comboBoxProvinces_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
            {
                comboBoxProvinces.SelectedText = e.KeyCode.ToString().ToUpper();
                keyHandled = true;
            }
            else
            {
                keyHandled = false;
            }
        }
    }
}