using BusinessLibrary.Business;
using BusinessLibrary.Common;
using BusinessLibrary.DataAccess;
using COMP2614Assign06;
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
                setupDataGridView();
                timerDateAndTimeMainForm.Start();
                toolStripStatusMainLabelStatus.Text = string.Empty;
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
            dataGridViewClients.AutoGenerateColumns = false;
            dataGridViewClients.DataSource = clientVM.Clients;
        }

        /// <summary>
        /// Method to set up the data grid
        /// </summary>
        private void setupDataGridView()
        {
            dataGridViewClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClients.MultiSelect = false;
            dataGridViewClients.AllowUserToAddRows = false;
            dataGridViewClients.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewClients.AllowUserToOrderColumns = false;
            dataGridViewClients.AllowUserToResizeColumns = false;
            dataGridViewClients.AllowUserToResizeRows = false;
            dataGridViewClients.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            var clientCode = new DataGridViewTextBoxColumn();
            clientCode.Name = "clientCode";
            clientCode.DataPropertyName = "ClientCode";
            clientCode.HeaderText = "Client Code";
            clientCode.Width = 80;
            clientCode.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            clientCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            clientCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(clientCode);

            var companyName = new DataGridViewTextBoxColumn();
            companyName.Name = "companyName";
            companyName.DataPropertyName = "CompanyName";
            companyName.HeaderText = "Company";
            companyName.Width = 140;
            companyName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            companyName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            companyName.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(companyName);

            var address1 = new DataGridViewTextBoxColumn();
            address1.Name = "address1";
            address1.DataPropertyName = "Address1";
            address1.HeaderText = "Address 1";
            address1.Width = 140;
            address1.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            address1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            address1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(address1);

            var address2 = new DataGridViewTextBoxColumn();
            address2.Name = "address2";
            address2.DataPropertyName = "Address2";
            address2.HeaderText = "Address 2";
            address2.Width = 140;
            address2.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            address2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            address2.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(address2);

            var city = new DataGridViewTextBoxColumn();
            city.Name = "city";
            city.DataPropertyName = "City";
            city.HeaderText = "City";
            city.Width = 100;
            city.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            city.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            city.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(city);

            var province = new DataGridViewTextBoxColumn();
            province.Name = "province";
            province.DataPropertyName = "Province";
            province.HeaderText = "Province";
            province.Width = 60;
            province.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            province.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            province.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(province);

            var postalCode = new DataGridViewTextBoxColumn();
            postalCode.Name = "postalCode";
            postalCode.DataPropertyName = "PostalCode";
            postalCode.HeaderText = "Postal Code";
            postalCode.Width = 80;
            postalCode.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            postalCode.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            postalCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(postalCode);

            var yTDSales = new DataGridViewTextBoxColumn();
            yTDSales.Name = "yTDSales";
            yTDSales.DataPropertyName = "YTDSales";
            yTDSales.HeaderText = "YTD Sales";
            yTDSales.Width = 80;
            yTDSales.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            yTDSales.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            yTDSales.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(yTDSales);

            var creditHold = new DataGridViewCheckBoxColumn();
            creditHold.Name = "creditHold";
            creditHold.DataPropertyName = "CreditHold";
            creditHold.HeaderText = "Hold";
            creditHold.Width = 40;
            creditHold.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(creditHold);

            var notes = new DataGridViewTextBoxColumn();
            notes.Name = "notes";
            notes.DataPropertyName = "Notes";
            notes.HeaderText = "Notes";
            notes.Width = 160;
            notes.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            notes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            notes.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewClients.Columns.Add(notes);
        }

        /// <summary>
        /// Displays a TotalsForm if buttonTotals clicked
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonTotals_Click(object sender, EventArgs e)
        {
            TotalsDialog dlg = TotalsDialog.CreateForm();

            dlg.Show();
            dlg.Activate();
        }

        /// <summary>
        /// Button to create a new client
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = new Client();
                clientVM.SetDisplayClient(client);
                var dlg = new ClientDetailsDialog();
                dlg.ClientVM = clientVM;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ClientValidation.AddClient(clientVM.GetDisplayClient());
                    clientVM.Clients = ClientValidation.GetClients();
                    dataGridViewClients.DataSource = clientVM.Clients;
                    toolStripStatusMainLabelStatus.Text = "Client successfully added.";
                }
                else
                {
                    toolStripStatusMainLabelStatus.Text = "Client has not been added.";
                }

                dlg.Dispose();
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
        /// Method that opens a ClientDetailsDialog
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void dataGridViewClients_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridViewClients.CurrentRow.Index;
                clientVM.SetDisplayClient(clientVM.Clients[index]);
                var dlg = new ClientDetailsDialog();
                dlg.ClientVM = clientVM;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ClientValidation.UpdateClient(clientVM.GetDisplayClient());
                    clientVM.Clients = ClientValidation.GetClients();
                    clientVM.Clients.ResetItem(index);
                    dataGridViewClients.DataSource = clientVM.Clients;
                    toolStripStatusMainLabelStatus.Text = "Client successfully edited.";
                }
                else
                {
                    DialogResult result = MessageBox.Show("You are about to leave Edit Client Details Dialog without saving.\r\nWould you like to save edited Client details?", "Edit Client", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        ClientValidation.UpdateClient(clientVM.GetDisplayClient());
                        clientVM.Clients = ClientValidation.GetClients();
                        clientVM.Clients.ResetItem(index);
                        dataGridViewClients.DataSource = clientVM.Clients;
                        toolStripStatusMainLabelStatus.Text = "Client successfully edited.";
                    }
                    else
                    {
                        toolStripStatusMainLabelStatus.Text = "Client has not been edited.";
                    }
                }

                dlg.Dispose();
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
        /// Button to delete a client
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.Text.Equals(dataGridViewClients.Text))
            {
                DialogResult result = MessageBox.Show("Delete selected Client?\r\nThis operation cannot be undone.", "Delete Client", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int index = dataGridViewClients.CurrentRow.Index;
                        ClientValidation.DeleteClient(clientVM.Clients[index]);
                        clientVM.Clients = ClientValidation.GetClients();
                        dataGridViewClients.DataSource = clientVM.Clients;
                        toolStripStatusMainLabelStatus.Text = "Client successfully deleted.";
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
                    toolStripStatusMainLabelStatus.Text = "Client has not been deleted.";
                }
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
        /// Displays the date and time 
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            toolStripStatusMainLabelDateAndTime.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy  h:mm:ss tt");
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
                toolStripMainForm.Visible = true;
            }
            else
            {
                toolStripMainForm.Visible = false;
            }
        }

        /// <summary>
        /// Display about information creator of Form
        /// </summary>
        /// <param name="sender">the control/object to set</param>
        /// <param name="e">the event data to set</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By: Ronnie Manimtim COMP2614Assign06.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}