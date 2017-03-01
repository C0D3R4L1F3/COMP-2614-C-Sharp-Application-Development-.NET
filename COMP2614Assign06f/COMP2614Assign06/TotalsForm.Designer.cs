namespace COMP2614Assign06f
{
    partial class TotalsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalsForm));
            this.labelTotalYTDSales = new System.Windows.Forms.Label();
            this.textBoxTotalYTDSales = new System.Windows.Forms.TextBox();
            this.labelCreditHoldCount = new System.Windows.Forms.Label();
            this.textBoxCreditHoldCount = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTotalYTDSales
            // 
            this.labelTotalYTDSales.AutoSize = true;
            this.labelTotalYTDSales.Location = new System.Drawing.Point(30, 40);
            this.labelTotalYTDSales.Name = "labelTotalYTDSales";
            this.labelTotalYTDSales.Size = new System.Drawing.Size(130, 13);
            this.labelTotalYTDSales.TabIndex = 0;
            this.labelTotalYTDSales.Text = "Total Year To Date Sales:";
            // 
            // textBoxTotalYTDSales
            // 
            this.textBoxTotalYTDSales.Location = new System.Drawing.Point(175, 37);
            this.textBoxTotalYTDSales.Name = "textBoxTotalYTDSales";
            this.textBoxTotalYTDSales.ReadOnly = true;
            this.textBoxTotalYTDSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxTotalYTDSales.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalYTDSales.TabIndex = 0;
            // 
            // labelCreditHoldCount
            // 
            this.labelCreditHoldCount.AutoSize = true;
            this.labelCreditHoldCount.Location = new System.Drawing.Point(30, 76);
            this.labelCreditHoldCount.Name = "labelCreditHoldCount";
            this.labelCreditHoldCount.Size = new System.Drawing.Size(93, 13);
            this.labelCreditHoldCount.TabIndex = 0;
            this.labelCreditHoldCount.Text = "Credit Hold Count:";
            // 
            // textBoxCreditHoldCount
            // 
            this.textBoxCreditHoldCount.Location = new System.Drawing.Point(175, 73);
            this.textBoxCreditHoldCount.Name = "textBoxCreditHoldCount";
            this.textBoxCreditHoldCount.ReadOnly = true;
            this.textBoxCreditHoldCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCreditHoldCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxCreditHoldCount.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(200, 120);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // TotalsForm
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 155);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxCreditHoldCount);
            this.Controls.Add(this.labelCreditHoldCount);
            this.Controls.Add(this.textBoxTotalYTDSales);
            this.Controls.Add(this.labelTotalYTDSales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TotalsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Totals";
            this.Load += new System.EventHandler(this.TotalsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalYTDSales;
        private System.Windows.Forms.TextBox textBoxTotalYTDSales;
        private System.Windows.Forms.Label labelCreditHoldCount;
        private System.Windows.Forms.TextBox textBoxCreditHoldCount;
        private System.Windows.Forms.Button buttonClose;
    }
}