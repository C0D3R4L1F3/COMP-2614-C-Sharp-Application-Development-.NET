namespace COMP2614Assign06a
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelProvince = new System.Windows.Forms.Label();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.labelYTDSales = new System.Windows.Forms.Label();
            this.textBoxYTDSales = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.checkBoxCreditHold = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.labelClientLegend = new System.Windows.Forms.Label();
            this.labelClientData = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(32, 57);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(85, 13);
            this.labelCompanyName.TabIndex = 0;
            this.labelCompanyName.Text = "Comp&any Name:";
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(154, 54);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(175, 20);
            this.textBoxCompanyName.TabIndex = 1;
            this.textBoxCompanyName.Enter += new System.EventHandler(this.textBoxCompanyName_Enter);
            // 
            // labelAddress1
            // 
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Location = new System.Drawing.Point(32, 83);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(54, 13);
            this.labelAddress1.TabIndex = 2;
            this.labelAddress1.Text = "Address&1:";
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Location = new System.Drawing.Point(154, 80);
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(175, 20);
            this.textBoxAddress1.TabIndex = 3;
            this.textBoxAddress1.Enter += new System.EventHandler(this.textBoxCompanyName_Enter);
            // 
            // labelAddress2
            // 
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Location = new System.Drawing.Point(32, 109);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(54, 13);
            this.labelAddress2.TabIndex = 4;
            this.labelAddress2.Text = "Address&2:";
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(154, 106);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(175, 20);
            this.textBoxAddress2.TabIndex = 5;
            this.textBoxAddress2.Enter += new System.EventHandler(this.textBoxCompanyName_Enter);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(32, 135);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(27, 13);
            this.labelCity.TabIndex = 6;
            this.labelCity.Text = "C&ity:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(154, 132);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(175, 20);
            this.textBoxCity.TabIndex = 7;
            this.textBoxCity.Enter += new System.EventHandler(this.textBoxCompanyName_Enter);
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(32, 161);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(52, 13);
            this.labelProvince.TabIndex = 8;
            this.labelProvince.Text = "&Province:";
            // 
            // textBoxProvince
            // 
            this.textBoxProvince.Location = new System.Drawing.Point(154, 158);
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(22, 20);
            this.textBoxProvince.TabIndex = 9;
            this.textBoxProvince.Enter += new System.EventHandler(this.textBoxCompanyName_Enter);
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(32, 187);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(67, 13);
            this.labelPostalCode.TabIndex = 10;
            this.labelPostalCode.Text = "P&ostal Code:";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(154, 184);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(50, 20);
            this.textBoxPostalCode.TabIndex = 11;
            this.textBoxPostalCode.Enter += new System.EventHandler(this.textBoxCompanyName_Enter);
            // 
            // labelYTDSales
            // 
            this.labelYTDSales.AutoSize = true;
            this.labelYTDSales.Location = new System.Drawing.Point(32, 213);
            this.labelYTDSales.Name = "labelYTDSales";
            this.labelYTDSales.Size = new System.Drawing.Size(99, 13);
            this.labelYTDSales.TabIndex = 12;
            this.labelYTDSales.Text = "&Year to Date Sales:";
            // 
            // textBoxYTDSales
            // 
            this.textBoxYTDSales.Location = new System.Drawing.Point(154, 210);
            this.textBoxYTDSales.Name = "textBoxYTDSales";
            this.textBoxYTDSales.Size = new System.Drawing.Size(75, 20);
            this.textBoxYTDSales.TabIndex = 13;
            this.textBoxYTDSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxYTDSales.EnabledChanged += new System.EventHandler(this.textBoxCompanyName_Enter);
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(32, 239);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(38, 13);
            this.labelNotes.TabIndex = 14;
            this.labelNotes.Text = "&Notes:";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(154, 236);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(175, 20);
            this.textBoxNotes.TabIndex = 15;
            this.textBoxNotes.EnabledChanged += new System.EventHandler(this.textBoxCompanyName_Enter);
            // 
            // checkBoxCreditHold
            // 
            this.checkBoxCreditHold.AutoSize = true;
            this.checkBoxCreditHold.Location = new System.Drawing.Point(35, 271);
            this.checkBoxCreditHold.Name = "checkBoxCreditHold";
            this.checkBoxCreditHold.Size = new System.Drawing.Size(78, 17);
            this.checkBoxCreditHold.TabIndex = 16;
            this.checkBoxCreditHold.Text = "Credit &Hold";
            this.checkBoxCreditHold.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(154, 262);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(35, 306);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(763, 275);
            this.dataGridViewClients.TabIndex = 19;
            this.dataGridViewClients.SelectionChanged += new System.EventHandler(this.dataGridViewClients_SelectionChanged);
            // 
            // labelClientLegend
            // 
            this.labelClientLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientLegend.Location = new System.Drawing.Point(453, 54);
            this.labelClientLegend.Name = "labelClientLegend";
            this.labelClientLegend.Size = new System.Drawing.Size(111, 202);
            this.labelClientLegend.TabIndex = 20;
            this.labelClientLegend.Text = "CompanyName\r\nAddress1\r\nAddress2\r\nCity\r\nProvince\r\nPostalCode\r\nYTDSales\r\nCreditHold" +
    "\r\nNotes";
            // 
            // labelClientData
            // 
            this.labelClientData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientData.Location = new System.Drawing.Point(563, 54);
            this.labelClientData.Name = "labelClientData";
            this.labelClientData.Size = new System.Drawing.Size(235, 198);
            this.labelClientData.TabIndex = 21;
            this.labelClientData.Text = "CompanyName\r\nAddress1\r\nAddress2\r\nCity\r\nProvince\r\nPostalCode\r\nYTDSales\r\nCreditHold" +
    "\r\nNotes";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(254, 262);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 18;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 610);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelClientData);
            this.Controls.Add(this.labelClientLegend);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxCreditHold);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.textBoxYTDSales);
            this.Controls.Add(this.labelYTDSales);
            this.Controls.Add(this.textBoxPostalCode);
            this.Controls.Add(this.labelPostalCode);
            this.Controls.Add(this.textBoxProvince);
            this.Controls.Add(this.labelProvince);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textBoxAddress2);
            this.Controls.Add(this.labelAddress2);
            this.Controls.Add(this.textBoxAddress1);
            this.Controls.Add(this.labelAddress1);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.labelCompanyName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Label labelAddress1;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.Label labelAddress2;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelProvince;
        private System.Windows.Forms.TextBox textBoxProvince;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.Label labelYTDSales;
        private System.Windows.Forms.TextBox textBoxYTDSales;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.CheckBox checkBoxCreditHold;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Label labelClientLegend;
        private System.Windows.Forms.Label labelClientData;
        private System.Windows.Forms.Button buttonClose;
    }
}

