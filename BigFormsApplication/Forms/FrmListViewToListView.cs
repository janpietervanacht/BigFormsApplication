using BigFormsApplication.Forms.ViewModels;
using Business.Interfaces;
using Model;
using Model.ConstantsAndEnums;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BigFormsApplication.Forms
{
    public partial class FrmListViewToListView : Form
    {
        readonly IClientManager _clientManager;

        public FrmListViewToListView(IClientManager clientManager)
        {
            // Zet de View property van een ListView op Details
            InitializeComponent();
            _clientManager = clientManager;
        }

        private void FrmListViewToListView_Load(object sender, EventArgs e)
        {
            // ZET in beide Listviews de PROPERTY View OP 'Details'

            var listClients = _clientManager.GetAll();
            ListViewOrdPeople.Items.Clear();
            ListViewPopstars.Items.Clear();
            foreach (var client in listClients)
            {
                var row = new string[]
                    {
                        client.ClientNumber.ToString(),
                        client.FirstName, 
                        client.BirthDate.ToString("dd MMM yyyy", Const.cCultureDutch)
                    };
                var listViewItem = new ListViewItem(row)
                {
                    Tag = client // onder water kan je via Tag een volledige Client aan de rij koppelen
                };

                if (client.IsPopstar)
                {
                    ListViewPopstars.Items.Add(listViewItem);
                }
                else
                {
                    ListViewOrdPeople.Items.Add(listViewItem);
                }
            }
        }

        private void ListViewOrdPeople_DoubleClick(object sender, EventArgs e)
        {
            var client = (Client) ListViewOrdPeople.SelectedItems[0].Tag;
            client.IsPopstar = true;
            client.PopstarYearIncome = 0;
            _clientManager.UpdateClient(client);
            FrmListViewToListView_Load(null, null); // reload form
        }

        private void ListViewPopstars_DoubleClick(object sender, EventArgs e)
        {
            var client = (Client)ListViewPopstars.SelectedItems[0].Tag;
            client.IsPopstar = false;
            client.PopstarYearIncome = null;
            _clientManager.UpdateClient(client);
            FrmListViewToListView_Load(null, null); // reload form
        }

        private void AccButton_Click(object sender, EventArgs e)
        {
            // Een Accept Button is alleen zinvol
            // als er nergens in de form ook met ENTER wordt gewerkt.
            // Als andere controls (zoals een textbox) ook ENTERS accepteren
            // heeft een AcceptButton geen zin
            MessageBox.Show("U heeft de AcceptButton aangeraakt"); 
        }
    }
}
