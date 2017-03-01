namespace COMP2614Assign06c
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
            this.panelInputClientData = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.textBoxClientCode = new System.Windows.Forms.TextBox();
            this.labelClientCode = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.textBoxYTDSales = new System.Windows.Forms.TextBox();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.checkBoxCreditHold = new System.Windows.Forms.CheckBox();
            this.labelYTDSales = new System.Windows.Forms.Label();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.labelProvince = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.panelInputClientData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInputClientData
            // 
            this.panelInputClientData.Controls.Add(this.buttonClose);
            this.panelInputClientData.Controls.Add(this.buttonDeleteClient);
            this.panelInputClientData.Controls.Add(this.buttonNewClient);
            this.panelInputClientData.Controls.Add(this.textBoxClientCode);
            this.panelInputClientData.Controls.Add(this.labelClientCode);
            this.panelInputClientData.Controls.Add(this.buttonSave);
            this.panelInputClientData.Controls.Add(this.textBoxNotes);
            this.panelInputClientData.Controls.Add(this.textBoxYTDSales);
            this.panelInputClientData.Controls.Add(this.textBoxPostalCode);
            this.panelInputClientData.Controls.Add(this.textBoxProvince);
            this.panelInputClientData.Controls.Add(this.textBoxCity);
            this.panelInputClientData.Controls.Add(this.textBoxAddress2);
            this.panelInputClientData.Controls.Add(this.textBoxAddress1);
            this.panelInputClientData.Controls.Add(this.textBoxCompanyName);
            this.panelInputClientData.Controls.Add(this.labelNotes);
            this.panelInputClientData.Controls.Add(this.checkBoxCreditHold);
            this.panelInputClientData.Controls.Add(this.labelYTDSales);
            this.panelInputClientData.Controls.Add(this.labelPostalCode);
            this.panelInputClientData.Controls.Add(this.labelProvince);
            this.panelInputClientData.Controls.Add(this.labelCity);
            this.panelInputClientData.Controls.Add(this.labelAddress2);
            this.panelInputClientData.Controls.Add(this.labelAddress1);
            this.panelInputClientData.Controls.Add(this.labelCompanyName);
            this.panelInputClientData.Location = new System.Drawing.Point(125, 12);
            this.panelInputClientData.Margin = new System.Windows.Forms.Padding(2);
            this.panelInputClientData.Name = "panelInputClientData";
            this.panelInputClientData.Size = new System.Drawing.Size(391, 290);
            this.panelInputClientData.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(298, 268);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(90, 20);
            this.buttonClose.TabIndex = 22;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Location = new System.Drawing.Point(204, 268);
            this.buttonDeleteClient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(90, 20);
            this.buttonDeleteClient.TabIndex = 21;
            this.buttonDeleteClient.Text = "&Delete";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Location = new System.Drawing.Point(16, 268);
            this.buttonNewClient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(90, 20);
            this.buttonNewClient.TabIndex = 19;
            this.buttonNewClient.Text = "&New Client";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            this.buttonNewClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // textBoxClientCode
            // 
            this.textBoxClientCode.Location = new System.Drawing.Point(137, 3);
            this.textBoxClientCode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxClientCode.Name = "textBoxClientCode";
            this.textBoxClientCode.Size = new System.Drawing.Size(68, 20);
            this.textBoxClientCode.TabIndex = 1;
            // 
            // labelClientCode
            // 
            this.labelClientCode.AutoSize = true;
            this.labelClientCode.Location = new System.Drawing.Point(14, 5);
            this.labelClientCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClientCode.Name = "labelClientCode";
            this.labelClientCode.Size = new System.Drawing.Size(64, 13);
            this.labelClientCode.TabIndex = 0;
            this.labelClientCode.Text = "&Client Code:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(110, 268);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 20);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(137, 205);
            this.textBoxNotes.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNotes.Size = new System.Drawing.Size(251, 47);
            this.textBoxNotes.TabIndex = 17;
            // 
            // textBoxYTDSales
            // 
            this.textBoxYTDSales.Location = new System.Drawing.Point(137, 181);
            this.textBoxYTDSales.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxYTDSales.Name = "textBoxYTDSales";
            this.textBoxYTDSales.Size = new System.Drawing.Size(68, 20);
            this.textBoxYTDSales.TabIndex = 15;
            this.textBoxYTDSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(137, 155);
            this.textBoxPostalCode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(68, 20);
            this.textBoxPostalCode.TabIndex = 13;
            // 
            // textBoxProvince
            // 
            this.textBoxProvince.Location = new System.Drawing.Point(137, 130);
            this.textBoxProvince.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(29, 20);
            this.textBoxProvince.TabIndex = 11;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(137, 105);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(251, 20);
            this.textBoxCity.TabIndex = 9;
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(137, 79);
            this.textBoxAddress2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(251, 20);
            this.textBoxAddress2.TabIndex = 7;
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Location = new System.Drawing.Point(137, 54);
            this.textBoxAddress1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(251, 20);
            this.textBoxAddress1.TabIndex = 5;
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(137, 28);
            this.textBoxCompanyName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(251, 20);
            this.textBoxCompanyName.TabIndex = 3;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(14, 208);
            this.labelNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(38, 13);
            this.labelNotes.TabIndex = 16;
            this.labelNotes.Text = "&Notes:";
            // 
            // checkBoxCreditHold
            // 
            this.checkBoxCreditHold.AutoSize = true;
            this.checkBoxCreditHold.Location = new System.Drawing.Point(16, 235);
            this.checkBoxCreditHold.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCreditHold.Name = "checkBoxCreditHold";
            this.checkBoxCreditHold.Size = new System.Drawing.Size(78, 17);
            this.checkBoxCreditHold.TabIndex = 18;
            this.checkBoxCreditHold.Text = "Credit &Hold";
            this.checkBoxCreditHold.UseVisualStyleBackColor = true;
            // 
            // labelYTDSales
            // 
            this.labelYTDSales.AutoSize = true;
            this.labelYTDSales.Location = new System.Drawing.Point(14, 183);
            this.labelYTDSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelYTDSales.Name = "labelYTDSales";
            this.labelYTDSales.Size = new System.Drawing.Size(102, 13);
            this.labelYTDSales.TabIndex = 14;
            this.labelYTDSales.Text = "&Year to Date Sales: ";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(14, 157);
            this.labelPostalCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(67, 13);
            this.labelPostalCode.TabIndex = 12;
            this.labelPostalCode.Text = "Pos&tal Code:";
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(14, 132);
            this.labelProvince.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(52, 13);
            this.labelProvince.TabIndex = 10;
            this.labelProvince.Text = "&Province:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(14, 106);
            this.labelCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(27, 13);
            this.labelCity.TabIndex = 8;
            this.labelCity.Text = "C&ity:";
            // 
            // labelAddress2
            // 
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Location = new System.Drawing.Point(14, 81);
            this.labelAddress2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(57, 13);
            this.labelAddress2.TabIndex = 6;
            this.labelAddress2.Text = "Address &2:";
            // 
            // labelAddress1
            // 
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Location = new System.Drawing.Point(14, 56);
            this.labelAddress1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(57, 13);
            this.labelAddress1.TabIndex = 4;
            this.labelAddress1.Text = "Address &1:";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(14, 30);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(85, 13);
            this.labelCompanyName.TabIndex = 2;
            this.labelCompanyName.Text = "C&ompany Name:";
            // 
            // listBoxClients
            // 
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.Location = new System.Drawing.Point(11, 12);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(109, 290);
            this.listBoxClients.TabIndex = 0;
            this.listBoxClients.SelectedIndexChanged += new System.EventHandler(this.listBoxClients_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonNewClient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 315);
            this.Controls.Add(this.panelInputClientData);
            this.Controls.Add(this.listBoxClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelInputClientData.ResumeLayout(false);
            this.panelInputClientData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInputClientData;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Button buttonNewClient;
        private System.Windows.Forms.TextBox textBoxClientCode;
        private System.Windows.Forms.Label labelClientCode;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.TextBox textBoxYTDSales;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.TextBox textBoxProvince;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.CheckBox checkBoxCreditHold;
        private System.Windows.Forms.Label labelYTDSales;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.Label labelProvince;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelAddress2;
        private System.Windows.Forms.Label labelAddress1;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.Button buttonClose;
    }
}

