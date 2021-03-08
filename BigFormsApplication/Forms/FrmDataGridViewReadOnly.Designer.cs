namespace BigFormsApplication.Forms
{
    partial class FrmDataGridViewReadOnly
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBoxClientNumber = new System.Windows.Forms.TextBox();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.TextBoxBirthDate = new System.Windows.Forms.TextBox();
            this.LblChange = new System.Windows.Forms.Label(); 
            this.DataGridViewKlanten = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewKlanten)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(38, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(118, 23);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Klantnummer:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(261, 28);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(93, 23);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Voornaam:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(763, 57);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(136, 23);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Geboortedatum:";
            // 
            // TextBoxClientNumber
            // 
            this.TextBoxClientNumber.Location = new System.Drawing.Point(38, 57);
            this.TextBoxClientNumber.Name = "TextBoxClientNumber";
            this.TextBoxClientNumber.ReadOnly = true;
            this.TextBoxClientNumber.Size = new System.Drawing.Size(198, 29);
            this.TextBoxClientNumber.TabIndex = 2;
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(261, 57);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(457, 29);
            this.TextBoxFirstName.TabIndex = 2;
            // 
            // TextBoxBirthDate
            // 
            this.TextBoxBirthDate.Location = new System.Drawing.Point(927, 57);
            this.TextBoxBirthDate.Name = "TextBoxBirthDate";
            this.TextBoxBirthDate.Size = new System.Drawing.Size(336, 29);
            this.TextBoxBirthDate.TabIndex = 2;
            // 
            // LblChange
            // 
            this.LblChange.AutoSize = true;
            this.LblChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LblChange.Location = new System.Drawing.Point(1300, 60);
            this.LblChange.Name = "LblChange";
            this.LblChange.Size = new System.Drawing.Size(61, 23);
            this.LblChange.TabIndex = 1;
            this.LblChange.Text = "Wijzig ";
            this.LblChange.Click += new System.EventHandler(this.LblChange_Click);
            
            // 
            // FrmDataGridViewReadOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            // 
            // DataGridViewKlanten
            // 
            this.DataGridViewKlanten.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewKlanten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            
            this.DataGridViewKlanten.Location = new System.Drawing.Point(38, 100);
            this.DataGridViewKlanten.Margin = new System.Windows.Forms.Padding(1);
            this.DataGridViewKlanten.Name = "DataGridViewKlanten";
            this.DataGridViewKlanten.ReadOnly = true;
            this.DataGridViewKlanten.RowHeadersWidth = 51;
            this.DataGridViewKlanten.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewKlanten.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewKlanten.Size = new System.Drawing.Size(1339, 520);
            this.DataGridViewKlanten.TabIndex = 0;
            this.DataGridViewKlanten.Text = "dataGridView1";
            this.DataGridViewKlanten.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewKlanten_RowHeaderMouseClick);
            this.Controls.Add(this.TextBoxBirthDate);
            this.Controls.Add(this.TextBoxFirstName);
            this.Controls.Add(this.TextBoxClientNumber);
            this.Controls.Add(this.LblChange);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DataGridViewKlanten);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(1500, 750);
            this.Name = "FrmDataGridViewReadOnly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Grid View";
            this.Load += new System.EventHandler(this.FrmDataGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewKlanten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewKlanten;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox TextBoxClientNumber;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.TextBox TextBoxBirthDate;
        private System.Windows.Forms.Label LblChange; 
    }
}

