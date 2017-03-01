using DataLayer.Business;
using DataLayer.Common;
using DataLayer.DataAccess;
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
            maskedTextBoxProvince.DataBindings.Add("Text", clientVM, "Province", false, DataSourceUpdateMode.OnValidation, "");
            maskedTextBoxPostalCode.DataBindings.Add("Text", clientVM, "PostalCode", false, DataSourceUpdateMode.OnValidation, "");
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
        private void buttonNew_Click(object sender, EventArgs e)
        {
            clientVM.SetDisplayClient(new Client());
            maskedTextBoxClientCode.Select();
            maskedTextBoxClientCode.SelectAll();
        }

        /// <summary>
        /// Button to delete a client
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxClientCode.Text == string.Empty || maskedTextBoxClientCode.Text.Length < 5 || listBoxClients.Text == null)
            {
                MessageBox.Show("Nothing to delete please select client code", "Select Client Code", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                toolStripStatusLabelStatus.Text = "No Client selected to delete";
            }
            else
            {
                //Cofnirmation string creation
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
                        errorProviderMain.Clear();                        
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
        /// Button to save a new client or save an updated client
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            errorProviderMain.Clear();
             
            if (maskedTextBoxClientCode.Text.Equals(listBoxClients.Text))
            {
                UpdateMode();
            }
            else if (maskedTextBoxClientCode.Text.Equals(string.Empty))
            {
                MessageBox.Show("You must enter a Client Code", "Add Client Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedTextBoxClientCode.Select();
                maskedTextBoxClientCode.SelectAll();
            }
            else
            {
                AddMode();
            }
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
            errorProviderMain.Clear();

            //Cofnirmation string creation
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
        public void AddMode()
        {
            int index = listBoxClients.SelectedIndex;
            Client client = clientVM.GetDisplayClient();
            int rowsAffected = 0;
            string errorMessage;
            errorProviderMain.Clear();

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
        /// Display about information creator of Form
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By: Ronnie Manimtim COMP2614 Assignment 6", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            toolStripStatusLabelStatus.Text = string.Empty;
            errorProviderMain.Clear();
        }

        /// <summary>
        /// Method to exit the application
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}