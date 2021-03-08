using BigFormsApplication.Extensions;
using Business.Interfaces;
using Model;
using System;
using System.Windows.Forms;

namespace BigFormsApplication.Forms
{
    public partial class FrmClientenListView : Form
    {
        private readonly IClientManager _clientManager; 

        public FrmClientenListView(IClientManager clientManager)
        {
            InitializeComponent();
            _clientManager = clientManager;
        }

        private void FrmClientenListView_Load(object sender, EventArgs e)
        {
            // ZET in de ListView PROPERTY View OP 'Details'

            var listClients = _clientManager.GetAll();

            ListViewClienten.Items.Clear();
            foreach (var client in listClients)
            {
                var row = new string[]
                    {
                        client.ClientNumber.ToString(),
                        client.FirstName
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
                    var result = $"Client Voornaam: {selectedItem.FirstName} " +
                            $"\nClient Achternaam: {selectedItem.LastName} " +
                            $"\nClient Klantnummer: {selectedItem.ClientNumber} " +
                            $"\nClient Geboortedatum: " +
                            $"{selectedItem.BirthDate.ToDutchDateFormat()}"; 
                    // MessageBox.Show(result); Mag ook
                    TbxClientDetails.Text = result; 
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
