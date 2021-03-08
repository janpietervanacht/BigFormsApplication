namespace BigFormsApplication.Forms
{
    partial class FrmMainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemClienten = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientenListView = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientenListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientenTreeView = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientenCheckedListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.PopStar2ListBoxes = new System.Windows.Forms.ToolStripMenuItem();
            this.SimpleDragDrop = new System.Windows.Forms.ToolStripMenuItem();
            this.DragDropListBoxToListBox = new System.Windows.Forms.ToolStripMenuItem();
            this.ListViewToListViewPopstars = new System.Windows.Forms.ToolStripMenuItem();
            this.CreatePopStarViaComboBox = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridView = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateTextFile = new System.Windows.Forms.ToolStripMenuItem();
            this.WebClient = new System.Windows.Forms.ToolStripMenuItem();
            this.BackGroundProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.TabPages = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemMore = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPropertyGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonLeaveForm = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemClienten,
            this.MenuItemMore});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1484, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // MenuItemClienten
            // 
            this.MenuItemClienten.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientenListView,
            this.ClientenListBox,
            this.ClientenTreeView,
            this.ClientenCheckedListBox,
            this.PopStar2ListBoxes,
            this.SimpleDragDrop,
            this.DragDropListBoxToListBox,
            this.ListViewToListViewPopstars,
            this.CreatePopStarViaComboBox,
            this.DataGridView,
            this.UpdateTextFile,
            this.WebClient,
            this.BackGroundProcess,
            this.TabPages});
            this.MenuItemClienten.Name = "MenuItemClienten";
            this.MenuItemClienten.Size = new System.Drawing.Size(96, 29);
            this.MenuItemClienten.Text = "Clienten";
            // 
            // ClientenListView
            // 
            this.ClientenListView.Name = "ClientenListView";
            this.ClientenListView.Size = new System.Drawing.Size(353, 30);
            this.ClientenListView.Text = "Clienten in ListView Formaat";
            this.ClientenListView.Click += new System.EventHandler(this.MenuItemClientenListView_Click);
            // 
            // ClientenListBox
            // 
            this.ClientenListBox.Name = "ClientenListBox";
            this.ClientenListBox.Size = new System.Drawing.Size(353, 30);
            this.ClientenListBox.Text = "Clienten in ListBox formaat";
            this.ClientenListBox.Click += new System.EventHandler(this.MenuItemClientenListBox_Click);
            // 
            // ClientenTreeView
            // 
            this.ClientenTreeView.Name = "ClientenTreeView";
            this.ClientenTreeView.Size = new System.Drawing.Size(353, 30);
            this.ClientenTreeView.Text = "Clienten Tree View";
            this.ClientenTreeView.Click += new System.EventHandler(this.MenuItemClientenTreeView_Click);
            // 
            // ClientenCheckedListBox
            // 
            this.ClientenCheckedListBox.Name = "ClientenCheckedListBox";
            this.ClientenCheckedListBox.Size = new System.Drawing.Size(353, 30);
            this.ClientenCheckedListBox.Text = "Clienten Checked List Box";
            this.ClientenCheckedListBox.Click += new System.EventHandler(this.MenuItemClientenCheckedListBox_Click);
            // 
            // PopStar2ListBoxes
            // 
            this.PopStar2ListBoxes.Name = "PopStar2ListBoxes";
            this.PopStar2ListBoxes.Size = new System.Drawing.Size(353, 30);
            this.PopStar2ListBoxes.Text = "Popsterren 2 ListBoxes";
            this.PopStar2ListBoxes.Click += new System.EventHandler(this.MenuItemPopSterListBoxes_Click);
            // 
            // SimpleDragDrop
            // 
            this.SimpleDragDrop.Name = "SimpleDragDrop";
            this.SimpleDragDrop.Size = new System.Drawing.Size(353, 30);
            this.SimpleDragDrop.Text = "Eenvoudige Drag Drop";
            this.SimpleDragDrop.Click += new System.EventHandler(this.MenuItemSimpleDragDrop_Click);
            // 
            // DragDropListBoxToListBox
            // 
            this.DragDropListBoxToListBox.Name = "DragDropListBoxToListBox";
            this.DragDropListBoxToListBox.Size = new System.Drawing.Size(353, 30);
            this.DragDropListBoxToListBox.Text = "Drag Drop ListBox to ListBox ";
            this.DragDropListBoxToListBox.Click += new System.EventHandler(this.MenuItemDragDropListBoxToListBox_Click);
            // 
            // ListViewToListViewPopstars
            // 
            this.ListViewToListViewPopstars.Name = "ListViewToListViewPopstars";
            this.ListViewToListViewPopstars.Size = new System.Drawing.Size(353, 30);
            this.ListViewToListViewPopstars.Text = "Popsterren (2 ListViews)";
            this.ListViewToListViewPopstars.Click += new System.EventHandler(this.MenuItemDragDropListViewToListViewPopstars_Click);
            // 
            // CreatePopStarViaComboBox
            // 
            this.CreatePopStarViaComboBox.Name = "CreatePopStarViaComboBox";
            this.CreatePopStarViaComboBox.Size = new System.Drawing.Size(353, 30);
            this.CreatePopStarViaComboBox.Text = "ComboBox creëer een popster";
            this.CreatePopStarViaComboBox.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.CreatePopStarViaComboBox.Click += new System.EventHandler(this.CreatePopStarViaComboBox_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(353, 30);
            this.DataGridView.Text = "DataGridView";
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // UpdateTextFile
            // 
            this.UpdateTextFile.Name = "UpdateTextFile";
            this.UpdateTextFile.Size = new System.Drawing.Size(353, 30);
            this.UpdateTextFile.Text = "UpdateTextFile";
            this.UpdateTextFile.Click += new System.EventHandler(this.UpdateTextFile_Click);
            // 
            // WebClient
            // 
            this.WebClient.Name = "WebClient";
            this.WebClient.Size = new System.Drawing.Size(353, 30);
            this.WebClient.Text = "WebClient";
            this.WebClient.Click += new System.EventHandler(this.WebClient_Click);
            // 
            // BackGroundProcess
            // 
            this.BackGroundProcess.Name = "BackGroundProcess";
            this.BackGroundProcess.Size = new System.Drawing.Size(353, 30);
            this.BackGroundProcess.Text = "Achtergrond Proces";
            this.BackGroundProcess.Click += new System.EventHandler(this.BackGroundProcess_Click);
            // 
            // TabPages
            // 
            this.TabPages.Name = "TabPages";
            this.TabPages.Size = new System.Drawing.Size(353, 30);
            this.TabPages.Text = "Tab pagina\'s";
            this.TabPages.Click += new System.EventHandler(this.TabPages_Click);
            // 
            // MenuItemMore
            // 
            this.MenuItemMore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemPropertyGrid});
            this.MenuItemMore.Name = "MenuItemMore";
            this.MenuItemMore.Size = new System.Drawing.Size(71, 29);
            this.MenuItemMore.Text = "More";
            // 
            // MenuItemPropertyGrid
            // 
            this.MenuItemPropertyGrid.Name = "MenuItemPropertyGrid";
            this.MenuItemPropertyGrid.Size = new System.Drawing.Size(211, 30);
            this.MenuItemPropertyGrid.Text = "Property Grid";
            this.MenuItemPropertyGrid.Click += new System.EventHandler(this.MenuItemPropertyGrid_Click);
            // 
            // ButtonLeaveForm
            // 
            this.ButtonLeaveForm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonLeaveForm.Location = new System.Drawing.Point(354, 330);
            this.ButtonLeaveForm.Name = "ButtonLeaveForm";
            this.ButtonLeaveForm.Size = new System.Drawing.Size(498, 59);
            this.ButtonLeaveForm.TabIndex = 1;
            this.ButtonLeaveForm.Text = "Verlaat scherm (ESC) werkt niet in main form";
            this.ButtonLeaveForm.UseVisualStyleBackColor = true;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonLeaveForm;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.ButtonLeaveForm);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximumSize = new System.Drawing.Size(1500, 750);
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoofd menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClienten;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMore;
        private System.Windows.Forms.ToolStripMenuItem ClientenListView;
        private System.Windows.Forms.ToolStripMenuItem ClientenListBox;
        private System.Windows.Forms.ToolStripMenuItem ClientenTreeView;
        private System.Windows.Forms.ToolStripMenuItem ClientenCheckedListBox;
        private System.Windows.Forms.ToolStripMenuItem PopStar2ListBoxes;
        private System.Windows.Forms.ToolStripMenuItem SimpleDragDrop;
        private System.Windows.Forms.ToolStripMenuItem DragDropListBoxToListBox;
        private System.Windows.Forms.ToolStripMenuItem ListViewToListViewPopstars;
        private System.Windows.Forms.ToolStripMenuItem CreatePopStarViaComboBox;
        private System.Windows.Forms.ToolStripMenuItem DataGridView;
        private System.Windows.Forms.Button ButtonLeaveForm;
        private System.Windows.Forms.ToolStripMenuItem UpdateTextFile;
        private System.Windows.Forms.ToolStripMenuItem WebClient;
        private System.Windows.Forms.ToolStripMenuItem BackGroundProcess;
        private System.Windows.Forms.ToolStripMenuItem TabPages;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPropertyGrid;
    }
}

