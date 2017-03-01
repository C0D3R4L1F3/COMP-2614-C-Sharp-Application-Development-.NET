using COMP2614Assign06c.Business;
using COMP2614Assign06c.Common;
using COMP2614Assign06c.DataAccess;
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

namespace COMP2614Assign06c
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
            textBoxClientCode.DataBindings.Add("Text", clientVM, "ClientCode", false, DataSourceUpdateMode.OnValidation, "");
            textBoxCompanyName.DataBindings.Add("Text", clientVM, "CompanyName", false, DataSourceUpdateMode.OnValidation, "");
            textBoxAddress1.DataBindings.Add("Text", clientVM, "Address1", false, DataSourceUpdateMode.OnValidation, "");
            textBoxAddress2.DataBindings.Add("Text", clientVM, "Address2", false, DataSourceUpdateMode.OnValidation, "");
            textBoxCity.DataBindings.Add("Text", clientVM, "City", false, DataSourceUpdateMode.OnValidation, "");
            textBoxProvince.DataBindings.Add("Text", clientVM, "Province", false, DataSourceUpdateMode.OnValidation, "");
            textBoxPostalCode.DataBindings.Add("Text", clientVM, "PostalCode", false, DataSourceUpdateMode.OnValidation, "");
            textBoxYTDSales.DataBindings.Add("Text", clientVM, "YTDSales", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            checkBoxCreditHold.DataBindings.Add("Checked", clientVM, "CreditHold");
            textBoxNotes.DataBindings.Add("Text", clientVM, "Notes", false, DataSourceUpdateMode.OnValidation, "");

            listBoxClients.DataSource = clientVM.Clients;
            listBoxClients.DisplayMember = "ClientCode";
        }

        /// <summary>
        /// Button to create a new client
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            clientVM.SetDisplayClient(new Client());
            textBoxClientCode.Select();
            textBoxClientCode.SelectAll();
        }

        /// <summary>
        /// Button to delete a client
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {

            if (textBoxClientCode.Text == string.Empty || listBoxClients.Text == null)
            {
                MessageBox.Show("Nothing to delete please select client code", "Select Client Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                DialogResult deleteButton;
                deleteButton = MessageBox.Show("Delete this Client?", "Delete Client Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (deleteButton == DialogResult.OK)
                {
                    try
                    {
                        Client client = clientVM.GetDisplayClient();
                        ClientValidation.DeleteClient(client);
                        clientVM.Clients = ClientValidation.GetClients();
                        listBoxClients.DataSource = clientVM.Clients;
                        listBoxClients.DisplayMember = "ClientCode";
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
                    DialogResult = DialogResult.Cancel;
                }
            }          
        }

        /// <summary>
        /// Button to save a new client or save an updated client
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxClientCode.Text.Equals(listBoxClients.Text))
            {
                UpdateMode();
            }
            else if(textBoxClientCode.Text.Equals(string.Empty))
            {
                MessageBox.Show("You must enter a Client Code", "Add Client Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                AddMode();
            }
        }

        /// <summary>
        /// Method that closes the MainForm
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// List of clients that have een updated or saved in to the database
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void listBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Math.Max(0, listBoxClients.SelectedIndex);
            Client client = clientVM.Clients[selectedIndex];
            clientVM.SetDisplayClient(client);
        }

        /// <summary>
        /// Method to update client with validations
        /// </summary>
        public void UpdateMode()
        {
            int index = listBoxClients.SelectedIndex;
            Client client = clientVM.GetDisplayClient();
            int rowsAffected = 0;
            string errorMessage;

            try
            {
                rowsAffected = ClientValidation.UpdateClient(client);

                if (rowsAffected > 0)
                {
                    clientVM.Clients = ClientValidation.GetClients();
                    listBoxClients.DataSource = clientVM.Clients;
                    listBoxClients.DisplayMember = "ClientCode";
                    listBoxClients.SelectedIndex = index;
                }
                else
                {
                    if (rowsAffected == 0)
                    {
                        errorMessage = "No DB changes were made";
                    }
                    else
                    {
                        errorMessage = ClientValidation.ErrorMessage;
                    }

                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
        /// Method to add a client with validation
        /// </summary>
        public void AddMode()
        {
            int index = listBoxClients.SelectedIndex;
            Client client = clientVM.GetDisplayClient();
            int rowsAffected = 0;
            string errorMessage;

            try
            {
                rowsAffected = ClientValidation.AddClient(client);

                if (rowsAffected > 0)
                {
                    clientVM.Clients = ClientValidation.GetClients();
                    listBoxClients.DataSource = clientVM.Clients;
                    listBoxClients.DisplayMember = "ClientCode";
                    listBoxClients.SelectedIndex = index;
                }
                else
                {
                    if (rowsAffected == 0)
                    {
                        errorMessage = "No DB changes were made";
                    }
                    else
                    {
                        errorMessage = ClientValidation.ErrorMessage;
                    }

                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    }
}