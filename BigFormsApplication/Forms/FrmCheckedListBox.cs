using BigFormsApplication.Extensions;
using Business.Interfaces;
using System;
using System.Windows.Forms;

namespace BigFormsApplication.Forms
{
    public partial class FrmCheckedListBox : Form
    {
        readonly IClientManager _clientManager;
        readonly IInvoiceManager _invoiceManager;
        bool _allSelected;

        public FrmCheckedListBox(IClientManager clientManager, IInvoiceManager invoiceManager)
        {
            InitializeComponent();
            _clientManager = clientManager;
            _invoiceManager = invoiceManager;
        }

        private void FrmListBoxExample_Load(object sender, EventArgs e)
        {
            var listClients = _clientManager.GetAll();
            this.Text = "Clienten checked List Box";
            CheckedkListBoxClienten.Items.Clear();
            foreach (var client in listClients)
            {
                var numAlfa6 = client.ClientNumber.ToString().PadLeft(6, '0');
                CheckedkListBoxClienten.Items.Add(numAlfa6 + " -  " + client.FirstName);
            }
        }

        // De ListBoxClienten is multi-select. Dat betekent dat deze listbox niet reageert op
        // 1 geselecteerd item, maar dat er op een extra button moet worden geklikt, nadat er 1 of 
        // meerdere items zijn geselecteerd. 

        // De ListBoxFacturen is single-select. Dat betekent dat het aanklikken van 1 item
        // in deze listbox leidt tot het tonen van de factuurgegevens in de rich text box
        private void ListBoxFacturen_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Invoice kent 8 cijfers
            string curInvoiceNumberAlfa = ListBoxFacturen.SelectedItem.ToString().Substring(0, 8);
            int.TryParse(curInvoiceNumberAlfa, out int curInvoiceNumber);

            var invoice = _invoiceManager.GetByInvoiceNumber(curInvoiceNumber);

            // Stel dat in de tussentijd een andere user deze factuur heeft verwijderd
            // dan komt er invoice == NULL uit bovenstaand statement.
            // Vandaar dat hieronder de NULL propagation is gecodeerd. 
            TxbInvoiceDetail.Text =
                $"Faktuurnummer: {invoice?.InvoiceNumber}\n" +
                $"Faktuuromschrijving: \"{invoice?.InvoiceDescription}\"\n" +
                $"Faktuurbedrag: {invoice?.Amount}\n" +
                $"Faktuurdatum: {invoice?.InvoiceDate.ToDutchDateFormat()}\n" +
                $"Clientnummer: {invoice?.Client.ClientNumber}\n" +
                $"Klantnaam: {invoice?.Client.FirstName} {invoice?.Client.LastName}\n";
        }

        private void BtnShowInvoices_Click(object sender, EventArgs e)
        {
            ListBoxFacturen.Items.Clear();
            TxbInvoiceDetail.Text = "";
            var selectedItems = CheckedkListBoxClienten.CheckedItems;
            foreach (var item in selectedItems)
            {
                // Vul de facturen listbox met de facturen van alle
                // aangevinkte (gecheckte) clienten
                var itemAlfa = (string)item;
                FillListBoxInvoices(itemAlfa);
            }
        }

        private void FillListBoxInvoices(string itemAlfa)
        {
            string curClientNumberAlfa = itemAlfa.Substring(0, 6);
            int.TryParse(curClientNumberAlfa, out int curClientNumber);

            // Haal lijst van facturen op voor deze client, en stuur deze naar de 2e listbox

            var listInvoices = _invoiceManager.GetAllByClientNumber(curClientNumber);

            foreach (var invoice in listInvoices)
            {
                ListBoxFacturen.Items.Add(invoice.InvoiceNumber + " " + invoice.InvoiceDescription);
            }
        }

        private void BtnSelectOrUnselectAll_Click(object sender, EventArgs e)
        {
            if (!_allSelected)
            {
                for (int i = 0; i < CheckedkListBoxClienten.Items.Count; i++)
                {
                    CheckedkListBoxClienten.SetItemChecked(i, true);
                }
                _allSelected = true;
                BtnSelectOrUnSelectAll.Text = "Deselecteer alles";
            }
            else
            {
                for (int i = 0; i < CheckedkListBoxClienten.Items.Count; i++)
                {
                    CheckedkListBoxClienten.SetItemChecked(i, false);
                }
                _allSelected = false;
                BtnSelectOrUnSelectAll.Text = "Selecteer alles";
            }



        }
    }
}
