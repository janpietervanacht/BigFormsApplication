using System;
using System.Windows.Forms;

namespace BigFormsApplication.Forms
{
    partial class FrmTabPages: Form
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPageBlue = new System.Windows.Forms.TabPage();
            this.ButtonCreateTabPageListClients = new System.Windows.Forms.Button();
            this.ButtonRemoveLastTabPage = new System.Windows.Forms.Button();
            this.ButtonAddTabPage = new System.Windows.Forms.Button();
            this.LabelBlauw1 = new System.Windows.Forms.Label();
            this.TabPageOrange = new System.Windows.Forms.TabPage();
            this.LabelOrange1 = new System.Windows.Forms.Label();
            this.TabYellow = new System.Windows.Forms.TabPage();
            this.LabelYellow1 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.TabPageBlue.SuspendLayout();
            this.TabPageOrange.SuspendLayout();
            this.TabYellow.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPageBlue);
            this.TabControl.Controls.Add(this.TabPageOrange);
            this.TabControl.Controls.Add(this.TabYellow);
            this.TabControl.Location = new System.Drawing.Point(66, 62);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 2;
            this.TabControl.Size = new System.Drawing.Size(1200, 600);
            this.TabControl.TabIndex = 0;
            // 
            // TabPageBlue
            // 
            this.TabPageBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TabPageBlue.Controls.Add(this.ButtonCreateTabPageListClients);
            this.TabPageBlue.Controls.Add(this.ButtonRemoveLastTabPage);
            this.TabPageBlue.Controls.Add(this.ButtonAddTabPage);
            this.TabPageBlue.Controls.Add(this.LabelBlauw1);
            this.TabPageBlue.Location = new System.Drawing.Point(4, 29);
            this.TabPageBlue.Name = "TabPageBlue";
            this.TabPageBlue.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageBlue.Size = new System.Drawing.Size(763, 378);
            this.TabPageBlue.TabIndex = 0;
            this.TabPageBlue.Text = "Blauw";
            // 
            // ButtonCreateTabPageListClients
            // 
            this.ButtonCreateTabPageListClients.Location = new System.Drawing.Point(25, 174);
            this.ButtonCreateTabPageListClients.Name = "ButtonCreateTabPageListClients";
            this.ButtonCreateTabPageListClients.Size = new System.Drawing.Size(280, 29);
            this.ButtonCreateTabPageListClients.TabIndex = 1;
            this.ButtonCreateTabPageListClients.Text = "Maak tab met clientenListView";
            this.ButtonCreateTabPageListClients.UseVisualStyleBackColor = true;
            this.ButtonCreateTabPageListClients.Click += new System.EventHandler(this.ButtonCreateTabPageListClients_Click);
            // 
            // ButtonRemoveLastTabPage
            // 
            this.ButtonRemoveLastTabPage.Location = new System.Drawing.Point(25, 119);
            this.ButtonRemoveLastTabPage.Name = "ButtonRemoveLastTabPage";
            this.ButtonRemoveLastTabPage.Size = new System.Drawing.Size(280, 29);
            this.ButtonRemoveLastTabPage.TabIndex = 1;
            this.ButtonRemoveLastTabPage.Text = "Verwijder laatste tab page";
            this.ButtonRemoveLastTabPage.UseVisualStyleBackColor = true;
            this.ButtonRemoveLastTabPage.Click += new System.EventHandler(this.ButtonRemoveLastTabPage_Click);
            // 
            // ButtonAddTabPage
            // 
            this.ButtonAddTabPage.Location = new System.Drawing.Point(25, 70);
            this.ButtonAddTabPage.Name = "ButtonAddTabPage";
            this.ButtonAddTabPage.Size = new System.Drawing.Size(281, 29);
            this.ButtonAddTabPage.TabIndex = 1;
            this.ButtonAddTabPage.Text = "Voeg paars tabblad toe";
            this.ButtonAddTabPage.UseVisualStyleBackColor = true;
            this.ButtonAddTabPage.Click += new System.EventHandler(this.ButtonAddTabPage_Click);
            // 
            // LabelBlauw1
            // 
            this.LabelBlauw1.AutoSize = true;
            this.LabelBlauw1.Location = new System.Drawing.Point(25, 32);
            this.LabelBlauw1.Name = "LabelBlauw1";
            this.LabelBlauw1.Size = new System.Drawing.Size(139, 20);
            this.LabelBlauw1.TabIndex = 0;
            this.LabelBlauw1.Text = "De blauwe TabPage";
            // 
            // TabPageOrange
            // 
            this.TabPageOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TabPageOrange.Controls.Add(this.LabelOrange1);
            this.TabPageOrange.Location = new System.Drawing.Point(4, 29);
            this.TabPageOrange.Name = "TabPageOrange";
            this.TabPageOrange.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageOrange.Size = new System.Drawing.Size(763, 378);
            this.TabPageOrange.TabIndex = 1;
            this.TabPageOrange.Text = "Oranje";
            // 
            // LabelOrange1
            // 
            this.LabelOrange1.AutoSize = true;
            this.LabelOrange1.Location = new System.Drawing.Point(32, 30);
            this.LabelOrange1.Name = "LabelOrange1";
            this.LabelOrange1.Size = new System.Drawing.Size(50, 20);
            this.LabelOrange1.TabIndex = 0;
            this.LabelOrange1.Text = "label1";
            // 
            // TabYellow
            // 
            this.TabYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TabYellow.Controls.Add(this.LabelYellow1);
            this.TabYellow.ForeColor = System.Drawing.Color.Black;
            this.TabYellow.Location = new System.Drawing.Point(4, 29);
            this.TabYellow.Name = "TabYellow";
            this.TabYellow.Padding = new System.Windows.Forms.Padding(3);
            this.TabYellow.Size = new System.Drawing.Size(763, 378);
            this.TabYellow.TabIndex = 2;
            this.TabYellow.Text = "Geel";
            // 
            // LabelYellow1
            // 
            this.LabelYellow1.AutoSize = true;
            this.LabelYellow1.Location = new System.Drawing.Point(22, 17);
            this.LabelYellow1.Name = "LabelYellow1";
            this.LabelYellow1.Size = new System.Drawing.Size(50, 20);
            this.LabelYellow1.TabIndex = 0;
            this.LabelYellow1.Text = "label1";
            // 
            // FrmTabPages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.TabControl);
            this.MaximumSize = new System.Drawing.Size(1500, 750);
            this.Name = "FrmTabPages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tab bladen";
            this.Load += new System.EventHandler(this.FrmTabPages_Load);
            this.TabControl.ResumeLayout(false);
            this.TabPageBlue.ResumeLayout(false);
            this.TabPageBlue.PerformLayout();
            this.TabPageOrange.ResumeLayout(false);
            this.TabPageOrange.PerformLayout();
            this.TabYellow.ResumeLayout(false);
            this.TabYellow.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.ListView ListViewClients; // wordt dynamisch gemaakt na een klik
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabPageBlue;
        private System.Windows.Forms.TabPage TabPageOrange;
        private System.Windows.Forms.Label LabelBlauw1;
        private System.Windows.Forms.Label LabelOrange1;
        private System.Windows.Forms.TabPage TabYellow;
        private System.Windows.Forms.Label LabelYellow1;
        private System.Windows.Forms.Button ButtonAddTabPage;
        private System.Windows.Forms.Button ButtonRemoveLastTabPage;
        private System.Windows.Forms.Button ButtonCreateTabPageListClients;
        private System.Windows.Forms.ColumnHeader ClientNumber;
        private System.Windows.Forms.ColumnHeader ClientFullName;
        // Maak TextBoxClient internal, zodat de aanmaak ervan in een extension method kan worden
        // gezet: 
        internal System.Windows.Forms.RichTextBox TextBoxClient;
    }
}