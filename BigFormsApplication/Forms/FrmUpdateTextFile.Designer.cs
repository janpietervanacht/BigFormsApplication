namespace BigFormsApplication.Forms
{
    partial class FrmUpdateTextFile
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
            this.RichTxbTekst = new System.Windows.Forms.RichTextBox();
            this.ButtonOpenDialog = new System.Windows.Forms.Button();
            this.ButtonSchrijfWeg = new System.Windows.Forms.Button();
            this.LblInformationMessage = new System.Windows.Forms.Label();
            this.ButtonSaveUsingFileDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RichTxbTekst
            // 
            this.RichTxbTekst.Location = new System.Drawing.Point(110, 80);
            this.RichTxbTekst.Name = "RichTxbTekst";
            this.RichTxbTekst.Size = new System.Drawing.Size(796, 522);
            this.RichTxbTekst.TabIndex = 0;
            this.RichTxbTekst.Text = "";
            // 
            // ButtonOpenDialog
            // 
            this.ButtonOpenDialog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonOpenDialog.Location = new System.Drawing.Point(102, 30);
            this.ButtonOpenDialog.Name = "ButtonOpenDialog";
            this.ButtonOpenDialog.Size = new System.Drawing.Size(94, 29);
            this.ButtonOpenDialog.TabIndex = 1;
            this.ButtonOpenDialog.Text = "Open dialoog";
            this.ButtonOpenDialog.UseVisualStyleBackColor = true;
            this.ButtonOpenDialog.Click += new System.EventHandler(this.ButtonOpenDialog_Click);
            // 
            // ButtonSchrijfWeg
            // 
            this.ButtonSchrijfWeg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonSchrijfWeg.Location = new System.Drawing.Point(250, 30);
            this.ButtonSchrijfWeg.Name = "ButtonSchrijfWeg";
            this.ButtonSchrijfWeg.Size = new System.Drawing.Size(198, 29);
            this.ButtonSchrijfWeg.TabIndex = 1;
            this.ButtonSchrijfWeg.Text = "Schrijf duplicaat";
            this.ButtonSchrijfWeg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSchrijfWeg.UseVisualStyleBackColor = true;
            this.ButtonSchrijfWeg.Click += new System.EventHandler(this.ButtonWriteToFile_Click);
            // 
            // LblInformationMessage
            // 
            this.LblInformationMessage.AutoSize = true;
            this.LblInformationMessage.Location = new System.Drawing.Point(488, 34);
            this.LblInformationMessage.Name = "LblInformationMessage";
            this.LblInformationMessage.Size = new System.Drawing.Size(109, 20);
            this.LblInformationMessage.TabIndex = 2;
            this.LblInformationMessage.Text = "Informatietekst";
            // 
            // ButtonSaveUsingFileDialog
            // 
            this.ButtonSaveUsingFileDialog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonSaveUsingFileDialog.Location = new System.Drawing.Point(923, 125);
            this.ButtonSaveUsingFileDialog.Name = "ButtonSaveUsingFileDialog";
            this.ButtonSaveUsingFileDialog.Size = new System.Drawing.Size(425, 29);
            this.ButtonSaveUsingFileDialog.TabIndex = 1;
            this.ButtonSaveUsingFileDialog.Text = "Schrijf via FileDialog";
            this.ButtonSaveUsingFileDialog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSaveUsingFileDialog.UseVisualStyleBackColor = true;
            this.ButtonSaveUsingFileDialog.Click += new System.EventHandler(this.ButtonSaveUsingFileDialog_Click);
            // 
            // FrmUpdateTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.LblInformationMessage);
            this.Controls.Add(this.ButtonSaveUsingFileDialog);
            this.Controls.Add(this.ButtonSchrijfWeg);
            this.Controls.Add(this.ButtonOpenDialog);
            this.Controls.Add(this.RichTxbTekst);
            this.MaximumSize = new System.Drawing.Size(1500, 750);
            this.Name = "FrmUpdateTextFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aanpassen text file";
            this.Load += new System.EventHandler(this.FrmUpdateTextFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTxbTekst;
        private System.Windows.Forms.Button ButtonOpenDialog;
        private System.Windows.Forms.Button ButtonSchrijfWeg;
        private System.Windows.Forms.Label LblInformationMessage;
        private System.Windows.Forms.Button ButtonSaveUsingFileDialog;
    }
}