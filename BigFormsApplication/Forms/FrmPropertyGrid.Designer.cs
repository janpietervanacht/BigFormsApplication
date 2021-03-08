using System;
using System.Windows.Forms;

namespace BigFormsApplication.Forms
{
    partial class FrmPropertyGrid : Form
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
            this.ListBoxClients = new System.Windows.Forms.ListBox();
            this.PropertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.PanelWithCustomer = new System.Windows.Forms.Panel();
            this.LabelFirstName2 = new System.Windows.Forms.Label();
            this.LabelFirstName1 = new System.Windows.Forms.Label();
            this.LabelClientNumber2 = new System.Windows.Forms.Label();
            this.LabelClientNumber1 = new System.Windows.Forms.Label();
            this.RichTextBoxForChangedItem = new System.Windows.Forms.RichTextBox();
            this.LabelExplanation = new System.Windows.Forms.Label();
            this.PanelWithCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxClients
            // 
            this.ListBoxClients.FormattingEnabled = true;
            this.ListBoxClients.ItemHeight = 20;
            this.ListBoxClients.Location = new System.Drawing.Point(78, 32);
            this.ListBoxClients.Name = "ListBoxClients";
            this.ListBoxClients.Size = new System.Drawing.Size(269, 524);
            this.ListBoxClients.TabIndex = 0;
            this.ListBoxClients.Click += new System.EventHandler(this.ListBox1_Click);
            this.ListBoxClients.SelectedIndexChanged += new System.EventHandler(this.ListBoxClients_SelectedIndexChanged);
            // 
            // PropertyGrid1
            // 
            this.PropertyGrid1.Location = new System.Drawing.Point(964, 12);
            this.PropertyGrid1.Name = "PropertyGrid1";
            this.PropertyGrid1.Size = new System.Drawing.Size(474, 395);
            this.PropertyGrid1.TabIndex = 2;
            this.PropertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropertyGrid1_PropertyValueChanged);
            this.PropertyGrid1.SelectedGridItemChanged += new System.Windows.Forms.SelectedGridItemChangedEventHandler(this.PropertyGrid1_SelectedGridItemChanged);
            // 
            // PanelWithCustomer
            // 
            this.PanelWithCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PanelWithCustomer.Controls.Add(this.LabelFirstName2);
            this.PanelWithCustomer.Controls.Add(this.LabelFirstName1);
            this.PanelWithCustomer.Controls.Add(this.LabelClientNumber2);
            this.PanelWithCustomer.Controls.Add(this.LabelClientNumber1);
            this.PanelWithCustomer.Location = new System.Drawing.Point(459, 32);
            this.PanelWithCustomer.Name = "PanelWithCustomer";
            this.PanelWithCustomer.Size = new System.Drawing.Size(428, 295);
            this.PanelWithCustomer.TabIndex = 3;
            this.PanelWithCustomer.Click += new System.EventHandler(this.PanelWithCustomer_Click);
            // 
            // LabelFirstName2
            // 
            this.LabelFirstName2.AutoSize = true;
            this.LabelFirstName2.BackColor = System.Drawing.Color.White;
            this.LabelFirstName2.Location = new System.Drawing.Point(30, 214);
            this.LabelFirstName2.Name = "LabelFirstName2";
            this.LabelFirstName2.Size = new System.Drawing.Size(113, 20);
            this.LabelFirstName2.TabIndex = 0;
            this.LabelFirstName2.Text = "Voornaam klant";
            // 
            // LabelFirstName1
            // 
            this.LabelFirstName1.AutoSize = true;
            this.LabelFirstName1.Location = new System.Drawing.Point(30, 174);
            this.LabelFirstName1.Name = "LabelFirstName1";
            this.LabelFirstName1.Size = new System.Drawing.Size(116, 20);
            this.LabelFirstName1.TabIndex = 0;
            this.LabelFirstName1.Text = "Voornaam klant:";
            // 
            // LabelClientNumber2
            // 
            this.LabelClientNumber2.AutoSize = true;
            this.LabelClientNumber2.BackColor = System.Drawing.Color.White;
            this.LabelClientNumber2.Location = new System.Drawing.Point(30, 64);
            this.LabelClientNumber2.Name = "LabelClientNumber2";
            this.LabelClientNumber2.Size = new System.Drawing.Size(98, 20);
            this.LabelClientNumber2.TabIndex = 0;
            this.LabelClientNumber2.Text = "Klantnummer";
            // 
            // LabelClientNumber1
            // 
            this.LabelClientNumber1.AutoSize = true;
            this.LabelClientNumber1.Location = new System.Drawing.Point(30, 37);
            this.LabelClientNumber1.Name = "LabelClientNumber1";
            this.LabelClientNumber1.Size = new System.Drawing.Size(101, 20);
            this.LabelClientNumber1.TabIndex = 0;
            this.LabelClientNumber1.Text = "Klantnummer:";
            // 
            // RichTextBoxForChangedItem
            // 
            this.RichTextBoxForChangedItem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RichTextBoxForChangedItem.Location = new System.Drawing.Point(459, 439);
            this.RichTextBoxForChangedItem.Name = "RichTextBoxForChangedItem";
            this.RichTextBoxForChangedItem.Size = new System.Drawing.Size(979, 244);
            this.RichTextBoxForChangedItem.TabIndex = 4;
            this.RichTextBoxForChangedItem.Text = "";
            // 
            // LabelExplanation
            // 
            this.LabelExplanation.AutoSize = true;
            this.LabelExplanation.Location = new System.Drawing.Point(474, 369);
            this.LabelExplanation.Name = "LabelExplanation";
            this.LabelExplanation.Size = new System.Drawing.Size(87, 20);
            this.LabelExplanation.TabIndex = 0;
            this.LabelExplanation.Text = "Explanation";
            // 
            // FrmPropertyGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.RichTextBoxForChangedItem);
            this.Controls.Add(this.PanelWithCustomer);
            this.Controls.Add(this.PropertyGrid1);
            this.Controls.Add(this.LabelExplanation);
            this.Controls.Add(this.ListBoxClients);
            this.MaximumSize = new System.Drawing.Size(1500, 750);
            this.Name = "FrmPropertyGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPropertyGrid_Load);
            this.PanelWithCustomer.ResumeLayout(false);
            this.PanelWithCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

       
        // Maak TextBoxClient internal, zodat de aanmaak ervan in een extension method kan worden
        // gezet: 
        private ListBox ListBoxClients;
        private PropertyGrid PropertyGrid1;
        private Panel PanelWithCustomer;
        private Label LabelFirstName2;
        private Label LabelFirstName1;
        private Label LabelClientNumber2;
        private Label LabelClientNumber1;
        private RichTextBox RichTextBoxForChangedItem;
        private Label LabelExplanation;
    }
}