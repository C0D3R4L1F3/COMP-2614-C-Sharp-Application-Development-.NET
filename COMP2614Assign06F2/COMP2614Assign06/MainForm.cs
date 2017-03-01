using BusinessLibrary.Business;
using BusinessLibrary.Common;
using BusinessLibrary.DataAccess;
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
    /// Class that contains MainForm methods
    /// </summary>
    public partial class MainForm : Form
    {
        private ClientViewModel clientVM;

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
            try
            {
                clientVM = new ClientViewModel(ClientRepository.GetClients());
                setBindings();
                toolStripStatusLabelStatus.Text = string.Empty;
                timerDateAndTimeDisplayMain.Start();
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
        /// Sets the binding for a client object
        /// </summary>
        private void setBindings()
        {
            maskedTextBoxClientCode.DataBindings.Add("Text", clientVM, "ClientCode", false, DataSourceUpdateMode.OnValidation, "");
            textBoxCompanyName.DataBindings.Add("Text", clientVM, "CompanyName", false, DataSourceUpdateMode.OnValidation, "");
            textBoxAddress1.DataBindings.Add("Text", clientVM, "Address1", false, DataSourceUpdateMode.OnValidation, "");
            textBoxAddress2.DataBindings.Add("Text", clientVM, "Address2", false, DataSourceUpdateMode.OnValidation, "");
            textBoxCity.DataBindings.Add("Text", clientVM, "City", false, DataSourceUpdateMode.OnValidation, "");
            comboBoxProvinces.DataBindings.Add("Text", clientVM, "Province", false, DataSourceUpdateMode.OnValidation, "");
            maskedTextBoxPostalCode.DataBindings.Add("Text", clientVM, "PostalCode", false, DataSourceUpdateMode.OnValidation, "");
            textBoxYTDSales.DataBindings.Add("Text", clientVM, "YTDSales", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            checkBoxCreditHold.DataBindings.Add("Checked", clientVM, "CreditHold");
            textBoxNotes.DataBindings.Add("Text", clientVM, "Notes", false, DataSourceUpdateMode.OnValidation, "");

            listBoxClients.DataSource = clientVM.Clients;
            listBoxClients.DisplayMember = "ClientCode";
        }

        /// <summary>
        /// List of clients that have been updated or saved in to the database
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void listBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Math.Max(0, listBoxClients.SelectedIndex);
            Client client = clientVM.Clients[selectedIndex];
            clientVM.SetDisplayClient(client);
            toolStripStatusLabelStatus.Text = string.Empty;
            errorProviderMain.Clear();
        }

        /// <summary>
        /// Displays a TotalsForm if buttonTotals clicked
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonTotals_Click(object sender, EventArgs e)
        {
            TotalsForm dlg = new TotalsForm();

            dlg.ShowDialog();
            dlg.Dispose();
        }

        /// <summary>
        /// Button to create a new client
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonNew_Click(object sender, EventArgs e)
        {
            errorProviderMain.Clear();
            clientVM.SetDisplayClient(new Client());
            maskedTextBoxClientCode.Select();
            maskedTextBoxClientCode.SelectAll();
        }

        /// <summary>
        /// Button to save a new client or save an updated client
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Validates the toolStripButtonSave and the saveToolStripMenuItem
            // If not here will not save properly if toolStripButtonSave 
            // and saveToolStripMenutItem is used instead of buttonSave
            this.Validate();

            if (maskedTextBoxClientCode.Text.Equals(clientVM.ClientCode) && maskedTextBoxClientCode.Text.Equals(listBoxClients.Text))
            {
                updateMode();
            }
            else
            {
                addMode();
            }
        }

        /// <summary>
        /// Button to delete a client or entered data
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBoxClientCode.Text))
            {
                MessageBox.Show("Nothing to delete please select Client Code or create a new Client", "Select Client Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                toolStripStatusLabelStatus.Text = "No Client selected to delete";
            }
            else if (maskedTextBoxClientCode.Text.Length <= 5 && !maskedTextBoxClientCode.Text.Equals(listBoxClients.Text))
            {
                DialogResult result = MessageBox.Show("Do you want to delete data entered in text fields?", "Delete Data Entered", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    toolStripStatusLabelStatus.Text = "Data entered deleted";
                    clearTextboxes();
                    maskedTextBoxClientCode.Focus();
                }
                else
                {
                    toolStripStatusLabelStatus.Text = "Data entered has not been deleted";
                }
            }

            if (maskedTextBoxClientCode.Text.Equals(listBoxClients.Text))
            {
                // Confirmation string creation
                string message = string.Format("{0} {1} {2}"
                                               , "Do you want to delete Client '"
                                               , clientVM.ClientCode.Trim()
                                               , "'? \r\nThis operation cannot be undone.");
                string caption = "Delete Client";

                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Client client = clientVM.GetDisplayClient();
                        ClientValidation.DeleteClient(client);
                        clientVM.Clients = ClientValidation.GetClients();
                        listBoxClients.DataSource = clientVM.Clients;
                        listBoxClients.DisplayMember = "ClientCode";
                        toolStripStatusLabelStatus.Text = "Client successfully deleted";
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
                else
                {
                    toolStripStatusLabelStatus.Text = "Client has not been deleted";
                }
            }
        }

        /// <summary>
        /// Method to update client with validations
        /// </summary>
        private void updateMode()
        {
            int index = listBoxClients.SelectedIndex;
            Client client = clientVM.GetDisplayClient();
            int rowsAffected = 0;
            string errorMessage;

            //Confirmation string creation
            string message = string.Format("{0} {1} {2}"
                                           , "Do you want to update Client '"
                                           , clientVM.ClientCode.Trim()
                                           , "'? \r\nThis operation cannot be undone.");
            string caption = "Update Client";

            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    rowsAffected = ClientValidation.UpdateClient(client);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (rowsAffected > 0)
                {
                    clientVM.Clients = ClientValidation.GetClients();
                    listBoxClients.DataSource = clientVM.Clients;
                    listBoxClients.DisplayMember = "ClientCode";
                    listBoxClients.SelectedIndex = index;
                    toolStripStatusLabelStatus.Text = "Client successfully updated";
                }
                else
                {
                    errorProviderMain.Clear();

                    if (rowsAffected == 0)
                    {
                        errorMessage = "No DB changes were made";
                    }
                    else
                    {
                        errorMessage = ClientValidation.ErrorMessage;
                    }

                    errorProviderMain.SetError(buttonSave, errorMessage);
                    toolStripStatusLabelStatus.Text = "Client has not been updated";
                }
            }
            else
            {
                toolStripStatusLabelStatus.Text = "Client has not been updated";
            }
        }

        /// <summary>
        /// Method to add a client with validation
        /// </summary>
        private void addMode()
        {
            int index = listBoxClients.SelectedIndex;
            Client client = clientVM.GetDisplayClient();
            int rowsAffected = 0;
            string errorMessage;

            try
            {
                rowsAffected = ClientValidation.AddClient(client);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (rowsAffected > 0)
            {
                clientVM.Clients = ClientValidation.GetClients();
                listBoxClients.DataSource = clientVM.Clients;
                listBoxClients.DisplayMember = "ClientCode";
                listBoxClients.SelectedIndex = index;
                toolStripStatusLabelStatus.Text = "Client successfully added";
            }
            else
            {
                errorProviderMain.Clear();

                if (rowsAffected == 0)
                {
                    errorMessage = "No DB changes were made";
                }
                else
                {
                    errorMessage = ClientValidation.ErrorMessage;
                }

                errorProviderMain.SetError(buttonSave, errorMessage);
                toolStripStatusLabelStatus.Text = "Client has not been added";
            }
        }

        /// <summary>
        /// Displays the date and time 
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void timerDateAndTimeDisplayMain_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelDateAndTime.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy  h:mm:ss tt");
        }

        /// <summary>
        /// Displays toolbar if it is clicked
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void toolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolbarToolStripMenuItem.Checked)
            {
                toolStripMain.Visible = true;
            }
            else
            {
                toolStripMain.Visible = false;
            }
        }

        /// <summary>
        /// Displays a list of provinces to select in a comboBox
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void comboBoxProvinces_Click(object sender, EventArgs e)
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
        /// Sets the cursor postion upon mouse click 
        /// when entering maskedTextBoxClientCode_MouseClick
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void maskedTextBoxClientCode_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBoxClientCode.Text))
            {
                maskedTextBoxClientCode.Select(0, 0);
            }
            else
            {
                maskedTextBoxClientCode.Select(maskedTextBoxClientCode.Text.Length, 0);
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
                maskedTextBoxPostalCode.Select(0, 0);
            }
            else
            {
                maskedTextBoxPostalCode.Select(maskedTextBoxPostalCode.Text.Length, 0);
            }
        }

        /// <summary>
        /// Clears all the values in the textboxes
        /// </summary>
        private void clearTextboxes()
        {
            maskedTextBoxClientCode.Clear();
            textBoxCompanyName.Clear();
            textBoxAddress1.Clear();
            textBoxAddress2.Clear();
            textBoxCity.Clear();
            comboBoxProvinces.SelectedItem = null;
            maskedTextBoxPostalCode.Clear();
            textBoxYTDSales.Clear();
            checkBoxCreditHold.Checked = false;
            textBoxNotes.Clear();
        }

        /// <summary>
        /// Display about information creator of Form
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By: Ronnie Manimtim COMP2614Assign06", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Method to exit the application
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}