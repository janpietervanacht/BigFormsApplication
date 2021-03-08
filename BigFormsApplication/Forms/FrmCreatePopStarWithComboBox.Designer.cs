namespace BigFormsApplication.Forms
{
    partial class FrmCreatePopStarWithComboBox
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
            this.CancButtonVerlaatScherm = new System.Windows.Forms.Button();
            this.ButtonMaakPopster = new System.Windows.Forms.Button();
            this.ComboBoxClientsIndirect = new System.Windows.Forms.ComboBox();
            this.ComboBoxClientsDirect = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.ButtonOntslaZeAllemaal = new System.Windows.Forms.Button();
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
            this.Panel1.Controls.Add(this.CancButtonVerlaatScherm);
            this.Panel1.Controls.Add(this.ButtonMaakPopster);
            this.Panel1.Controls.Add(this.ComboBoxClientsIndirect);
            this.Panel1.Controls.Add(this.ComboBoxClientsDirect);
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Location = new System.Drawing.Point(23, 43);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(385, 628);
            this.Panel1.TabIndex = 0;
            // 
            // CancButtonVerlaatScherm
            // 
            this.CancButtonVerlaatScherm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancButtonVerlaatScherm.Location = new System.Drawing.Point(27, 368);
            this.CancButtonVerlaatScherm.Name = "CancButtonVerlaatScherm";
            this.CancButtonVerlaatScherm.Size = new System.Drawing.Size(312, 38);
            this.CancButtonVerlaatScherm.TabIndex = 7;
            this.CancButtonVerlaatScherm.Text = "&Verlaat scherm zonder update (ESC)";
            this.CancButtonVerlaatScherm.UseVisualStyleBackColor = true;
            // 
            // ButtonMaakPopster
            // 
            this.ButtonMaakPopster.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonMaakPopster.Location = new System.Drawing.Point(27, 137);
            this.ButtonMaakPopster.Name = "ButtonMaakPopster";
            this.ButtonMaakPopster.Size = new System.Drawing.Size(127, 38);
            this.ButtonMaakPopster.TabIndex = 7;
            this.ButtonMaakPopster.Text = "Maak Popster";
            this.ButtonMaakPopster.UseVisualStyleBackColor = true;
            this.ButtonMaakPopster.Click += new System.EventHandler(this.ButtonMaakPopster_Click);
            // 
            // ComboBoxClientsIndirect
            // 
            this.ComboBoxClientsIndirect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxClientsIndirect.FormattingEnabled = true;
            this.ComboBoxClientsIndirect.Location = new System.Drawing.Point(27, 88);
            this.ComboBoxClientsIndirect.Name = "ComboBoxClientsIndirect";
            this.ComboBoxClientsIndirect.Size = new System.Drawing.Size(332, 29);
            this.ComboBoxClientsIndirect.TabIndex = 6;
            this.ComboBoxClientsIndirect.Text = "Selecteer maar, knul";
            // 
            // ComboBoxClientsDirect
            // 
            this.ComboBoxClientsDirect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBoxClientsDirect.FormattingEnabled = true;
            this.ComboBoxClientsDirect.Location = new System.Drawing.Point(27, 215);
            this.ComboBoxClientsDirect.Name = "ComboBoxClientsDirect";
            this.ComboBoxClientsDirect.Size = new System.Drawing.Size(332, 29);
            this.ComboBoxClientsDirect.TabIndex = 6;
            this.ComboBoxClientsDirect.Text = "Selecteer maar, knul";
            this.ComboBoxClientsDirect.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClientsDirect_SelectedIndexChanged);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label5.Location = new System.Drawing.Point(13, 20);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(164, 17);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Selecteer uw Popster TOBE";
            // 
            // Panel2
            // 
            this.Panel2.AllowDrop = true;
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Panel2.Controls.Add(this.ButtonOntslaZeAllemaal);
            this.Panel2.Controls.Add(this.ListViewPopstars);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Location = new System.Drawing.Point(550, 43);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(868, 628);
            this.Panel2.TabIndex = 0;
            // 
            // ButtonOntslaZeAllemaal
            // 
            this.ButtonOntslaZeAllemaal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonOntslaZeAllemaal.Location = new System.Drawing.Point(339, 27);
            this.ButtonOntslaZeAllemaal.Name = "ButtonOntslaZeAllemaal";
            this.ButtonOntslaZeAllemaal.Size = new System.Drawing.Size(275, 38);
            this.ButtonOntslaZeAllemaal.TabIndex = 7;
            this.ButtonOntslaZeAllemaal.Text = "Ontsla alle Popsterren";
            this.ButtonOntslaZeAllemaal.UseVisualStyleBackColor = true;
            this.ButtonOntslaZeAllemaal.Click += new System.EventHandler(this.ButtonOntslaZeAllemaal_Click);
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
            this.ListViewPopstars.Size = new System.Drawing.Size(780, 439);
            this.ListViewPopstars.TabIndex = 4;
            this.ListViewPopstars.UseCompatibleStateImageBehavior = false;
            this.ListViewPopstars.View = System.Windows.Forms.View.Details;
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
            this.columnHeader3.Width = 120;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(22, 20);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(230, 32);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "ListView Pop Sterren";
            // 
            // FrmCreatePopStarWithComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancButtonVerlaatScherm;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximumSize = new System.Drawing.Size(1500, 750);
            this.Name = "FrmCreatePopStarWithComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maak uw popster via ComboBox";
            this.Load += new System.EventHandler(this.FrmCreatePopStarWithComboBox_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.ListView ListViewPopstars;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.ComboBox ComboBoxClientsIndirect;
        private System.Windows.Forms.Button ButtonMaakPopster;
        private System.Windows.Forms.ComboBox ComboBoxClientsDirect;
        private System.Windows.Forms.Button ButtonOntslaZeAllemaal;
        private System.Windows.Forms.Button CancButtonVerlaatScherm;
    }
}

