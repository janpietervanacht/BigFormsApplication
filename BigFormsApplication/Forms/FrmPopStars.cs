using BigFormsApplication.Forms.ViewModels;
using Business.Interfaces;
using System;
using System.Windows.Forms;

namespace BigFormsApplication.Forms
{
    public partial class FrmPopStars : Form
    {
        readonly IClientManager _clientManager;

        public FrmPopStars(IClientManager clientManager)
        {
            InitializeComponent();
            _clientManager = clientManager;
        }

        private void FrmPopStars_Load(object sender, EventArgs e)
        {
            var listClients = _clientManager.GetAll();

            ListBoxPopStarNo.Items.Clear();
            ListBoxPopStarYes.Items.Clear();
            btnArrowToLeft.Enabled = true;
            btnArrowToRight.Enabled = true; 

            // Onder water bij iedere regel plakken
            // we een volledige Client
            // zodat we alle data onder water hebben.
            // We tonen ClientNumber - Voornaam

            ListBoxPopStarNo.DisplayMember = "LineInListBox"; //Prop in ClientVM
            ListBoxPopStarNo.ValueMember = "Client"; //Prop in ClientVM 

            ListBoxPopStarYes.DisplayMember = "LineInListBox";
            ListBoxPopStarYes.ValueMember = "Client";

            foreach (var client in listClients)
            {
                var clientVM = new ClientVM
                {
                    Client = client 
                    // Prop LineInListBox vult zich zelf 
                };

                switch (client.IsPopstar)
                {
                    case true:
                        ListBoxPopStarYes.Items.Add(clientVM);
                        break;
                    case false:
                        ListBoxPopStarNo.Items.Add(clientVM);
                        break;
                    default:
                        throw new Exception("Ongeldige waarde");
                }
            }
        }

        private void btnArrowToRight_Click(object sender, EventArgs e)
        {
            var selectedItems = ListBoxPopStarNo.SelectedItems;
            if (selectedItems.Count == 0)
            {
                return; 
            }

            foreach (var item in selectedItems)
            {
                var clientVM = (ClientVM)item;
                // Verplaats de client naar rechts
                var client = clientVM.Client;
                client.IsPopstar = true;
                client.PopstarYearIncome = 0; // nullable field
                _clientManager.UpdateClient(client);
                
            };
            FrmPopStars_Load(null, null); // Laad opnieuw de pagina
        }

        private void btnArrowToLeft_Click(object sender, EventArgs e)
        {
            var selectedItems = ListBoxPopStarYes.SelectedItems;
            foreach (var item in selectedItems)
            {
                var clientVM = (ClientVM)item;
                // Verplaats de client naar links
                var client = clientVM.Client;
                client.IsPopstar = false;
                client.PopstarYearIncome = null; // nullable field
                _clientManager.UpdateClient(client);
            };
            FrmPopStars_Load(null, null); // Laad opnieuw de pagina
        }

        // Dubbelklik werkt niet goed als de ListBox een SelectionMode = Multiple-Single
        // heeft. Als je klant 1 en 2 blauw maakt, en je dubbelklikt op klant 5
        // dan wordt klant 1 overgestuurd. Geen oplossing op internet gevonden

        //private void ListBoxPopStarNo_DoubleClick(object sender, EventArgs e)
        //{
            
        //}

        private void ListBoxPopStarYes_DoubleClick(object sender, EventArgs e)
        {
            // Gebruik de Double_Click event op ListBox niveau
            // als je op één item dubbelklikt 

            var clientVM = ListBoxPopStarYes.SelectedItem as ClientVM;

            // Als er buiten de lijst wordt gedubbel klikked:
            if (clientVM == null)
            {
                return; 
            }
            // Verplaats de client naar links
            var client = clientVM.Client;
            client.IsPopstar = false;
            client.PopstarYearIncome = null; // nullable field
            _clientManager.UpdateClient(client);
            FrmPopStars_Load(null, null); // Laad opnieuw de pagina
        }

        private void ListBoxPopStarNo_Click(object sender, EventArgs e)
        {
            if (ListBoxPopStarNo.SelectedItems.Count != 0)
            {
                // Er is zeker één item geselecteerd in de lijst links
                // Disable de pijl naar links, enable de pijl naar rechts
                btnArrowToLeft.Enabled = false;
                btnArrowToRight.Enabled = true;
                // Verwijder alle selecties in de rechter listbox
                ListBoxPopStarYes.ClearSelected(); 
            }
            else
            {
                btnArrowToLeft.Enabled = true;
            }
        }

        private void ListBoxPopStarYes_Click(object sender, EventArgs e)
        {

            if (ListBoxPopStarYes.SelectedItems.Count != 0)
            {
                // Er is zeker één item geselecteerd in de lijst links
                // Disable de pijl naar rechts, Enable de pijl naar links
                btnArrowToRight.Enabled = false;
                btnArrowToLeft.Enabled = true;
                // Verwijder alle selecties in de linker listbox
                ListBoxPopStarNo.ClearSelected();
            }
            else
            {
                btnArrowToRight.Enabled = true;
            }
        }
    }
}
