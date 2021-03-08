namespace BigFormsApplication.Forms
{
    partial class FrmDragDropListBoxToListBox
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
            this.Label1 = new System.Windows.Forms.Label();
            this.ListBoxLeft = new System.Windows.Forms.ListBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.ListBoxRight = new System.Windows.Forms.ListBox();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Panel1.Controls.Add(this.ButtonLeaveForm);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.ListBoxLeft);
            this.Panel1.Location = new System.Drawing.Point(45, 43);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(665, 628);
            this.Panel1.TabIndex = 0;
            // 
            // ButtonLeaveForm
            // 
            this.ButtonLeaveForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonLeaveForm.Location = new System.Drawing.Point(51, 554);
            this.ButtonLeaveForm.Name = "ButtonLeaveForm";
            this.ButtonLeaveForm.Size = new System.Drawing.Size(134, 29);
            this.ButtonLeaveForm.TabIndex = 4;
            this.ButtonLeaveForm.Text = "Verlaat scherm";
            this.ButtonLeaveForm.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.Location = new System.Drawing.Point(51, 71);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(174, 23);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "SelectionMode = one";
            // 
            // ListBoxLeft
            // 
            this.ListBoxLeft.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxLeft.FormattingEnabled = true;
            this.ListBoxLeft.ItemHeight = 19;
            this.ListBoxLeft.Location = new System.Drawing.Point(51, 117);
            this.ListBoxLeft.Name = "ListBoxLeft";
            this.ListBoxLeft.Size = new System.Drawing.Size(564, 384);
            this.ListBoxLeft.TabIndex = 2;
            this.ListBoxLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBoxLeft_MouseDown);
            // 
            // Panel2
            // 
            this.Panel2.AllowDrop = true;
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Panel2.Controls.Add(this.Label3);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.ListBoxRight);
            this.Panel2.Location = new System.Drawing.Point(818, 43);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(631, 628);
            this.Panel2.TabIndex = 0;
            this.Panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel2_DragEnter);
            this.Panel2.MouseLeave += new System.EventHandler(this.Panel2_MouseLeave);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label3.ForeColor = System.Drawing.Color.Red;
            this.Label3.Location = new System.Drawing.Point(51, 31);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(238, 23);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Sleep uw klant naar hieronder";
            this.Label3.Visible = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(51, 71);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(177, 23);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "SelectionMode = One";
            // 
            // ListBoxRight
            // 
            this.ListBoxRight.AllowDrop = true;
            this.ListBoxRight.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxRight.FormattingEnabled = true;
            this.ListBoxRight.ItemHeight = 19;
            this.ListBoxRight.Location = new System.Drawing.Point(51, 117);
            this.ListBoxRight.Name = "ListBoxRight";
            this.ListBoxRight.Size = new System.Drawing.Size(545, 384);
            this.ListBoxRight.TabIndex = 2;
            this.ListBoxRight.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBoxRight_DragDrop);
            this.ListBoxRight.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBoxRight_DragEnter);
            // 
            // FrmDragDropListBoxToListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonLeaveForm;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximumSize = new System.Drawing.Size(1500, 750);
            this.Name = "FrmDragDropListBoxToListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drag drop van ListBox naar ListBox";
            this.Load += new System.EventHandler(this.FrmDragDropListBoxToListBox_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.ListBox ListBoxLeft;
        private System.Windows.Forms.ListBox ListBoxRight;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Button ButtonLeaveForm;
    }
}

