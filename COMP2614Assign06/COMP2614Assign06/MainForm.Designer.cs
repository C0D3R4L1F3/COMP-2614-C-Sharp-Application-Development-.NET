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
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.buttonEditClient = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.statusStripMainForm = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusMainLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusMainLabelDateAndTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateAndTimeMainForm = new System.Windows.Forms.Timer(this.components);
            this.buttonTotals = new System.Windows.Forms.Button();
            this.menuStripMainForm = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMainForm = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonEditClient = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNewClient = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonTotal = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.statusStripMainForm.SuspendLayout();
            this.menuStripMainForm.SuspendLayout();
            this.toolStripMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClients.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(22, 74);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(1061, 338);
            this.dataGridViewClients.TabIndex = 0;
            this.dataGridViewClients.DoubleClick += new System.EventHandler(this.dataGridViewClients_DoubleClick);
            // 
            // buttonEditClient
            // 
            this.buttonEditClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditClient.Location = new System.Drawing.Point(846, 427);
            this.buttonEditClient.Name = "buttonEditClient";
            this.buttonEditClient.Size = new System.Drawing.Size(75, 23);
            this.buttonEditClient.TabIndex = 3;
            this.buttonEditClient.Text = "&Edit Client";
            this.buttonEditClient.UseVisualStyleBackColor = true;
            this.buttonEditClient.Click += new System.EventHandler(this.dataGridViewClients_DoubleClick);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(1008, 427);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewClient.Location = new System.Drawing.Point(765, 427);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(75, 23);
            this.buttonNewClient.TabIndex = 2;
            this.buttonNewClient.Text = "&New Client";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            this.buttonNewClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(927, 427);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "&Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // statusStripMainForm
            // 
            this.statusStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusMainLabelStatus,
            this.toolStripStatusMainLabelDateAndTime});
            this.statusStripMainForm.Location = new System.Drawing.Point(0, 462);
            this.statusStripMainForm.Name = "statusStripMainForm";
            this.statusStripMainForm.Size = new System.Drawing.Size(1107, 22);
            this.statusStripMainForm.TabIndex = 7;
            this.statusStripMainForm.Text = "statusStrip1";
            // 
            // toolStripStatusMainLabelStatus
            // 
            this.toolStripStatusMainLabelStatus.BackColor = System.Drawing.SystemColors.Info;
            this.toolStripStatusMainLabelStatus.Name = "toolStripStatusMainLabelStatus";
            this.toolStripStatusMainLabelStatus.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusMainLabelStatus.Text = "<Status>";
            // 
            // toolStripStatusMainLabelDateAndTime
            // 
            this.toolStripStatusMainLabelDateAndTime.BackColor = System.Drawing.SystemColors.Info;
            this.toolStripStatusMainLabelDateAndTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusMainLabelDateAndTime.Name = "toolStripStatusMainLabelDateAndTime";
            this.toolStripStatusMainLabelDateAndTime.Size = new System.Drawing.Size(1037, 17);
            this.toolStripStatusMainLabelDateAndTime.Spring = true;
            this.toolStripStatusMainLabelDateAndTime.Text = "<DateAndTime>";
            this.toolStripStatusMainLabelDateAndTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerDateAndTimeMainForm
            // 
            this.timerDateAndTimeMainForm.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
            // 
            // buttonTotals
            // 
            this.buttonTotals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTotals.Location = new System.Drawing.Point(684, 427);
            this.buttonTotals.Name = "buttonTotals";
            this.buttonTotals.Size = new System.Drawing.Size(75, 23);
            this.buttonTotals.TabIndex = 1;
            this.buttonTotals.Text = "&Totals";
            this.buttonTotals.UseVisualStyleBackColor = true;
            this.buttonTotals.Click += new System.EventHandler(this.buttonTotals_Click);
            // 
            // menuStripMainForm
            // 
            this.menuStripMainForm.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainForm.Name = "menuStripMainForm";
            this.menuStripMainForm.Size = new System.Drawing.Size(1107, 24);
            this.menuStripMainForm.TabIndex = 6;
            this.menuStripMainForm.Text = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newClientToolStripMenuItem,
            this.editClientToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newClientToolStripMenuItem
            // 
            this.newClientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newClientToolStripMenuItem.Image")));
            this.newClientToolStripMenuItem.Name = "newClientToolStripMenuItem";
            this.newClientToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newClientToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newClientToolStripMenuItem.Text = "&New Client";
            this.newClientToolStripMenuItem.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // editClientToolStripMenuItem
            // 
            this.editClientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editClientToolStripMenuItem.Image")));
            this.editClientToolStripMenuItem.Name = "editClientToolStripMenuItem";
            this.editClientToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editClientToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.editClientToolStripMenuItem.Text = "&Edit Client";
            this.editClientToolStripMenuItem.Click += new System.EventHandler(this.dataGridViewClients_DoubleClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(172, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripMenuItem.Image")));
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // toolbarToolStripMenuItem
            // 
            this.toolbarToolStripMenuItem.CheckOnClick = true;
            this.toolbarToolStripMenuItem.Name = "toolbarToolStripMenuItem";
            this.toolbarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.toolbarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.toolbarToolStripMenuItem.Text = "Tool&bar";
            this.toolbarToolStripMenuItem.Click += new System.EventHandler(this.toolbarToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMainForm
            // 
            this.toolStripMainForm.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDelete,
            this.toolStripSeparator3,
            this.toolStripButtonEditClient,
            this.toolStripButtonNewClient,
            this.toolStripSeparator4,
            this.toolStripButtonTotal});
            this.toolStripMainForm.Location = new System.Drawing.Point(0, 24);
            this.toolStripMainForm.Name = "toolStripMainForm";
            this.toolStripMainForm.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripMainForm.Size = new System.Drawing.Size(1107, 25);
            this.toolStripMainForm.TabIndex = 8;
            this.toolStripMainForm.Text = "toolStripMain";
            this.toolStripMainForm.Visible = false;
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelete.Text = "Delete";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonEditClient
            // 
            this.toolStripButtonEditClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditClient.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditClient.Image")));
            this.toolStripButtonEditClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditClient.Name = "toolStripButtonEditClient";
            this.toolStripButtonEditClient.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEditClient.Text = "Edit Client";
            this.toolStripButtonEditClient.Click += new System.EventHandler(this.dataGridViewClients_DoubleClick);
            // 
            // toolStripButtonNewClient
            // 
            this.toolStripButtonNewClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNewClient.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNewClient.Image")));
            this.toolStripButtonNewClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNewClient.Name = "toolStripButtonNewClient";
            this.toolStripButtonNewClient.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNewClient.Text = "New Client";
            this.toolStripButtonNewClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonTotal
            // 
            this.toolStripButtonTotal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTotal.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTotal.Image")));
            this.toolStripButtonTotal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTotal.Name = "toolStripButtonTotal";
            this.toolStripButtonTotal.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonTotal.Text = "Totals";
            this.toolStripButtonTotal.Click += new System.EventHandler(this.buttonTotals_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonNewClient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1107, 484);
            this.Controls.Add(this.toolStripMainForm);
            this.Controls.Add(this.buttonTotals);
            this.Controls.Add(this.statusStripMainForm);
            this.Controls.Add(this.menuStripMainForm);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNewClient);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonEditClient);
            this.Controls.Add(this.dataGridViewClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMainForm;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients List";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.statusStripMainForm.ResumeLayout(false);
            this.statusStripMainForm.PerformLayout();
            this.menuStripMainForm.ResumeLayout(false);
            this.menuStripMainForm.PerformLayout();
            this.toolStripMainForm.ResumeLayout(false);
            this.toolStripMainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.Button buttonEditClient;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonNewClient;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.StatusStrip statusStripMainForm;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMainLabelStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusMainLabelDateAndTime;
        private System.Windows.Forms.Timer timerDateAndTimeMainForm;
        private System.Windows.Forms.Button buttonTotals;
        private System.Windows.Forms.MenuStrip menuStripMainForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMainForm;
        private System.Windows.Forms.ToolStripButton toolStripButtonTotal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonNewClient;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditClient;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
    }
}

