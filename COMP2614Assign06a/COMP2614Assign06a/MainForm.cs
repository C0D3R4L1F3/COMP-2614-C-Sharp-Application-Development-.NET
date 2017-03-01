using COMP2614Assign06a.Common;
using COMP2614Assign06a.DataAccess;
using COMP2614Assign06a.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign06a
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
            clientVM = new ClientViewModel(ClientRepository.GetClients());
            setBindings();
            setupDataGridView();
        }

        /// <summary>
        /// Sets the binding for a client object
        /// </summary>
        private void setBindings()
        {

            textBoxCompanyName.DataBindings.Add("Text", clientVM, "CompanyName", false, DataSourceUpdateMode.OnValidation, "");
            textBoxAddress1.DataBindings.Add("Text", clientVM, "Address1", false, DataSourceUpdateMode.OnValidation, "");
            textBoxAddress2.DataBindings.Add("Text", clientVM, "Address2", false, DataSourceUpdateMode.OnValidation, "");
            textBoxCity.DataBindings.Add("Text", clientVM, "City", false, DataSourceUpdateMode.OnValidation, "");
            textBoxProvince.DataBindings.Add("Text", clientVM, "Province", false, DataSourceUpdateMode.OnValidation, "");
            textBoxPostalCode.DataBindings.Add("Text", clientVM, "PostalCode", false, DataSourceUpdateMode.OnValidation, "");
            textBoxYTDSales.DataBindings.Add("Text", clientVM, "YTDSales", false, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            checkBoxCreditHold.DataBindings.Add("Checked", clientVM, "CreditHold");
            textBoxNotes.DataBindings.Add("Text", clientVM, "Notes", false, DataSourceUpdateMode.OnValidation, "");

            //textBoxCompanyName.DataBindings.Add("Text", clientVM, "CompanyName");
            //textBoxAddress1.DataBindings.Add("Text", clientVM, "Address1");
            //textBoxAddress2.DataBindings.Add("Text", clientVM, "Address2");
            //textBoxCity.DataBindings.Add("Text", clientVM, "City");
            //textBoxProvince.DataBindings.Add("Text", clientVM, "Province");
            //textBoxPostalCode.DataBindings.Add("Text", clientVM, "PostalCode");
            //textBoxYTDSales.DataBindings.Add("Text", clientVM, "YTDSales", true, DataSourceUpdateMode.OnValidation, "0.00", "#,##0.00;(#,##0.00);0.00");
            //checkBoxCreditHold.DataBindings.Add("Checked", clientVM, "CreditHold");
            //textBoxNotes.DataBindings.Add("Text", clientVM, "Notes");

            dataGridViewClients.AutoGenerateColumns = false;
            dataGridViewClients.DataSource = clientVM.Clients;
        }

        /// <summary>
        /// Method to set up the data grid
        /// </summary>
        private void setupDataGridView()
        {
            // configure for readonly 
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.MultiSelect = false;
            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewClients.AllowUserToOrderColumns = false;
            dataGridViewClients.AllowUserToResizeColumns = false;
            dataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridViewClients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewClients.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            // add columns
            DataGridViewTextBoxColumn companyName = new DataGridViewTextBoxColumn();
            companyName.Name = "companyName";
            companyName.DataPropertyName = "CompanyName";
            companyName.HeaderText = "Company Name";
            companyName.Width = 200;
            companyName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            companyName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            companyName.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(companyName);

            DataGridViewTextBoxColumn address1 = new DataGridViewTextBoxColumn();
            address1.Name = "address1";
            address1.DataPropertyName = "Address1";
            address1.HeaderText = "Address1";
            address1.Width = 200;
            address1.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            address1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            address1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(address1);

            DataGridViewTextBoxColumn address2 = new DataGridViewTextBoxColumn();
            address2.Name = "address2";
            address2.DataPropertyName = "Address2";
            address2.HeaderText = "Address2";
            address2.Width = 200;
            address2.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            address2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            address2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(address2);

            DataGridViewTextBoxColumn city = new DataGridViewTextBoxColumn();
            city.Name = "City";
            city.DataPropertyName = "City";
            city.HeaderText = "City";
            city.Width = 100;
            city.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            city.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            city.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(city);

            DataGridViewTextBoxColumn province = new DataGridViewTextBoxColumn();
            province.Name = "province";
            province.DataPropertyName = "Province";
            province.HeaderText = "Province";
            province.Width = 100;
            province.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            province.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            province.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(province);

            DataGridViewTextBoxColumn postalCode = new DataGridViewTextBoxColumn();
            postalCode.Name = "postalCode";
            postalCode.DataPropertyName = "PostalCode";
            postalCode.HeaderText = "Postal Code";
            postalCode.Width = 100;
            postalCode.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            postalCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            postalCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(postalCode);

            DataGridViewTextBoxColumn ytdSales = new DataGridViewTextBoxColumn();
            ytdSales.Name = "ytdSales";
            ytdSales.DataPropertyName = "YTDSales";
            ytdSales.HeaderText = "YTD Sales";
            ytdSales.Width = 100;
            ytdSales.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ytdSales.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            ytdSales.DefaultCellStyle.Format = "N2";
            ytdSales.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(ytdSales);

            DataGridViewCheckBoxColumn creditHold = new DataGridViewCheckBoxColumn();
            creditHold.Name = "creditHold";
            creditHold.DataPropertyName = "CreditHold";
            creditHold.HeaderText = "Credit Hold";
            creditHold.Width = 100;
            creditHold.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(creditHold);

            DataGridViewTextBoxColumn notes = new DataGridViewTextBoxColumn();
            notes.Name = "notes";
            notes.DataPropertyName = "Notes";
            notes.HeaderText = "Notes";
            notes.Width = 200;
            notes.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            notes.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(notes);
        }

        /// <summary>
        /// Method that confirms the changes made to client
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void dataGridViewClients_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridViewClients.CurrentRow.Index;

            Client client = clientVM.Clients[index];
            clientVM.SetDisplayClient(client);
            labelClientLegend.Text = string.Empty;
            labelClientData.Text = string.Empty;
        }

        /// <summary>
        /// Method that saves the changes made to client
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            int index = dataGridViewClients.CurrentRow.Index;
            Client client = clientVM.SaveClient(index);
            clientVM.Clients.ResetItem(index);
            string outputData;

            string outputLegend = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n{6}\r\n{7}\r\n{8}\r\n"
                                        , "Company Name:"
                                        , "Address1:"
                                        , "Address2:"
                                        , "City:"
                                        , "Province:"
                                        , "Postal Code:"
                                        , "Year to Date Sales:"
                                        , "Credit Hold:"
                                        , "Notes:");

            if (client.CreditHold == true)
            {
                outputData = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n{6}\r\n{7}\r\n{8}\r\n"
                                   , client.CompanyName
                                   , client.Address1
                                   , client.Address2
                                   , client.City
                                   , client.Province
                                   , client.PostalCode
                                   , client.YTDSales
                                   , "Yes"
                                   , client.Notes);
            }
            else
            {
                outputData = string.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n{6}\r\n{7}\r\n{8}\r\n"
                                   , client.CompanyName
                                   , client.Address1
                                   , client.Address2
                                   , client.City
                                   , client.Province
                                   , client.PostalCode
                                   , client.YTDSales
                                   , "No"
                                   , client.Notes);
            }

            labelClientLegend.Text = outputLegend;
            labelClientData.Text = outputData;
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
        /// Method that selects all the characters in a textBox when
        /// entered via tab, or mnemonic 
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void textBoxCompanyName_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }
    }
}