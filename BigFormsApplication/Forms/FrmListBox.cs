using BigFormsApplication.Extensions;
using BigFormsApplication.Forms.ViewModels;
using Business.Interfaces;
using System;
using System.Windows.Forms;

namespace BigFormsApplication.Forms
{
    public partial class FrmListBox : Form
    {
        readonly IClientManager _clientManager;
        readonly IInvoiceManager _invoiceManager;

        public FrmListBox(IClientManager clientManager, IInvoiceManager invoiceManager)
        {
            InitializeComponent();
            _clientManager = clientManager;
            _invoiceManager = invoiceManager;
        }

        private void FrmListBoxExample_Load(object sender, EventArgs e)
        {
            // De ListBoxClienten is multi-select. Dat betekent dat deze listbox niet reageert op
            // 1 geselecteerd item, maar dat er op een extra button moet worden geklikt, nadat er 1 of 
            // meerdere items zijn geselecteerd. 

            var listClients = _clientManager.GetAll();
            ListBoxClienten.Items.Clear();

            ListBoxClienten.ValueMember = "Client"; // Prop uit ClientVM
            ListBoxClienten.DisplayMember = "LineInListBox"; // Get prop uit ClientVM, moet een string zijn

            foreach (var client in listClients)
            {
                var clientVM = new ClientVM 
                {
                      Client = client
                     // ,  LineInListBox is een get property die zichzelf invult
                };

                ListBoxClienten.Items.Add(clientVM);
            }
        }

        // De ListBoxFacturen is single-select. Dat betekent dat het aanklikken van 1 item
        // in deze listbox leidt tot het tonen van de factuurgegevens in de rich text box
        private void ListBoxFacturen_SelectedIndexChanged(object sender, EventArgs e)
        {
            var invoiceVM = ListBoxFacturen.SelectedItem as InvoiceVM;

            var inv = invoiceVM?.Invoice;
            // Stel dat in de tussentijd een andere user deze factuur heeft verwijderd
            // dan komt er invoiceVM == NULL uit bovenstaand statement.
            // Vandaar dat hieronder de NULL propagation is gecodeerd. 
            txbInvoiceDetail.Text =
                $"Faktuurnummer: {inv?.InvoiceNumber}\n" +
                $"Faktuuromschrijving: \"{inv?.InvoiceDescription}\"\n" +
                $"Faktuurbedrag: {inv?.Amount}\n" +
                $"Faktuurdatum: {inv?.InvoiceDate.ToDutchDateFormat()}\n" +
                $"Clientnummer: {inv?.Client.ClientNumber}\n" +
                $"Klantnaam: {inv?.Client.FirstName} {inv?.Client.LastName}\n"; 
        }

        private void BtnShowInvoices_Click(object sender, EventArgs e)
        {
            // De ListBoxClienten kent een Selection Mode = Multi Simple
            // Multi-simple: meerdere clienten selecteren met alleen de muis
            // Er bestaat ook Selection Mode = Multi Extended, dan moet je de 
            // CTRL of SHIFT toets ook gebruiken om meerdere clienten te selecteren

            // We selecteren meerderen clienten, en kunnen daarna met de button
            // De facturen van al deze clienten ophalen, en deze tonen
            // in ListBoxInvoices.
           
            ListBoxFacturen.Items.Clear();
            txbInvoiceDetail.Text = "";

            // selectedItems bevat alle geselecteerde strings
            var selectedItems = ListBoxClienten.SelectedItems; 
            foreach (var item in selectedItems)
            {
                // Vul de facturen listbox met de facturen van alle
                // geselecteerde clienten
                var clientVM = (ClientVM)item;

                FillListBoxInvoices(clientVM.Client.Id); 
            }
        }

        private void FillListBoxInvoices(int clientId)
        {

            // Haal lijst van facturen op voor deze client, en stuur deze naar de 2e listbox

            var listInvoices = _invoiceManager.GetAll(clientId);

            ListBoxFacturen.ValueMember = "Invoice"; // Prop uit InvoiceVM
            ListBoxFacturen.DisplayMember = "LineInListBox"; // Prop uit InvoiceVM


            foreach (var invoice in listInvoices)
            {
                var invoiceVM = new InvoiceVM
                {
                    Invoice = invoice
                    , // LineInListBox vult zich vanzelf viaE GET property
                }; 
                ListBoxFacturen.Items.Add(invoiceVM);
            }
        }
    }
}
