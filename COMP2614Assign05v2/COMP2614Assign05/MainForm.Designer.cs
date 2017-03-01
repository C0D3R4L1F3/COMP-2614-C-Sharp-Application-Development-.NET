namespace COMP2614Assign05
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
            this.labelYear = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxMonth = new System.Windows.Forms.TextBox();
            this.textBoxDay = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCheckDate = new System.Windows.Forms.Button();
            this.toolTipResult = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(12, 9);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(32, 13);
            this.labelYear.TabIndex = 0;
            this.labelYear.Text = "&Year:";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(89, 9);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(40, 13);
            this.labelMonth.TabIndex = 2;
            this.labelMonth.Text = "&Month:";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(163, 9);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(29, 13);
            this.labelDay.TabIndex = 4;
            this.labelDay.Text = "&Day:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(15, 25);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(71, 20);
            this.textBoxYear.TabIndex = 1;
            this.textBoxYear.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // textBoxMonth
            // 
            this.textBoxMonth.Location = new System.Drawing.Point(92, 25);
            this.textBoxMonth.Name = "textBoxMonth";
            this.textBoxMonth.Size = new System.Drawing.Size(69, 20);
            this.textBoxMonth.TabIndex = 3;
            this.textBoxMonth.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // textBoxDay
            // 
            this.textBoxDay.Location = new System.Drawing.Point(166, 25);
            this.textBoxDay.Name = "textBoxDay";
            this.textBoxDay.Size = new System.Drawing.Size(70, 20);
            this.textBoxDay.TabIndex = 5;
            this.textBoxDay.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(11, 75);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(92, 24);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "<Result>";
            // 
            // buttonCheckDate
            // 
            this.buttonCheckDate.Location = new System.Drawing.Point(161, 76);
            this.buttonCheckDate.Name = "buttonCheckDate";
            this.buttonCheckDate.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckDate.TabIndex = 6;
            this.buttonCheckDate.Text = "&Check Date";
            this.buttonCheckDate.UseVisualStyleBackColor = true;
            this.buttonCheckDate.Click += new System.EventHandler(this.buttonCheckDate_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonCheckDate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 126);
            this.Controls.Add(this.buttonCheckDate);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxDay);
            this.Controls.Add(this.textBoxMonth);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Date Validator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxMonth;
        private System.Windows.Forms.TextBox textBoxDay;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCheckDate;
        private System.Windows.Forms.ToolTip toolTipResult;
    }
}

