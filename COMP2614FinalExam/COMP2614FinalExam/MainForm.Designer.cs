namespace COMP2614FinalExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTotals = new System.Windows.Forms.Label();
            this.labelLegend = new System.Windows.Forms.Label();
            this.listBoxSku = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxTaxable = new System.Windows.Forms.CheckBox();
            this.textBoxExtended = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxSku = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelExtended = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelSku = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelSKUList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTotals
            // 
            this.labelTotals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotals.AutoSize = true;
            this.labelTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotals.Location = new System.Drawing.Point(604, 16);
            this.labelTotals.Name = "labelTotals";
            this.labelTotals.Size = new System.Drawing.Size(46, 80);
            this.labelTotals.TabIndex = 15;
            this.labelTotals.Text = "one\r\ntwo\r\nthree\r\nfour";
            this.labelTotals.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLegend
            // 
            this.labelLegend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLegend.AutoSize = true;
            this.labelLegend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegend.Location = new System.Drawing.Point(492, 15);
            this.labelLegend.Name = "labelLegend";
            this.labelLegend.Size = new System.Drawing.Size(97, 80);
            this.labelLegend.TabIndex = 14;
            this.labelLegend.Text = "Sub Total:\r\nGST:\r\nPST:\r\nGrand Total:";
            this.labelLegend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxSku
            // 
            this.listBoxSku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSku.FormattingEnabled = true;
            this.listBoxSku.Location = new System.Drawing.Point(2, 18);
            this.listBoxSku.Name = "listBoxSku";
            this.listBoxSku.Size = new System.Drawing.Size(125, 199);
            this.listBoxSku.TabIndex = 1;
            this.listBoxSku.SelectedIndexChanged += new System.EventHandler(this.listBoxSku_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(376, 177);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Sa&ve";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxTaxable
            // 
            this.checkBoxTaxable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxTaxable.AutoSize = true;
            this.checkBoxTaxable.Location = new System.Drawing.Point(259, 181);
            this.checkBoxTaxable.Name = "checkBoxTaxable";
            this.checkBoxTaxable.Size = new System.Drawing.Size(64, 17);
            this.checkBoxTaxable.TabIndex = 12;
            this.checkBoxTaxable.Text = "&Taxable";
            this.checkBoxTaxable.UseVisualStyleBackColor = true;
            // 
            // textBoxExtended
            // 
            this.textBoxExtended.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExtended.Location = new System.Drawing.Point(259, 141);
            this.textBoxExtended.Name = "textBoxExtended";
            this.textBoxExtended.Size = new System.Drawing.Size(100, 20);
            this.textBoxExtended.TabIndex = 11;
            this.textBoxExtended.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrice.Location = new System.Drawing.Point(259, 108);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 9;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(259, 75);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(192, 20);
            this.textBoxDescription.TabIndex = 7;
            // 
            // textBoxSku
            // 
            this.textBoxSku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSku.Location = new System.Drawing.Point(259, 45);
            this.textBoxSku.Name = "textBoxSku";
            this.textBoxSku.Size = new System.Drawing.Size(100, 20);
            this.textBoxSku.TabIndex = 5;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuantity.Location = new System.Drawing.Point(259, 15);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxQuantity.Size = new System.Drawing.Size(49, 20);
            this.textBoxQuantity.TabIndex = 3;
            // 
            // labelExtended
            // 
            this.labelExtended.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExtended.AutoSize = true;
            this.labelExtended.Location = new System.Drawing.Point(166, 141);
            this.labelExtended.Name = "labelExtended";
            this.labelExtended.Size = new System.Drawing.Size(55, 13);
            this.labelExtended.TabIndex = 10;
            this.labelExtended.Text = "Extended:";
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(166, 111);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(34, 13);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "&Price:";
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(166, 78);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "&Description:";
            // 
            // labelSku
            // 
            this.labelSku.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSku.AutoSize = true;
            this.labelSku.Location = new System.Drawing.Point(166, 48);
            this.labelSku.Name = "labelSku";
            this.labelSku.Size = new System.Drawing.Size(29, 13);
            this.labelSku.TabIndex = 4;
            this.labelSku.Text = "S&ku:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(166, 18);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(49, 13);
            this.labelQuantity.TabIndex = 2;
            this.labelQuantity.Text = "&Quantity:";
            // 
            // labelSKUList
            // 
            this.labelSKUList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSKUList.AutoSize = true;
            this.labelSKUList.Location = new System.Drawing.Point(5, 4);
            this.labelSKUList.Name = "labelSKUList";
            this.labelSKUList.Size = new System.Drawing.Size(48, 13);
            this.labelSKUList.TabIndex = 0;
            this.labelSKUList.Text = "&SKU List";
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 219);
            this.Controls.Add(this.labelTotals);
            this.Controls.Add(this.labelLegend);
            this.Controls.Add(this.listBoxSku);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxTaxable);
            this.Controls.Add(this.textBoxExtended);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxSku);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelExtended);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelSku);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelSKUList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMP2614 Final Exam";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotals;
        private System.Windows.Forms.Label labelLegend;
        private System.Windows.Forms.ListBox listBoxSku;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxTaxable;
        private System.Windows.Forms.TextBox textBoxExtended;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxSku;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelExtended;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelSku;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelSKUList;
    }
}

