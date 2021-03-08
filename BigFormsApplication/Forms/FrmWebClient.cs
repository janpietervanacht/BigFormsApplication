#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed

using BigFormsApplication.DTO_Models;
using BigFormsApplication.Extensions;
using BigFormsApplication.Forms.DataSourceForGridView;
using Business.Interfaces;
using Model;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigFormsApplication.Forms
{
    public partial class FrmWebClient : Form
    {
        private readonly IClientManager _clientManager;
        private readonly IInvoiceManager _invoiceManager;
        private readonly HttpClient _client;

        public FrmWebClient(IClientManager clientManager,
            IInvoiceManager invoiceManager)
        {
            InitializeComponent();
            _clientManager = clientManager;
            _invoiceManager = invoiceManager;
            _client = new HttpClient();
        }

        private void FrmClientenListView_Load(object sender, EventArgs e)
        {
            LabelClientFullName.Visible = false;

            var listClients = _clientManager.GetAll();

            ListViewClienten.Items.Clear();
            foreach (var client in listClients)
            {
                var clientNumber = client.ClientNumber;
                var row = new string[]
                    {
                        clientNumber.ToString(),
                        client.FirstName,
                        _invoiceManager.GetAllByClientNumber(clientNumber).Count().ToString()
                    };
                var listViewItem = new ListViewItem(row)
                {
                    Tag = client // onder water kan je via Tag een volledige Client aan de rij koppelen
                };
                ListViewClienten.Items.Add(listViewItem);
            }
        }

        private void ListViewClienten_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (Client)ListViewClienten.SelectedItems[0].Tag;
                if (selectedItem != null)
                {
                    // DoStuff is gecodeerd binnen deze class (FrmWebClient)
                    // Want WebClients moeten asynchrone Tasks gebruiken voor het
                    // aanroepen van de WebAPI.
                    // DoStuff kan geen output teruggeven maar alleen in de achtergrond
                    // draaien. Daarom moet DoStuff diegene zijn, die de form weer vult
                    // na het inlezen van de facturen
                    DoStuff(selectedItem.ClientNumber);  // Vergelijk met SBMJOB
                }
            }
            catch (Exception)
            {
            }
        }

        public async Task DoStuff(int clientNumber)
        {
            string jsonString;
            LabelClientFullName.Visible = false;

            try
            {
                var Url = "https://localhost:44303/api/v1/invoice/" + clientNumber;
                var stringTask = _client.GetStringAsync(Url);
                jsonString = await stringTask;

                // We gebruiken exact hetzelfde DTO-model voor de client
                // als voor de WebAPI. Ook met dezelfde class namen, anders 
                // worden sommige group-level-tags niet herkend bij het inlezen van de json string

                var invoiceDTOList = JsonConvert.DeserializeObject<InvoiceListDTO>(jsonString);
                // Verwerk het resultaat met DTO invoices in de data grid view rechts:
                // TODO

                var invoiceListDS =
                    invoiceDTOList.ListOfDTOInvoices
                    .Select(inv => new InvoiceDS
                    {
                        InvoiceNumber = inv.InvoiceNumber, 
                        Amount = inv.Amount,
                        FullReferenceInvoice = inv.FullReferenceInvoice,
                        // ClientFullName = c.ClientFullName,
                        InvoiceDescription = inv.InvoiceDescription,
                       
                    }
                    ).ToList();
                DataGridViewInvoicesPerClient.DataSource = invoiceListDS;

                DataGridViewInvoicesPerClient.Columns["InvoiceNumber"].HeaderText = "Fact.nummer";
                DataGridViewInvoicesPerClient.Columns["Amount"].HeaderText = "Bedrag";
                DataGridViewInvoicesPerClient.Columns["FullReferenceInvoice"].HeaderText = "Referentie";
                // DataGridViewInvoicesPerClient.Columns["ClientFullName"].HeaderText = "Volledige naam klant"; 
                DataGridViewInvoicesPerClient.Columns["InvoiceDescription"].HeaderText = "Factuuromschrijving";
                DataGridViewInvoicesPerClient.Columns["InvoiceDescription"].Width = 200; 

                LabelClientFullName.Text = invoiceDTOList.ClientFullName;
                LabelClientFullName.Visible = true; 
            }
            catch
            {
                // Nog ff niets
            }
        }
    }
}

#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
