namespace BigFormsApplication.Forms
{
    partial class FrmCheckedListBox
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
            this.ListBoxFacturen = new System.Windows.Forms.ListBox();
            this.TxbInvoiceDetail = new System.Windows.Forms.RichTextBox();
            this.LblSelectTypeClient = new System.Windows.Forms.Label();
            this.LblSelectTypeInvoice = new System.Windows.Forms.Label();
            this.BtnShowInvoices = new System.Windows.Forms.Button();
            this.CheckedkListBoxClienten = new System.Windows.Forms.CheckedListBox();
            this.BtnSelectOrUnSelectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxFacturen
            // 
            this.ListBoxFacturen.FormattingEnabled = true;
            this.ListBoxFacturen.ItemHeight = 20;
            this.ListBoxFacturen.Location = new System.Drawing.Point(429, 113);
            this.ListBoxFacturen.Name = "ListBoxFacturen";
            this.ListBoxFacturen.Size = new System.Drawing.Size(299, 544);
            this.ListBoxFacturen.TabIndex = 0;
            this.ListBoxFacturen.SelectedIndexChanged += new System.EventHandler(this.ListBoxFacturen_SelectedIndexChanged);
            // 
            // TxbInvoiceDetail
            // 
            this.TxbInvoiceDetail.Location = new System.Drawing.Point(747, 173);
            this.TxbInvoiceDetail.Name = "TxbInvoiceDetail";
            this.TxbInvoiceDetail.Size = new System.Drawing.Size(353, 329);
            this.TxbInvoiceDetail.TabIndex = 1;
            this.TxbInvoiceDetail.Text = "";
            // 
            // LblSelectTypeClient
            // 
            this.LblSelectTypeClient.AutoSize = true;
            this.LblSelectTypeClient.Location = new System.Drawing.Point(83, 28);
            this.LblSelectTypeClient.Name = "LblSelectTypeClient";
            this.LblSelectTypeClient.Size = new System.Drawing.Size(129, 20);
            this.LblSelectTypeClient.TabIndex = 2;
            this.LblSelectTypeClient.Text = "Multi-select Client";
            // 
            // LblSelectTypeInvoice
            // 
            this.LblSelectTypeInvoice.AutoSize = true;
            this.LblSelectTypeInvoice.Location = new System.Drawing.Point(441, 28);
            this.LblSelectTypeInvoice.Name = "LblSelectTypeInvoice";
            this.LblSelectTypeInvoice.Size = new System.Drawing.Size(145, 20);
            this.LblSelectTypeInvoice.TabIndex = 2;
            this.LblSelectTypeInvoice.Text = "Single-select Factuur";
            // 
            // BtnShowInvoices
            // 
            this.BtnShowInvoices.Location = new System.Drawing.Point(73, 68);
            this.BtnShowInvoices.Name = "BtnShowInvoices";
            this.BtnShowInvoices.Size = new System.Drawing.Size(94, 52);
            this.BtnShowInvoices.TabIndex = 3;
            this.BtnShowInvoices.Text = "Toon facturen";
            this.BtnShowInvoices.UseVisualStyleBackColor = true;
            this.BtnShowInvoices.Click += new System.EventHandler(this.BtnShowInvoices_Click);
            // 
            // CheckedkListBoxClienten
            // 
            this.CheckedkListBoxClienten.FormattingEnabled = true;
            this.CheckedkListBoxClienten.Location = new System.Drawing.Point(83, 126);
            this.CheckedkListBoxClienten.Name = "CheckedkListBoxClienten";
            this.CheckedkListBoxClienten.Size = new System.Drawing.Size(191, 532);
            this.CheckedkListBoxClienten.TabIndex = 4;
            // 
            // BtnSelectOrUnSelectAll
            // 
            this.BtnSelectOrUnSelectAll.Location = new System.Drawing.Point(180, 68);
            this.BtnSelectOrUnSelectAll.Name = "BtnSelectOrUnSelectAll";
            this.BtnSelectOrUnSelectAll.Size = new System.Drawing.Size(94, 52);
            this.BtnSelectOrUnSelectAll.TabIndex = 3;
            this.BtnSelectOrUnSelectAll.Text = "Selecteer alles";
            this.BtnSelectOrUnSelectAll.UseVisualStyleBackColor = true;
            this.BtnSelectOrUnSelectAll.Click += new System.EventHandler(this.BtnSelectOrUnselectAll_Click);
            // 
            // FrmCheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.CheckedkListBoxClienten);
            this.Controls.Add(this.BtnSelectOrUnSelectAll);
            this.Controls.Add(this.BtnShowInvoices);
            this.Controls.Add(this.LblSelectTypeInvoice);
            this.Controls.Add(this.LblSelectTypeClient);
            this.Controls.Add(this.TxbInvoiceDetail);
            this.Controls.Add(this.ListBoxFacturen);
            this.MaximumSize = new System.Drawing.Size(1500, 750);
            this.Name = "FrmCheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voorbeelden List Box";
            this.Load += new System.EventHandler(this.FrmListBoxExample_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListBoxFacturen;
        private System.Windows.Forms.RichTextBox TxbInvoiceDetail;
        private System.Windows.Forms.Label LblSelectTypeClient;
        private System.Windows.Forms.Label LblSelectTypeInvoice;
        private System.Windows.Forms.Button BtnShowInvoices;
        private System.Windows.Forms.CheckedListBox CheckedkListBoxClienten;
        private System.Windows.Forms.Button BtnSelectOrUnSelectAll;
    }
}