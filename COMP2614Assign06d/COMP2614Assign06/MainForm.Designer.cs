namespace COMP2614Assign06
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDateAndTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelInputClientData = new System.Windows.Forms.Panel();
            this.labelCreditHold = new System.Windows.Forms.Label();
            this.maskedTextBoxClientCode = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxProvince = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.labelClientCode = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
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
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.timerDateAndTimeDisplayMain = new System.Windows.Forms.Timer(this.components);
            this.errorProviderMain = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStripMain.SuspendLayout();
            this.panelInputClientData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus,
            this.toolStripStatusLabelDateAndTime});
            this.statusStripMain.Location = new System.Drawing.Point(0, 354);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(521, 22);
            this.statusStripMain.TabIndex = 4;
            this.statusStripMain.Text = "statusStripMain";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabelStatus.Text = "<Status>";
            // 
            // toolStripStatusLabelDateAndTime
            // 
            this.toolStripStatusLabelDateAndTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelDateAndTime.Name = "toolStripStatusLabelDateAndTime";
            this.toolStripStatusLabelDateAndTime.Size = new System.Drawing.Size(451, 17);
            this.toolStripStatusLabelDateAndTime.Spring = true;
            this.toolStripStatusLabelDateAndTime.Text = "<DateAndTime>";
            this.toolStripStatusLabelDateAndTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelInputClientData
            // 
            this.panelInputClientData.Controls.Add(this.labelCreditHold);
            this.panelInputClientData.Controls.Add(this.maskedTextBoxClientCode);
            this.panelInputClientData.Controls.Add(this.maskedTextBoxProvince);
            this.panelInputClientData.Controls.Add(this.maskedTextBoxPostalCode);
            this.panelInputClientData.Controls.Add(this.buttonDelete);
            this.panelInputClientData.Controls.Add(this.buttonNew);
            this.panelInputClientData.Controls.Add(this.labelClientCode);
            this.panelInputClientData.Controls.Add(this.buttonSave);
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
            this.panelInputClientData.Location = new System.Drawing.Point(123, 8);
            this.panelInputClientData.Margin = new System.Windows.Forms.Padding(2);
            this.panelInputClientData.Name = "panelInputClientData";
            this.panelInputClientData.Size = new System.Drawing.Size(395, 344);
            this.panelInputClientData.TabIndex = 1;
            // 
            // labelCreditHold
            // 
            this.labelCreditHold.AutoSize = true;
            this.labelCreditHold.Location = new System.Drawing.Point(14, 205);
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
            this.maskedTextBoxClientCode.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxClientCode.TabIndex = 1;
            // 
            // maskedTextBoxProvince
            // 
            this.maskedTextBoxProvince.Location = new System.Drawing.Point(137, 132);
            this.maskedTextBoxProvince.Mask = ">LL";
            this.maskedTextBoxProvince.Name = "maskedTextBoxProvince";
            this.maskedTextBoxProvince.PromptChar = ' ';
            this.maskedTextBoxProvince.Size = new System.Drawing.Size(32, 20);
            this.maskedTextBoxProvince.TabIndex = 11;
            // 
            // maskedTextBoxPostalCode
            // 
            this.maskedTextBoxPostalCode.Location = new System.Drawing.Point(137, 157);
            this.maskedTextBoxPostalCode.Mask = ">L0L 0L0";
            this.maskedTextBoxPostalCode.Name = "maskedTextBoxPostalCode";
            this.maskedTextBoxPostalCode.PromptChar = ' ';
            this.maskedTextBoxPostalCode.Size = new System.Drawing.Size(68, 20);
            this.maskedTextBoxPostalCode.TabIndex = 13;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(298, 318);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(90, 23);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNew.Location = new System.Drawing.Point(13, 318);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(90, 23);
            this.buttonNew.TabIndex = 20;
            this.buttonNew.Text = "&New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // labelClientCode
            // 
            this.labelClientCode.AutoSize = true;
            this.labelClientCode.Location = new System.Drawing.Point(14, 5);
            this.labelClientCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClientCode.Name = "labelClientCode";
            this.labelClientCode.Size = new System.Drawing.Size(68, 13);
            this.labelClientCode.TabIndex = 0;
            this.labelClientCode.Text = "*&Client Code:";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(147, 318);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 23);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(137, 226);
            this.textBoxNotes.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNotes.Size = new System.Drawing.Size(251, 77);
            this.textBoxNotes.TabIndex = 19;
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
            this.labelNotes.Location = new System.Drawing.Point(14, 226);
            this.labelNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(41, 13);
            this.labelNotes.TabIndex = 18;
            this.labelNotes.Text = " N&otes:";
            // 
            // checkBoxCreditHold
            // 
            this.checkBoxCreditHold.AutoSize = true;
            this.checkBoxCreditHold.Location = new System.Drawing.Point(137, 205);
            this.checkBoxCreditHold.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCreditHold.Name = "checkBoxCreditHold";
            this.checkBoxCreditHold.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCreditHold.TabIndex = 17;
            this.checkBoxCreditHold.UseVisualStyleBackColor = true;
            // 
            // labelYTDSales
            // 
            this.labelYTDSales.AutoSize = true;
            this.labelYTDSales.Location = new System.Drawing.Point(14, 183);
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
            this.labelProvince.Location = new System.Drawing.Point(14, 132);
            this.labelProvince.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(56, 13);
            this.labelProvince.TabIndex = 10;
            this.labelProvince.Text = "*&Province:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(14, 106);
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
            this.labelAddress1.Location = new System.Drawing.Point(14, 56);
            this.labelAddress1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(61, 13);
            this.labelAddress1.TabIndex = 4;
            this.labelAddress1.Text = "*Address &1:";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(14, 30);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(89, 13);
            this.labelCompanyName.TabIndex = 2;
            this.labelCompanyName.Text = "*Company Na&me:";
            // 
            // listBoxClients
            // 
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.Location = new System.Drawing.Point(9, 8);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.ScrollAlwaysVisible = true;
            this.listBoxClients.Size = new System.Drawing.Size(109, 342);
            this.listBoxClients.TabIndex = 0;
            this.listBoxClients.SelectedIndexChanged += new System.EventHandler(this.listBoxClients_SelectedIndexChanged);
            // 
            // timerDateAndTimeDisplayMain
            // 
            this.timerDateAndTimeDisplayMain.Tick += new System.EventHandler(this.timerDateAndTimeDisplayMain_Tick);
            // 
            // errorProviderMain
            // 
            this.errorProviderMain.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderMain.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(521, 376);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.panelInputClientData);
            this.Controls.Add(this.listBoxClients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.panelInputClientData.ResumeLayout(false);
            this.panelInputClientData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDateAndTime;
        private System.Windows.Forms.Panel panelInputClientData;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxClientCode;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxProvince;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPostalCode;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Label labelClientCode;
        private System.Windows.Forms.Button buttonSave;
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
        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.Timer timerDateAndTimeDisplayMain;
        private System.Windows.Forms.ErrorProvider errorProviderMain;
        private System.Windows.Forms.Label labelCreditHold;
    }
}

