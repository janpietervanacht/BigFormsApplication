namespace BigFormsApplication.Forms
{
    partial class FrmListViewToListView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel1 = new System.Windows.Forms.Panel();
            this.ButtonLeaveForm = new System.Windows.Forms.Button();
            this.AccButton = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.ListViewOrdPeople = new System.Windows.Forms.ListView();
            this.ColClientNumber = new System.Windows.Forms.ColumnHeader();
            this.ColFirstName = new System.Windows.Forms.ColumnHeader();
            this.ColBirthDate = new System.Windows.Forms.ColumnHeader();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label6 = new System.Windows.Forms.Label();
            this.ListViewPopstars = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Panel1.Controls.Add(this.ButtonLeaveForm);
            this.Panel1.Controls.Add(this.AccButton);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(this.ListViewOrdPeople);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(23, 43);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(696, 628);
            this.Panel1.TabIndex = 0;
            // 
            // ButtonLeaveForm
            // 
            this.ButtonLeaveForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonLeaveForm.Location = new System.Drawing.Point(232, 553);
            this.ButtonLeaveForm.Name = "ButtonLeaveForm";
            this.ButtonLeaveForm.Size = new System.Drawing.Size(171, 56);
            this.ButtonLeaveForm.TabIndex = 6;
            this.ButtonLeaveForm.Text = "&Verlaat Scherm (ESC)";
            this.ButtonLeaveForm.UseVisualStyleBackColor = true;
            // 
            // AccButton
            // 
            this.AccButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccButton.Location = new System.Drawing.Point(31, 553);
            this.AccButton.Name = "AccButton";
            this.AccButton.Size = new System.Drawing.Size(171, 56);
            this.AccButton.TabIndex = 6;
            this.AccButton.Text = "&Acceptatie knop";
            this.AccButton.UseVisualStyleBackColor = true;
            this.AccButton.Click += new System.EventHandler(this.AccButton_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label5.Location = new System.Drawing.Point(31, 61);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(221, 23);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Dubbelklik op klantnummer";
            // 
            // ListViewOrdPeople
            // 
            this.ListViewOrdPeople.AllowDrop = true;
            this.ListViewOrdPeople.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColClientNumber,
            this.ColFirstName,
            this.ColBirthDate});
            this.ListViewOrdPeople.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListViewOrdPeople.HideSelection = false;
            this.ListViewOrdPeople.Location = new System.Drawing.Point(31, 108);
            this.ListViewOrdPeople.Name = "ListViewOrdPeople";
            this.ListViewOrdPeople.Size = new System.Drawing.Size(629, 439);
            this.ListViewOrdPeople.TabIndex = 4;
            this.ListViewOrdPeople.UseCompatibleStateImageBehavior = false;
            this.ListViewOrdPeople.View = System.Windows.Forms.View.Details;
            this.ListViewOrdPeople.DoubleClick += new System.EventHandler(this.ListViewOrdPeople_DoubleClick);
            // 
            // ColClientNumber
            // 
            this.ColClientNumber.Text = "Klantnummer";
            this.ColClientNumber.Width = 100;
            // 
            // ColFirstName
            // 
            this.ColFirstName.Text = "Voornaam";
            this.ColFirstName.Width = 350;
            // 
            // ColBirthDate
            // 
            this.ColBirthDate.Text = "Geboortedatum";
            this.ColBirthDate.Width = 100;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.Location = new System.Drawing.Point(22, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(358, 41);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "ListView Gewone Mensen";
            // 
            // Panel2
            // 
            this.Panel2.AllowDrop = true;
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Panel2.Controls.Add(this.Label6);
            this.Panel2.Controls.Add(this.ListViewPopstars);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Location = new System.Drawing.Point(755, 43);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(717, 628);
            this.Panel2.TabIndex = 0;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label6.Location = new System.Drawing.Point(22, 61);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(221, 23);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "Dubbelklik op klantnummer";
            // 
            // ListViewPopstars
            // 
            this.ListViewPopstars.AllowDrop = true;
            this.ListViewPopstars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ListViewPopstars.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListViewPopstars.HideSelection = false;
            this.ListViewPopstars.Location = new System.Drawing.Point(34, 108);
            this.ListViewPopstars.Name = "ListViewPopstars";
            this.ListViewPopstars.Size = new System.Drawing.Size(629, 439);
            this.ListViewPopstars.TabIndex = 4;
            this.ListViewPopstars.UseCompatibleStateImageBehavior = false;
            this.ListViewPopstars.View = System.Windows.Forms.View.Details;
            this.ListViewPopstars.DoubleClick += new System.EventHandler(this.ListViewPopstars_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Klantnummer";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Voornaam";
            this.columnHeader2.Width = 350;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Geboortedatum";
            this.columnHeader3.Width = 100;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(22, 20);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(288, 41);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "ListView Pop Sterren";
            // 
            // FrmListViewToListView
            // 
            this.AcceptButton = this.AccButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonLeaveForm;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximumSize = new System.Drawing.Size(1500, 750);
            this.Name = "FrmListViewToListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dubbelklik item van ListView naar ListView";
            this.Load += new System.EventHandler(this.FrmListViewToListView_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.ListView ListViewOrdPeople;
        private System.Windows.Forms.ColumnHeader ColClientNumber;
        private System.Windows.Forms.ColumnHeader ColFirstName;
        private System.Windows.Forms.ColumnHeader ColBirthDate;
        private System.Windows.Forms.ListView ListViewPopstars;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Button AccButton;
        private System.Windows.Forms.Button ButtonLeaveForm;
    }
}

