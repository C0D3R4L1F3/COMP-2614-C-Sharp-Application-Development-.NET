namespace COMP2614Assign06
{
    partial class TotalsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalsDialog));
            this.labelDisplayCreditHoldCount = new System.Windows.Forms.Label();
            this.labelDisplayYTDSalesTotal = new System.Windows.Forms.Label();
            this.labelTotalYTDSales = new System.Windows.Forms.Label();
            this.labelCreditHoldCount = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelClientCount = new System.Windows.Forms.Label();
            this.labelDisplayClientCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDisplayCreditHoldCount
            // 
            this.labelDisplayCreditHoldCount.AutoSize = true;
            this.labelDisplayCreditHoldCount.Location = new System.Drawing.Point(147, 41);
            this.labelDisplayCreditHoldCount.Name = "labelDisplayCreditHoldCount";
            this.labelDisplayCreditHoldCount.Size = new System.Drawing.Size(98, 13);
            this.labelDisplayCreditHoldCount.TabIndex = 3;
            this.labelDisplayCreditHoldCount.Text = "<Credit Hold Total>";
            // 
            // labelDisplayYTDSalesTotal
            // 
            this.labelDisplayYTDSalesTotal.AutoSize = true;
            this.labelDisplayYTDSalesTotal.Location = new System.Drawing.Point(189, 63);
            this.labelDisplayYTDSalesTotal.Name = "labelDisplayYTDSalesTotal";
            this.labelDisplayYTDSalesTotal.Size = new System.Drawing.Size(94, 13);
            this.labelDisplayYTDSalesTotal.TabIndex = 5;
            this.labelDisplayYTDSalesTotal.Text = "<YTDSales Total>";
            // 
            // labelTotalYTDSales
            // 
            this.labelTotalYTDSales.AutoSize = true;
            this.labelTotalYTDSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalYTDSales.Location = new System.Drawing.Point(28, 63);
            this.labelTotalYTDSales.Name = "labelTotalYTDSales";
            this.labelTotalYTDSales.Size = new System.Drawing.Size(155, 13);
            this.labelTotalYTDSales.TabIndex = 4;
            this.labelTotalYTDSales.Text = "Total Year To Date Sales:";
            // 
            // labelCreditHoldCount
            // 
            this.labelCreditHoldCount.AutoSize = true;
            this.labelCreditHoldCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreditHoldCount.Location = new System.Drawing.Point(28, 41);
            this.labelCreditHoldCount.Name = "labelCreditHoldCount";
            this.labelCreditHoldCount.Size = new System.Drawing.Size(113, 13);
            this.labelCreditHoldCount.TabIndex = 2;
            this.labelCreditHoldCount.Text = "Total Credit Holds:";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(208, 97);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelClientCount
            // 
            this.labelClientCount.AutoSize = true;
            this.labelClientCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientCount.Location = new System.Drawing.Point(28, 18);
            this.labelClientCount.Name = "labelClientCount";
            this.labelClientCount.Size = new System.Drawing.Size(82, 13);
            this.labelClientCount.TabIndex = 0;
            this.labelClientCount.Text = "Total Clients:";
            // 
            // labelDisplayClientCount
            // 
            this.labelDisplayClientCount.AutoSize = true;
            this.labelDisplayClientCount.Location = new System.Drawing.Point(116, 18);
            this.labelDisplayClientCount.Name = "labelDisplayClientCount";
            this.labelDisplayClientCount.Size = new System.Drawing.Size(103, 13);
            this.labelDisplayClientCount.TabIndex = 1;
            this.labelDisplayClientCount.Text = "<Client Count Total>";
            // 
            // TotalsDialog
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(309, 132);
            this.Controls.Add(this.labelDisplayClientCount);
            this.Controls.Add(this.labelClientCount);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelDisplayCreditHoldCount);
            this.Controls.Add(this.labelDisplayYTDSalesTotal);
            this.Controls.Add(this.labelTotalYTDSales);
            this.Controls.Add(this.labelCreditHoldCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TotalsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Totals";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TotalsDialog_FormClosing);
            this.Load += new System.EventHandler(this.TotalsDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDisplayCreditHoldCount;
        private System.Windows.Forms.Label labelDisplayYTDSalesTotal;
        private System.Windows.Forms.Label labelTotalYTDSales;
        private System.Windows.Forms.Label labelCreditHoldCount;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelClientCount;
        private System.Windows.Forms.Label labelDisplayClientCount;
    }
}