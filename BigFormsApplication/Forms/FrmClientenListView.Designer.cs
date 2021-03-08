namespace BigFormsApplication.Forms
{
    partial class FrmClientenListView
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
            this.TbxClientDetails = new System.Windows.Forms.RichTextBox();
            this.ButtonEscape = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListViewClienten
            // 
            this.ListViewClienten.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientNumber,
            this.ClientFirstName});
            this.ListViewClienten.GridLines = true;
            this.ListViewClienten.HideSelection = false;
            this.ListViewClienten.Location = new System.Drawing.Point(34, 31);
            this.ListViewClienten.Name = "ListViewClienten";
            this.ListViewClienten.Size = new System.Drawing.Size(963, 255);
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
            this.ClientFirstName.Width = 300;
            // 
            // TbxClientDetails
            // 
            this.TbxClientDetails.Location = new System.Drawing.Point(34, 337);
            this.TbxClientDetails.Name = "TbxClientDetails";
            this.TbxClientDetails.Size = new System.Drawing.Size(963, 276);
            this.TbxClientDetails.TabIndex = 1;
            this.TbxClientDetails.Text = "";
            // 
            // ButtonEscape
            // 
            this.ButtonEscape.Location = new System.Drawing.Point(1179, 40);
            this.ButtonEscape.Name = "ButtonEscape";
            this.ButtonEscape.Size = new System.Drawing.Size(94, 29);
            this.ButtonEscape.TabIndex = 2;
            this.ButtonEscape.Text = "Sluit af (ESC)";
            this.ButtonEscape.UseVisualStyleBackColor = true;
            // 
            // FrmClientenListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonEscape;
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.Controls.Add(this.ButtonEscape);
            this.Controls.Add(this.TbxClientDetails);
            this.Controls.Add(this.ListViewClienten);
            this.MaximumSize = new System.Drawing.Size(1500, 750);
            this.Name = "FrmClientenListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clienten in ListView";
            this.Load += new System.EventHandler(this.FrmClientenListView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListViewClienten;
        private System.Windows.Forms.ColumnHeader ClientNumber;
        private System.Windows.Forms.ColumnHeader ClientFirstName;
        private System.Windows.Forms.RichTextBox TbxClientDetails;
        private System.Windows.Forms.Button ButtonEscape;
    }
}