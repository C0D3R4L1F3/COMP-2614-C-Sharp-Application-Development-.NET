namespace COMP2614Assign06
{
    partial class ClientDetailsDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientDetailsDialog));
            this.panelInputClientData = new System.Windows.Forms.Panel();
            this.comboBoxProvinces = new System.Windows.Forms.ComboBox();
            this.labelCreditHold = new System.Windows.Forms.Label();
            this.maskedTextBoxClientCode = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelClientCode = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.textBoxYTDSales = new System.Windows.Forms.TextBox();
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
            this.errorProviderClientDetailsDialog = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelInputClientData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClientDetailsDialog)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInputClientData
            // 
            this.panelInputClientData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInputClientData.Controls.Add(this.comboBoxProvinces);
            this.panelInputClientData.Controls.Add(this.labelCreditHold);
            this.panelInputClientData.Controls.Add(this.maskedTextBoxClientCode);
            this.panelInputClientData.Controls.Add(this.maskedTextBoxPostalCode);
            this.panelInputClientData.Controls.Add(this.buttonCancel);
            this.panelInputClientData.Controls.Add(this.labelClientCode);
            this.panelInputClientData.Controls.Add(this.buttonOk);
            this.panelInputClientData.Controls.Add(this.textBoxNotes);
            this.panelInputClientData.Controls.Add(this.textBoxYTDSales);
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
            this.panelInputClientData.Location = new System.Drawing.Point(9, 15);
            this.panelInputClientData.Margin = new System.Windows.Forms.Padding(2);
            this.panelInputClientData.Name = "panelInputClientData";
            this.panelInputClientData.Size = new System.Drawing.Size(395, 344);
            this.panelInputClientData.TabIndex = 0;
            // 
            // comboBoxProvinces
            // 
            this.comboBoxProvinces.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProvinces.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProvinces.FormattingEnabled = true;
            this.comboBoxProvinces.Location = new System.Drawing.Point(137, 127);
            this.comboBoxProvinces.Name = "comboBoxProvinces";
            this.comboBoxProvinces.Size = new System.Drawing.Size(68, 21);
            this.comboBoxProvinces.TabIndex = 11;
            this.comboBoxProvinces.Enter += new System.EventHandler(this.comboBoxProvinces_Enter);
            this.comboBoxProvinces.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxProvinces_KeyDown);
            this.comboBoxProvinces.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxProvinces_KeyPress);
            // 
            // labelCreditHold
            // 
            this.labelCreditHold.AutoSize = true;
            this.labelCreditHold.Location = new System.Drawing.Point(14, 203);
            this.labelCreditHold.Name = "labelCreditHold";
            this.labelCreditHold.Size = new System.Drawing.Size(62, 13);
            this.labelCreditHold.TabIndex = 16;
            this.labelCreditHold.Text = " C&redit Hold";
            // 
            // maskedTextBoxClientCode
            // 
            this.maskedTextBoxClientCode.Location = new System.Drawing.Point(137, 5);
            this.maskedTextBoxClientCode.Mask = ">LLLLL";
            this.maskedTextBoxClientCode.Name = "maskedTextBoxClientCode";
            this.maskedTextBoxClientCode.PromptChar = ' ';
            this.maskedTextBoxClientCode.Size = new System.Drawing.Size(68, 20);
            this.maskedTextBoxClientCode.TabIndex = 1;
            this.maskedTextBoxClientCode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxClientCode_MouseClick);
            // 
            // maskedTextBoxPostalCode
            // 
            this.maskedTextBoxPostalCode.Location = new System.Drawing.Point(137, 154);
            this.maskedTextBoxPostalCode.Mask = ">L0L 0L0";
            this.maskedTextBoxPostalCode.Name = "maskedTextBoxPostalCode";
            this.maskedTextBoxPostalCode.PromptChar = ' ';
            this.maskedTextBoxPostalCode.Size = new System.Drawing.Size(68, 20);
            this.maskedTextBoxPostalCode.TabIndex = 13;
            this.maskedTextBoxPostalCode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBoxPostalCode_MouseClick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(298, 318);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 23);
            this.buttonCancel.TabIndex = 22;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelClientCode
            // 
            this.labelClientCode.AutoSize = true;
            this.labelClientCode.Location = new System.Drawing.Point(14, 8);
            this.labelClientCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClientCode.Name = "labelClientCode";
            this.labelClientCode.Size = new System.Drawing.Size(68, 13);
            this.labelClientCode.TabIndex = 0;
            this.labelClientCode.Text = "*Client Cod&e:";
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(137, 318);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(90, 23);
            this.buttonOk.TabIndex = 21;
            this.buttonOk.Text = "&Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(137, 221);
            this.textBoxNotes.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNotes.Size = new System.Drawing.Size(251, 77);
            this.textBoxNotes.TabIndex = 19;
            // 
            // textBoxYTDSales
            // 
            this.textBoxYTDSales.Location = new System.Drawing.Point(137, 179);
            this.textBoxYTDSales.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxYTDSales.Name = "textBoxYTDSales";
            this.textBoxYTDSales.Size = new System.Drawing.Size(68, 20);
            this.textBoxYTDSales.TabIndex = 15;
            this.textBoxYTDSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(137, 102);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(251, 20);
            this.textBoxCity.TabIndex = 9;
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(137, 78);
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
            this.textBoxCompanyName.Location = new System.Drawing.Point(137, 30);
            this.textBoxCompanyName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(251, 20);
            this.textBoxCompanyName.TabIndex = 3;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(14, 224);
            this.labelNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(41, 13);
            this.labelNotes.TabIndex = 18;
            this.labelNotes.Text = " N&otes:";
            // 
            // checkBoxCreditHold
            // 
            this.checkBoxCreditHold.AutoSize = true;
            this.checkBoxCreditHold.Location = new System.Drawing.Point(137, 203);
            this.checkBoxCreditHold.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCreditHold.Name = "checkBoxCreditHold";
            this.checkBoxCreditHold.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCreditHold.TabIndex = 17;
            this.checkBoxCreditHold.UseVisualStyleBackColor = true;
            // 
            // labelYTDSales
            // 
            this.labelYTDSales.AutoSize = true;
            this.labelYTDSales.Location = new System.Drawing.Point(14, 182);
            this.labelYTDSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelYTDSales.Name = "labelYTDSales";
            this.labelYTDSales.Size = new System.Drawing.Size(110, 13);
            this.labelYTDSales.TabIndex = 14;
            this.labelYTDSales.Text = "*&Year To Date Sales: ";
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(14, 157);
            this.labelPostalCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(70, 13);
            this.labelPostalCode.TabIndex = 12;
            this.labelPostalCode.Text = " Posta&l Code:";
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(14, 130);
            this.labelProvince.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(56, 13);
            this.labelProvince.TabIndex = 10;
            this.labelProvince.Text = "*&Province:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(14, 105);
            this.labelCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(30, 13);
            this.labelCity.TabIndex = 8;
            this.labelCity.Text = " C&ity:";
            // 
            // labelAddress2
            // 
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Location = new System.Drawing.Point(14, 81);
            this.labelAddress2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(60, 13);
            this.labelAddress2.TabIndex = 6;
            this.labelAddress2.Text = " Address &2:";
            // 
            // labelAddress1
            // 
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Location = new System.Drawing.Point(14, 57);
            this.labelAddress1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(61, 13);
            this.labelAddress1.TabIndex = 4;
            this.labelAddress1.Text = "*Address &1:";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(14, 33);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(89, 13);
            this.labelCompanyName.TabIndex = 2;
            this.labelCompanyName.Text = "*Company Na&me:";
            // 
            // errorProviderClientDetailsDialog
            // 
            this.errorProviderClientDetailsDialog.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderClientDetailsDialog.ContainerControl = this;
            // 
            // ClientDetailsDialog
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(415, 370);
            this.Controls.Add(this.panelInputClientData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientDetailsDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client Details";
            this.Load += new System.EventHandler(this.ClientEditDialog_Load);
            this.panelInputClientData.ResumeLayout(false);
            this.panelInputClientData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClientDetailsDialog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInputClientData;
        private System.Windows.Forms.ComboBox comboBoxProvinces;
        private System.Windows.Forms.Label labelCreditHold;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxClientCode;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPostalCode;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelClientCode;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.TextBox textBoxYTDSales;
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
        private System.Windows.Forms.ErrorProvider errorProviderClientDetailsDialog;
    }
}