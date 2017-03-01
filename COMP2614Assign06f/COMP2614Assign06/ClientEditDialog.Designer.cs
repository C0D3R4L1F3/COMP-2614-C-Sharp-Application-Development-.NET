namespace COMP2614Assign06b
{
    partial class ClientEditDialog
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.checkBoxCreditHold = new System.Windows.Forms.CheckBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxYTDSales = new System.Windows.Forms.TextBox();
            this.labelYTDSales = new System.Windows.Forms.Label();
            this.textBoxPostalCode = new System.Windows.Forms.TextBox();
            this.labelPostalCode = new System.Windows.Forms.Label();
            this.textBoxProvince = new System.Windows.Forms.TextBox();
            this.labelProvince = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(240, 240);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 37;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(140, 240);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 36;
            this.buttonOK.Text = "&Ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // checkBoxCreditHold
            // 
            this.checkBoxCreditHold.AutoSize = true;
            this.checkBoxCreditHold.Location = new System.Drawing.Point(140, 220);
            this.checkBoxCreditHold.Name = "checkBoxCreditHold";
            this.checkBoxCreditHold.Size = new System.Drawing.Size(78, 17);
            this.checkBoxCreditHold.TabIndex = 35;
            this.checkBoxCreditHold.Text = "Credit &Hold";
            this.checkBoxCreditHold.UseVisualStyleBackColor = true;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(140, 194);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(175, 20);
            this.textBoxNotes.TabIndex = 34;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(18, 197);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(38, 13);
            this.labelNotes.TabIndex = 33;
            this.labelNotes.Text = "&Notes:";
            // 
            // textBoxYTDSales
            // 
            this.textBoxYTDSales.Location = new System.Drawing.Point(140, 168);
            this.textBoxYTDSales.Name = "textBoxYTDSales";
            this.textBoxYTDSales.Size = new System.Drawing.Size(75, 20);
            this.textBoxYTDSales.TabIndex = 32;
            this.textBoxYTDSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelYTDSales
            // 
            this.labelYTDSales.AutoSize = true;
            this.labelYTDSales.Location = new System.Drawing.Point(18, 171);
            this.labelYTDSales.Name = "labelYTDSales";
            this.labelYTDSales.Size = new System.Drawing.Size(99, 13);
            this.labelYTDSales.TabIndex = 31;
            this.labelYTDSales.Text = "&Year to Date Sales:";
            // 
            // textBoxPostalCode
            // 
            this.textBoxPostalCode.Location = new System.Drawing.Point(140, 142);
            this.textBoxPostalCode.Name = "textBoxPostalCode";
            this.textBoxPostalCode.Size = new System.Drawing.Size(50, 20);
            this.textBoxPostalCode.TabIndex = 30;
            // 
            // labelPostalCode
            // 
            this.labelPostalCode.AutoSize = true;
            this.labelPostalCode.Location = new System.Drawing.Point(18, 145);
            this.labelPostalCode.Name = "labelPostalCode";
            this.labelPostalCode.Size = new System.Drawing.Size(67, 13);
            this.labelPostalCode.TabIndex = 29;
            this.labelPostalCode.Text = "P&ostal Code:";
            // 
            // textBoxProvince
            // 
            this.textBoxProvince.Location = new System.Drawing.Point(140, 116);
            this.textBoxProvince.Name = "textBoxProvince";
            this.textBoxProvince.Size = new System.Drawing.Size(22, 20);
            this.textBoxProvince.TabIndex = 28;
            // 
            // labelProvince
            // 
            this.labelProvince.AutoSize = true;
            this.labelProvince.Location = new System.Drawing.Point(18, 119);
            this.labelProvince.Name = "labelProvince";
            this.labelProvince.Size = new System.Drawing.Size(52, 13);
            this.labelProvince.TabIndex = 27;
            this.labelProvince.Text = "&Province:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(140, 90);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(175, 20);
            this.textBoxCity.TabIndex = 26;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(18, 93);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(27, 13);
            this.labelCity.TabIndex = 25;
            this.labelCity.Text = "C&ity:";
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Location = new System.Drawing.Point(140, 64);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(175, 20);
            this.textBoxAddress2.TabIndex = 24;
            // 
            // labelAddress2
            // 
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Location = new System.Drawing.Point(18, 67);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(54, 13);
            this.labelAddress2.TabIndex = 23;
            this.labelAddress2.Text = "Address&2:";
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Location = new System.Drawing.Point(140, 38);
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(175, 20);
            this.textBoxAddress1.TabIndex = 22;
            // 
            // labelAddress1
            // 
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Location = new System.Drawing.Point(18, 41);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(54, 13);
            this.labelAddress1.TabIndex = 21;
            this.labelAddress1.Text = "Address&1:";
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(140, 12);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(175, 20);
            this.textBoxCompanyName.TabIndex = 20;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(18, 15);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(85, 13);
            this.labelCompanyName.TabIndex = 19;
            this.labelCompanyName.Text = "Comp&any Name:";
            // 
            // ClientEditDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(336, 275);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientEditDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client Edit Dialog";
            this.Load += new System.EventHandler(this.ClientEditDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.CheckBox checkBoxCreditHold;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.TextBox textBoxYTDSales;
        private System.Windows.Forms.Label labelYTDSales;
        private System.Windows.Forms.TextBox textBoxPostalCode;
        private System.Windows.Forms.Label labelPostalCode;
        private System.Windows.Forms.TextBox textBoxProvince;
        private System.Windows.Forms.Label labelProvince;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.Label labelAddress2;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.Label labelAddress1;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Label labelCompanyName;
    }
}