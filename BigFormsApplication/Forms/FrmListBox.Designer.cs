namespace BigFormsApplication.Forms
{
    partial class FrmListBox
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
            this.ListBoxClienten = new System.Windows.Forms.ListBox();
            this.ListBoxFacturen = new System.Windows.Forms.ListBox();
            this.txbInvoiceDetail = new System.Windows.Forms.RichTextBox();
            this.LblSelectTypeClient = new System.Windows.Forms.Label();
            this.LblSelectTypeInvoice = new System.Windows.Forms.Label();
            this.BtnShowInvoices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxClienten
            // 
            this.ListBoxClienten.FormattingEnabled = true;
            this.ListBoxClienten.ItemHeight = 20;
            this.ListBoxClienten.Location = new System.Drawing.Point(66, 113);
            this.ListBoxClienten.Name = "ListBoxClienten";
            this.ListBoxClienten.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ListBoxClienten.Size = new System.Drawing.Size(356, 544);
            this.ListBoxClienten.TabIndex = 0;
            // 
            // ListBoxFacturen
            // 
            this.ListBoxFacturen.FormattingEnabled = true;
            this.ListBoxFacturen.ItemHeight = 20;
            this.ListBoxFacturen.Location = new System.Drawing.Point(454, 113);
            this.ListBoxFacturen.Name = "ListBoxFacturen";
            this.ListBoxFacturen.Size = new System.Drawing.Size(355, 544);
            this.ListBoxFacturen.TabIndex = 0;
            this.ListBoxFacturen.SelectedIndexChanged += new System.EventHandler(this.ListBoxFacturen_SelectedIndexChanged);
            // 
            // txbInvoiceDetail
            // 
            this.txbInvoiceDetail.Location = new System.Drawing.Point(837, 173);
            this.txbInvoiceDetail.Name = "txbInvoiceDetail";
            this.txbInvoiceDetail.Size = new System.Drawing.Size(386, 329);
            this.txbInvoiceDetail.TabIndex = 1;
            this.txbInvoiceDetail.Text = "";
            // 
            // LblSelectTypeClient
            // 
            this.LblSelectTypeClient.AutoSize = true;
            this.LblSelectTypeClient.Location = new System.Drawing.Point(83, 28);
            this.LblSelectTypeClient.Name = "LblSelectTypeClient";
            this.LblSelectTypeClient.Size = new System.Drawing.Size(217, 20);
            this.LblSelectTypeClient.TabIndex = 2;
            this.LblSelectTypeClient.Text = "Selection Mode = Multi-Simple";
            // 
            // LblSelectTypeInvoice
            // 
            this.LblSelectTypeInvoice.AutoSize = true;
            this.LblSelectTypeInvoice.Location = new System.Drawing.Point(441, 28);
            this.LblSelectTypeInvoice.Name = "LblSelectTypeInvoice";
            this.LblSelectTypeInvoice.Size = new System.Drawing.Size(158, 20);
            this.LblSelectTypeInvoice.TabIndex = 2;
            this.LblSelectTypeInvoice.Text = "Selection Mode = One";
            // 
            // BtnShowInvoices
            // 
            this.BtnShowInvoices.Location = new System.Drawing.Point(93, 71);
            this.BtnShowInvoices.Name = "BtnShowInvoices";
            this.BtnShowInvoices.Size = new System.Drawing.Size(94, 29);
            this.BtnShowInvoices.TabIndex = 3;
            this.BtnShowInvoices.Text = "Toon facturen";
            this.BtnShowInvoices.UseVisualStyleBackColor = true;
            this.BtnShowInvoices.Click += new System.EventHandler(this.BtnShowInvoices_Click);
            // 
            // FrmClientenListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.Controls.Add(this.BtnShowInvoices);
            this.Controls.Add(this.LblSelectTypeInvoice);
            this.Controls.Add(this.LblSelectTypeClient);
            this.Controls.Add(this.txbInvoiceDetail);
            this.Controls.Add(this.ListBoxFacturen);
            this.Controls.Add(this.ListBoxClienten);
            this.MaximumSize = new System.Drawing.Size(1500, 750);
            this.Name = "FrmClientenListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voorbeelden List Box";
            this.Load += new System.EventHandler(this.FrmListBoxExample_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxClienten;
        private System.Windows.Forms.ListBox ListBoxFacturen;
        private System.Windows.Forms.RichTextBox txbInvoiceDetail;
        private System.Windows.Forms.Label LblSelectTypeClient;
        private System.Windows.Forms.Label LblSelectTypeInvoice;
        private System.Windows.Forms.Button BtnShowInvoices;
    }
}