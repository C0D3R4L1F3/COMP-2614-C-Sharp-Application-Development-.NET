using COMP2614Assign06b.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2614Assign06b
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
        /// Method that opens a ClientEditDialog
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void dataGridViewClients_DoubleClick(object sender, EventArgs e)
        {
            int index = dataGridViewClients.CurrentRow.Index;
            clientVM.SetDisplayClient(clientVM.Clients[index]);

            ClientEditDialog dlg = new ClientEditDialog();
            dlg.ClientVM = clientVM;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                clientVM.SaveClient(index);
                clientVM.Clients.ResetItem(index);
            }

            dlg.Dispose();
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
    }
}