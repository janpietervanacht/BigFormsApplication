namespace BigFormsApplication.Forms
{
    partial class FrmPopStars
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
            this.ListBoxPopStarNo = new System.Windows.Forms.ListBox();
            this.ListBoxPopStarYes = new System.Windows.Forms.ListBox();
            this.lblPopStarNo = new System.Windows.Forms.Label();
            this.lblPopStarYes = new System.Windows.Forms.Label();
            this.btnArrowToRight = new System.Windows.Forms.Button();
            this.btnArrowToLeft = new System.Windows.Forms.Button();
            this.lblSelectionMode1 = new System.Windows.Forms.Label();
            this.lblSelectionMode2 = new System.Windows.Forms.Label();
            this.lblExplanation1 = new System.Windows.Forms.Label();
            this.labelExplanation2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBoxPopStarNo
            // 
            this.ListBoxPopStarNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxPopStarNo.FormattingEnabled = true;
            this.ListBoxPopStarNo.ItemHeight = 23;
            this.ListBoxPopStarNo.Location = new System.Drawing.Point(47, 94);
            this.ListBoxPopStarNo.Name = "ListBoxPopStarNo";
            this.ListBoxPopStarNo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ListBoxPopStarNo.Size = new System.Drawing.Size(447, 510);
            this.ListBoxPopStarNo.TabIndex = 0;
            this.ListBoxPopStarNo.Click += new System.EventHandler(this.ListBoxPopStarNo_Click);
            // 
            // ListBoxPopStarYes
            // 
            this.ListBoxPopStarYes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxPopStarYes.FormattingEnabled = true;
            this.ListBoxPopStarYes.ItemHeight = 23;
            this.ListBoxPopStarYes.Location = new System.Drawing.Point(694, 94);
            this.ListBoxPopStarYes.Name = "ListBoxPopStarYes";
            this.ListBoxPopStarYes.Size = new System.Drawing.Size(480, 510);
            this.ListBoxPopStarYes.TabIndex = 0;
            this.ListBoxPopStarYes.Click += new System.EventHandler(this.ListBoxPopStarYes_Click);
            this.ListBoxPopStarYes.DoubleClick += new System.EventHandler(this.ListBoxPopStarYes_DoubleClick);
            // 
            // lblPopStarNo
            // 
            this.lblPopStarNo.AutoSize = true;
            this.lblPopStarNo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPopStarNo.Location = new System.Drawing.Point(47, 9);
            this.lblPopStarNo.Name = "lblPopStarNo";
            this.lblPopStarNo.Size = new System.Drawing.Size(269, 25);
            this.lblPopStarNo.TabIndex = 1;
            this.lblPopStarNo.Text = "Clienten die geen  popster zijn";
            // 
            // lblPopStarYes
            // 
            this.lblPopStarYes.AutoSize = true;
            this.lblPopStarYes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPopStarYes.Location = new System.Drawing.Point(694, 9);
            this.lblPopStarYes.Name = "lblPopStarYes";
            this.lblPopStarYes.Size = new System.Drawing.Size(251, 25);
            this.lblPopStarYes.TabIndex = 1;
            this.lblPopStarYes.Text = "Clienten die wèl popster zijn";
            // 
            // btnArrowToRight
            // 
            this.btnArrowToRight.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnArrowToRight.Location = new System.Drawing.Point(518, 212);
            this.btnArrowToRight.Name = "btnArrowToRight";
            this.btnArrowToRight.Size = new System.Drawing.Size(146, 57);
            this.btnArrowToRight.TabIndex = 2;
            this.btnArrowToRight.Text = "---->";
            this.btnArrowToRight.UseVisualStyleBackColor = true;
            this.btnArrowToRight.Click += new System.EventHandler(this.btnArrowToRight_Click);
            // 
            // btnArrowToLeft
            // 
            this.btnArrowToLeft.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnArrowToLeft.Location = new System.Drawing.Point(518, 325);
            this.btnArrowToLeft.Name = "btnArrowToLeft";
            this.btnArrowToLeft.Size = new System.Drawing.Size(146, 57);
            this.btnArrowToLeft.TabIndex = 2;
            this.btnArrowToLeft.Text = "<----";
            this.btnArrowToLeft.UseVisualStyleBackColor = true;
            this.btnArrowToLeft.Click += new System.EventHandler(this.btnArrowToLeft_Click);
            // 
            // lblSelectionMode1
            // 
            this.lblSelectionMode1.AutoSize = true;
            this.lblSelectionMode1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectionMode1.Location = new System.Drawing.Point(47, 55);
            this.lblSelectionMode1.Name = "lblSelectionMode1";
            this.lblSelectionMode1.Size = new System.Drawing.Size(234, 19);
            this.lblSelectionMode1.TabIndex = 3;
            this.lblSelectionMode1.Text = "SelectionMode ListBox=Multi-Simple";
            // 
            // lblSelectionMode2
            // 
            this.lblSelectionMode2.AutoSize = true;
            this.lblSelectionMode2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectionMode2.Location = new System.Drawing.Point(694, 54);
            this.lblSelectionMode2.Name = "lblSelectionMode2";
            this.lblSelectionMode2.Size = new System.Drawing.Size(182, 19);
            this.lblSelectionMode2.TabIndex = 3;
            this.lblSelectionMode2.Text = "SelectionMode ListBox=One";
            // 
            // lblExplanation1
            // 
            this.lblExplanation1.AutoSize = true;
            this.lblExplanation1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExplanation1.ForeColor = System.Drawing.Color.Red;
            this.lblExplanation1.Location = new System.Drawing.Point(305, 55);
            this.lblExplanation1.Name = "lblExplanation1";
            this.lblExplanation1.Size = new System.Drawing.Size(193, 19);
            this.lblExplanation1.TabIndex = 3;
            this.lblExplanation1.Text = "Geen dbl-click bij multi-simple";
            this.lblExplanation1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelExplanation2
            // 
            this.labelExplanation2.AutoSize = true;
            this.labelExplanation2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelExplanation2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelExplanation2.Location = new System.Drawing.Point(881, 54);
            this.labelExplanation2.Name = "labelExplanation2";
            this.labelExplanation2.Size = new System.Drawing.Size(141, 19);
            this.labelExplanation2.TabIndex = 3;
            this.labelExplanation2.Text = "Wel dbl-click bij \'One\"";
            this.labelExplanation2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // FrmPopStars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.lblSelectionMode2);
            this.Controls.Add(this.labelExplanation2);
            this.Controls.Add(this.lblExplanation1);
            this.Controls.Add(this.lblSelectionMode1);
            this.Controls.Add(this.btnArrowToLeft);
            this.Controls.Add(this.btnArrowToRight);
            this.Controls.Add(this.lblPopStarNo);
            this.Controls.Add(this.lblPopStarYes);
            this.Controls.Add(this.ListBoxPopStarYes);
            this.Controls.Add(this.ListBoxPopStarNo);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximumSize = new System.Drawing.Size(1500, 750);
            this.Name = "FrmPopStars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popsterren 2 ListBoxes";
            this.Load += new System.EventHandler(this.FrmPopStars_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxPopStarNo;
        private System.Windows.Forms.ListBox ListBoxPopStarYes;
        private System.Windows.Forms.Label lblPopStarNo;
        private System.Windows.Forms.Label lblPopStarYes;
        private System.Windows.Forms.Button btnArrowToRight;
        private System.Windows.Forms.Button btnArrowToLeft;
        private System.Windows.Forms.Label lblSelectionMode1;
        private System.Windows.Forms.Label lblSelectionMode2;
        private System.Windows.Forms.Label lblExplanation1;
        private System.Windows.Forms.Label labelExplanation2;
    }
}

