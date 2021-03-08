namespace BigFormsApplication.Forms
{
    partial class FrmTreeView
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txbInvoiceDetails = new System.Windows.Forms.RichTextBox();
            this.ChkBoxShowInvoiceDetails = new System.Windows.Forms.CheckBox();
            this.btnExpandCollapseAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(75, 53);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(640, 457);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // txbInvoiceDetails
            // 
            this.txbInvoiceDetails.Location = new System.Drawing.Point(834, 139);
            this.txbInvoiceDetails.Name = "txbInvoiceDetails";
            this.txbInvoiceDetails.Size = new System.Drawing.Size(322, 233);
            this.txbInvoiceDetails.TabIndex = 1;
            this.txbInvoiceDetails.Text = "";
            // 
            // ChkBoxShowInvoiceDetails
            // 
            this.ChkBoxShowInvoiceDetails.AutoSize = true;
            this.ChkBoxShowInvoiceDetails.Location = new System.Drawing.Point(834, 69);
            this.ChkBoxShowInvoiceDetails.Name = "ChkBoxShowInvoiceDetails";
            this.ChkBoxShowInvoiceDetails.Size = new System.Drawing.Size(127, 19);
            this.ChkBoxShowInvoiceDetails.TabIndex = 2;
            this.ChkBoxShowInvoiceDetails.Text = "Toon factuurdetails";
            this.ChkBoxShowInvoiceDetails.UseVisualStyleBackColor = true;
            this.ChkBoxShowInvoiceDetails.CheckedChanged += new System.EventHandler(this.ChkBoxShowInvoiceDetails_CheckedChanged);
            // 
            // btnExpandCollapseAll
            // 
            this.btnExpandCollapseAll.Location = new System.Drawing.Point(771, 481);
            this.btnExpandCollapseAll.Name = "btnExpandCollapseAll";
            this.btnExpandCollapseAll.Size = new System.Drawing.Size(143, 29);
            this.btnExpandCollapseAll.TabIndex = 3;
            this.btnExpandCollapseAll.UseVisualStyleBackColor = true;
            this.btnExpandCollapseAll.Click += new System.EventHandler(this.btnExpandCollapseAll_Click);
            // 
            // FrmClientenTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.btnExpandCollapseAll);
            this.Controls.Add(this.ChkBoxShowInvoiceDetails);
            this.Controls.Add(this.txbInvoiceDetails);
            this.Controls.Add(this.treeView1);
            this.MaximumSize = new System.Drawing.Size(1500, 750);
            this.Name = "FrmClientenTreeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clienten in TreeView";
            this.Load += new System.EventHandler(this.FrmClientenTreeView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox txbInvoiceDetails;
        private System.Windows.Forms.CheckBox ChkBoxShowInvoiceDetails;
        private System.Windows.Forms.Button btnExpandCollapseAll;
    }
}