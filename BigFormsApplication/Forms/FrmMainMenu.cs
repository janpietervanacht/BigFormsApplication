using BigFormsApplication.DependencyInfra;
using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigFormsApplication.Forms
{
    public partial class FrmMainMenu : Form
    {
        readonly IClientManager _clientManager;
        readonly IInvoiceManager _invoiceManager;

        public FrmMainMenu()
        {
            InitializeComponent();
            // Dependency injection doe je één keer, namelijk in dit startscherm
            // We moeten werken met de out variabelen, dat zijn allemaal nieuwe managers
            // Dit principe van out variabelen moet ook voor DI bij het background project
            // dat een console project is.

            // DI: in de constructor van een object zitten alle objecten die dit object
            // gebruikt. Al deze objecten zijn geadministreerd als DI.
            Dependency.InitialiseerDI(out _clientManager,
            out _invoiceManager);  // Vraag Peter TODO hoe deze 2 te resolven


            //++++++++++++++++++++++++++++++++++++++++++
            // Als je meteen naar je form wil springen:
            //var frmPropertyGrid = new FrmPropertyGrid(_clientManager, _invoiceManager);
            //frmPropertyGrid.ShowDialog();

            //++++++++++++++++++++++++++++++++++++++++++
        }

        private void MenuItemClientenListView_Click(object sender, EventArgs e)
        {
            var frmClientenListView = new FrmClientenListView(_clientManager);
            frmClientenListView.ShowDialog(); // Modal form (lock parent form)

        }

        private void MenuItemClientenListBox_Click(object sender, EventArgs e)
        {
            var frmListBoxExample = new FrmListBox(_clientManager, _invoiceManager);
            frmListBoxExample.ShowDialog(); // Modal form (lock parent form)
        }

        private void MenuItemClientenTreeView_Click(object sender, EventArgs e)
        {
            var frmClientenTreeView = new FrmTreeView(_clientManager, _invoiceManager);
            frmClientenTreeView.ShowDialog(); // Modal form (lock parent form)
        }

        private void MenuItemClientenCheckedListBox_Click(object sender, EventArgs e)
        {
            var frmCheckedListBox = new FrmCheckedListBox(_clientManager, _invoiceManager);
            frmCheckedListBox.ShowDialog(); // Modal form (lock parent form)
        }

        private void MenuItemPopSterListBoxes_Click(object sender, EventArgs e)
        {
            var frmPopStars = new FrmPopStars(_clientManager);
            frmPopStars.ShowDialog(); // Modal form (lock parent form)
        }

        private void MenuItemSimpleDragDrop_Click(object sender, EventArgs e)
        {
            var frmPopStars = new FrmSimpleDragDrop();
            frmPopStars.ShowDialog(); // Modal form (lock parent form)
        }

        private void MenuItemDragDropListBoxToListBox_Click(object sender, EventArgs e)
        {
            var frmDragDropListViewToListView = new FrmDragDropListBoxToListBox(_clientManager);
            frmDragDropListViewToListView.ShowDialog(); // Modal form (lock parent form)
        }

        private void MenuItemDragDropListViewToListViewPopstars_Click(object sender, EventArgs e)
        {
            var frmDragDropListViewToListView = new FrmListViewToListView(_clientManager);
            frmDragDropListViewToListView.ShowDialog();
        }

        private void CreatePopStarViaComboBox_Click(object sender, EventArgs e)
        {
            var frmCreatePopStarWithComboBox = new FrmCreatePopStarWithComboBox(_clientManager);
            frmCreatePopStarWithComboBox.ShowDialog();
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            var frmDataGridView = new FrmDataGridViewReadOnly(_clientManager);
            frmDataGridView.ShowDialog();
        }

        private void UpdateTextFile_Click(object sender, EventArgs e)
        {
            var frmUpdateTextFile = new FrmUpdateTextFile();
            frmUpdateTextFile.ShowDialog();
        }

        private void WebClient_Click(object sender, EventArgs e)
        {
            var frmWebClient = new FrmWebClient(_clientManager, _invoiceManager);
            frmWebClient.ShowDialog();
        }

        private void BackGroundProcess_Click(object sender, EventArgs e)
        {
            var frmBackGroundProcess = new FrmBackGroundProcess();
            frmBackGroundProcess.ShowDialog();
        }

        private void TabPages_Click(object sender, EventArgs e)
        {
            var frmTabPages = new FrmTabPages(_clientManager, _invoiceManager);
            frmTabPages.ShowDialog();
        }

        private void MenuItemPropertyGrid_Click(object sender, EventArgs e)
        {
            var frmPropertyGrid = new FrmPropertyGrid(_clientManager, _invoiceManager);
            frmPropertyGrid.ShowDialog();
        }
    }
}
