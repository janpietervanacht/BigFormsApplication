namespace BigFormsApplication.Forms
{
    partial class FrmWebClient
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
            this.ListViewClienten = new System.Windows.Forms.ListView();
            this.ClientNumber = new System.Windows.Forms.ColumnHeader();
            this.ClientFirstName = new System.Windows.Forms.ColumnHeader();
            this.NrOfInvoices = new System.Windows.Forms.ColumnHeader();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.LabelInfo2 = new System.Windows.Forms.Label();
            this.DataGridViewInvoicesPerClient = new System.Windows.Forms.DataGridView();
            this.LabelClientFullName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInvoicesPerClient)).BeginInit();
            this.SuspendLayout();
            // 
            // ListViewClienten
            // 
            this.ListViewClienten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientNumber,
            this.ClientFirstName,
            this.NrOfInvoices});
            this.ListViewClienten.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListViewClienten.GridLines = true;
            this.ListViewClienten.HideSelection = false;
            this.ListViewClienten.Location = new System.Drawing.Point(31, 69);
            this.ListViewClienten.Name = "ListViewClienten";
            this.ListViewClienten.Size = new System.Drawing.Size(621, 590);
            this.ListViewClienten.TabIndex = 0;
            this.ListViewClienten.UseCompatibleStateImageBehavior = false;
            this.ListViewClienten.View = System.Windows.Forms.View.Details;
            this.ListViewClienten.SelectedIndexChanged += new System.EventHandler(this.ListViewClienten_SelectedIndexChanged);
            // 
            // ClientNumber
            // 
            this.ClientNumber.Text = "Klant nr";
            this.ClientNumber.Width = 100;
            // 
            // ClientFirstName
            // 
            this.ClientFirstName.Text = "Klant voornaam";
            this.ClientFirstName.Width = 400;
            // 
            // NrOfInvoices
            // 
            this.NrOfInvoices.Text = "# facturen";
            this.NrOfInvoices.Width = 120;
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Location = new System.Drawing.Point(31, 22);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(242, 20);
            this.labelInfo1.TabIndex = 1;
            this.labelInfo1.Text = "Klik op clientnummer voor facturen";
            // 
            // LabelInfo2
            // 
            this.LabelInfo2.AutoSize = true;
            this.LabelInfo2.Location = new System.Drawing.Point(296, 22);
            this.LabelInfo2.Name = "LabelInfo2";
            this.LabelInfo2.Size = new System.Drawing.Size(267, 20);
            this.LabelInfo2.TabIndex = 1;
            this.LabelInfo2.Text = "De facturen komen binnen via Web API";
            // 
            // DataGridViewInvoicesPerClient
            // 
            this.DataGridViewInvoicesPerClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewInvoicesPerClient.Location = new System.Drawing.Point(740, 69);
            this.DataGridViewInvoicesPerClient.Name = "DataGridViewInvoicesPerClient";
            this.DataGridViewInvoicesPerClient.RowHeadersWidth = 51;
            this.DataGridViewInvoicesPerClient.Size = new System.Drawing.Size(636, 590);
            this.DataGridViewInvoicesPerClient.TabIndex = 2;
            this.DataGridViewInvoicesPerClient.Text = "dataGridView1";
            // 
            // LabelClientFullName
            // 
            this.LabelClientFullName.AutoSize = true;
            this.LabelClientFullName.Location = new System.Drawing.Point(740, 22);
            this.LabelClientFullName.Name = "LabelClientFullName";
            this.LabelClientFullName.Size = new System.Drawing.Size(110, 20);
            this.LabelClientFullName.TabIndex = 1;
            this.LabelClientFullName.Text = "ClientFullName";
            // 
            // FrmWebClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.DataGridViewInvoicesPerClient);
            this.Controls.Add(this.LabelClientFullName);
            this.Controls.Add(this.LabelInfo2);
            this.Controls.Add(this.labelInfo1);
            this.Controls.Add(this.ListViewClienten);
            this.MaximumSize = new System.Drawing.Size(1500, 750);
            this.Name = "FrmWebClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ophalen Facturen van clienten";
            this.Load += new System.EventHandler(this.FrmClientenListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInvoicesPerClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewClienten;
        private System.Windows.Forms.ColumnHeader ClientNumber;
        private System.Windows.Forms.ColumnHeader ClientFirstName;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.Label LabelInfo2;
        private System.Windows.Forms.DataGridView DataGridViewInvoicesPerClient;
        private System.Windows.Forms.ColumnHeader NrOfInvoices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelClientFullName;
    }
}