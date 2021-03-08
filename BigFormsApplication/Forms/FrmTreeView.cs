using BigFormsApplication.Extensions;
using Business.Interfaces;
using Model;
using System;
using System.Windows.Forms;

namespace BigFormsApplication.Forms
{
    public partial class FrmTreeView : Form
    {
        private readonly IClientManager _clientManager;
        private readonly IInvoiceManager _invoiceManager;
        bool _checked;
        bool _treeIsExpanded;

        public FrmTreeView(IClientManager clientManager,
            IInvoiceManager invoiceManager)
        {
            InitializeComponent();
            _clientManager = clientManager;
            _invoiceManager = invoiceManager;
        }

        private void FrmClientenTreeView_Load(object sender, EventArgs e)
        {
            _checked = false;
            ChkBoxShowInvoiceDetails.Checked = false;
            btnExpandCollapseAll.Text = "Expand All";
            _treeIsExpanded = false; 

            var clientList = _clientManager.GetAll();
            int indexClient = 0;
            foreach (var client in clientList)
            {
                treeView1.Nodes.Add(client.FirstName + " " + client.LastName);
                AddChildsWithInvoicesToClient(client, indexClient);
                indexClient++;
            }
        }

        private void AddChildsWithInvoicesToClient(Client client, int indexClient)
        {
            var invList = _invoiceManager.GetAll(client.Id);
            int n = 0;
            foreach (var invoice in invList)
            {
                treeView1.Nodes[indexClient].Nodes.Add(invoice.InvoiceNumber.ToString().PadLeft(8));
                // Add 3 invoice details one level deeper: 
                treeView1.Nodes[indexClient].Nodes[n].Nodes.Add($"1. Faktuur omschrijving: {invoice.InvoiceDescription}");
                treeView1.Nodes[indexClient].Nodes[n].Nodes.Add($"2. Faktuur datum: {invoice.DueDate.ToDutchDateFormat()}");
                treeView1.Nodes[indexClient].Nodes[n].Nodes.Add($"2. Faktuur bedrag: {invoice.Amount}");
                n++;
            }

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs treeViewEventArgs)
        {
            // Levels: 0, 1, 2 - reageer alleen op niveau 2 en toon de factuurdetails in de rich text box: 
            if (treeViewEventArgs.Node.Level == 2 && _checked) // CheckBox is aangevinkt
            {
                // Haal het factuurnummer op uit de parent node: 
                bool ok = int.TryParse(treeViewEventArgs.Node.Parent.Text, out int invoiceNumber);
                if (ok)
                {
                    // Vul de tekstbox met alle factuurdata:
                    var invoice = _invoiceManager.GetByInvoiceNumber(invoiceNumber);
                    txbInvoiceDetails.Text =
                        $"Factuurnummer: {invoice.InvoiceNumber}\n" +
                        $"Factuuromschrijving: {invoice.InvoiceDescription}\n" +
                        $"Factuurdatum: {invoice.InvoiceDate.ToDutchDateFormat()}\n" +
                        $"Vervaldatum: {invoice.DueDate.ToString("yyyy-MM-dd")}\n" +
                        $"Vervaldatum: {invoice.InvoiceSend}\n";
                }
            }
            else // Node.Level <> 2 OF checkbox staat uit
            {
                txbInvoiceDetails.Clear();
            }

        }

        private void treeView1_AfterExpand(object sender, TreeViewEventArgs treeViewEventArgs)
        {
            if (treeViewEventArgs.Node.Level == 0 &&
                //treeViewEventArgs.Node.Text.ToLower().Contains("milena")
                treeViewEventArgs.Node.Text.Contains("milena", StringComparison.CurrentCultureIgnoreCase)  
                )
            // Alleen bij Milena volledig uitklappen van de tree
            {
                treeViewEventArgs.Node.ExpandAll();
                treeViewEventArgs.Node.Text = "Milena Expands";
            }
        }

        private void ChkBoxShowInvoiceDetails_CheckedChanged(object sender, EventArgs e)
        {
            _checked = !_checked;  // Checkbox status omdraaien via private field _checked: 
            if (!_checked)
            {
                txbInvoiceDetails.Clear();
            }

        }

        private void btnExpandCollapseAll_Click(object sender, EventArgs e)
        {
            if (_treeIsExpanded)
            {
                btnExpandCollapseAll.Text = "Expand All";
                _treeIsExpanded = false;
                treeView1.CollapseAll(); 

            }
            else
            {
                btnExpandCollapseAll.Text = "Collapse All";
                _treeIsExpanded = true;
                treeView1.ExpandAll();
            }

        }
    }
}
