namespace BigFormsApplication.Forms
{
    partial class FrmSimpleDragDrop
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
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Panel1.Controls.Add(this.TextBox1);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(45, 43);
            this.Panel1.Name = "panel1";
            this.Panel1.Size = new System.Drawing.Size(665, 628);
            this.Panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(51, 131);
            this.TextBox1.MaximumSize = new System.Drawing.Size(200, 52);
            this.TextBox1.Name = "textBox1";
            this.TextBox1.Size = new System.Drawing.Size(200, 52);
            this.TextBox1.TabIndex = 1;
            this.TextBox1.Text = "Start tekst ";
            this.TextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TextBox1_MouseDown);
            // 
            // label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Label1.Location = new System.Drawing.Point(51, 62);
            this.Label1.Name = "label1";
            this.Label1.Size = new System.Drawing.Size(159, 46);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "TextFrom";
            this.Label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            // 
            // label2
            // 
            this.Label2.AllowDrop = true;
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Label2.Location = new System.Drawing.Point(51, 62);
            this.Label2.Name = "label2";
            this.Label2.Size = new System.Drawing.Size(116, 46);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "TextTo";
            this.Label2.DragDrop += new System.Windows.Forms.DragEventHandler(this.Label2_DragDrop);
            this.Label2.DragEnter += new System.Windows.Forms.DragEventHandler(this.Label2_DragEnter);
            this.Label2.MouseLeave += new System.EventHandler(this.Label2_MouseLeave);
            // 
            // panel2
            // 
            this.Panel2.AllowDrop = true;
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Location = new System.Drawing.Point(818, 43);
            this.Panel2.Name = "panel2";
            this.Panel2.Size = new System.Drawing.Size(631, 628);
            this.Panel2.TabIndex = 0;
            this.Panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.Panel2_DragEnter);
            // 
            // FrmSimpleDragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximumSize = new System.Drawing.Size(1500, 750);
            this.Name = "FrmSimpleDragDrop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Een simpele drag drop";
            this.Load += new System.EventHandler(this.FrmSimpleDragDrop_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Panel Panel2;
    }
}

