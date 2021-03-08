using BigFormsApplication.Forms.ViewModels;
using Business.Interfaces;
using Model;
using Model.ConstantsAndEnums;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BigFormsApplication.Forms
{
    public partial class FrmCreatePopStarWithComboBox : Form
    {
        readonly IClientManager _clientManager;

        public FrmCreatePopStarWithComboBox(IClientManager clientManager)
        {
            // Zet de View property van een ListView op Details
            InitializeComponent();
            _clientManager = clientManager;
        }

        private void FrmCreatePopStarWithComboBox_Load(object sender, EventArgs e)
        {
            // Maak eerst de combo-box leeg
            ComboBoxClientsDirect.Items.Clear();
            ComboBoxClientsIndirect.Items.Clear();

            ComboBoxClientsDirect.Text = "Kies klant voor direct, knul";
            ComboBoxClientsIndirect.Text = "Kies klant voor indirect, knul";

            var clientList = _clientManager
                .GetAll(); 

            ComboBoxClientsIndirect.ValueMember = "Client";
            ComboBoxClientsIndirect.DisplayMember = "LineInListBox";
            ComboBoxClientsDirect.ValueMember = "Client";
            ComboBoxClientsDirect.DisplayMember = "LineInListBox";

            ListViewPopstars.Items.Clear();

            foreach (var client in clientList)
            {
                if (client.IsPopstar == false)
                {
                    // Vul comboboxes linkerkant
                    var clientVM = new ClientVM
                    {
                        Client = client,
                        //LineInListBox wordt vanzelf gevuld, is Get Prop
                    };
                    ComboBoxClientsIndirect.Items.Add(clientVM);
                    ComboBoxClientsDirect.Items.Add(clientVM);
                }
                else
                {
                    // Vul listview rechterkant
                    var row = new string[]
                    {
                        client.ClientNumber.ToString(),
                        client.FirstName,
                        client.BirthDate.ToString("dd MMM yyyy",  Const.cCultureDutch)  
                    };
                    var listViewItem = new ListViewItem(row)
                    {
                        Tag = client // onder water kan je via Tag een volledige Client aan de rij koppelen (geen ClientVM nodig bij een ListView) 
                    };
                    ListViewPopstars.Items.Add(listViewItem);
                }
            }
        }

        private void ButtonMaakPopster_Click(object sender, EventArgs e)
        {
            var clientVM = ComboBoxClientsIndirect.SelectedItem as ClientVM; 
            if (clientVM != null)
            {
                var client = clientVM.Client;
                client.IsPopstar = true;
                client.PopstarYearIncome = 0; 
                _clientManager.UpdateClient(client);
                FrmCreatePopStarWithComboBox_Load(null, null);
            }
        }

        private void ButtonOntslaZeAllemaal_Click(object sender, EventArgs e)
        {
            foreach (var item in ListViewPopstars.Items)
            {
                var listViewItem = item as ListViewItem;
                var client = listViewItem.Tag as Client; 
                client.IsPopstar = false;
                client.PopstarYearIncome = null;
                _clientManager.UpdateClient(client);
            }
            FrmCreatePopStarWithComboBox_Load(null, null);
        }

        private void ComboBoxClientsDirect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var clientVM = ComboBoxClientsDirect.SelectedItem as ClientVM;
            if (clientVM != null)  
            {
                var client = clientVM.Client;
                client.IsPopstar = true;
                client.PopstarYearIncome = 0;
                _clientManager.UpdateClient(client);
                FrmCreatePopStarWithComboBox_Load(null, null);
            }
        }

        private void AccButtonMakeEveryBodyPopstar_Click(object sender, EventArgs e)
        {
            // Als je op deze button clickt, of als je op ENTER drukt
            // wordt iedereen een popster
            foreach (var item in ComboBoxClientsDirect.Items)
            {
                var clientVM = item as ClientVM;
                if (clientVM != null)
                {
                    var client = clientVM.Client;
                    client.IsPopstar = true;
                    client.PopstarYearIncome = 0;
                    _clientManager.UpdateClient(client);
                }
            }
            // Reload form
            FrmCreatePopStarWithComboBox_Load(null, null);
        }

        // De Click method is niet verplicht voor een cancel button
        // Zonder deze method wordt ook de form verlaten
        //private void CancButtonLeaveFormWithoutUpdate_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Cancel button, no update, form will be left");
        //}
    }
}
