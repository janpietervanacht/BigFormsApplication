using BigFormsApplication.Extensions;
using BigFormsApplication.Forms.DataSourceForGridView;
using BigFormsApplication.Forms.ViewModels;
using Business.Interfaces;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BigFormsApplication.Forms
{
    public partial class FrmDataGridViewReadOnly : Form
    {
        private int? _selectedClientId;
        readonly IClientManager _clientManager;

        public FrmDataGridViewReadOnly(IClientManager clientManager)
        {
            InitializeComponent();
            _clientManager = clientManager;
        }

        private void FrmDataGridView_Load(object sender, EventArgs e)
        {
            TextBoxFirstName.Text = "";
            TextBoxBirthDate.Text = null;

            var clientList = _clientManager.GetAll();
            var clientListDS =
                clientList
                .Select(c => new ClientDS
                {
                    ClientId = c.Id,
                    ClientNumber = c.ClientNumber,
                    FirstName = c.FirstName,
                    Birthdate = c.BirthDate.ToString("dd-MM-yyyy")
                }
                ).ToList();
            DataGridViewKlanten.DataSource = clientListDS;
            DataGridViewKlanten.Columns["ClientId"].Visible = false; // hide ClientId
            
            DataGridViewKlanten.Columns["ClientNumber"].ToolTipText = "Nummer klantje"; 
            DataGridViewKlanten.Columns["FirstName"].ToolTipText = "Voornaam klantje"; 
            DataGridViewKlanten.Columns["BirthDate"].ToolTipText = "Geboortedatum klantje";

            DataGridViewKlanten.Columns["ClientNumber"].HeaderText = "Klantnummer";
            DataGridViewKlanten.Columns["FirstName"].HeaderText = "Voornaam klant";
            DataGridViewKlanten.Columns["BirthDate"].HeaderText = "Geboortedatum klant";

            // Onderstaande werkt niet:

            //foreach (var client in clientList)
            //{
            //    var clientDS = new ClientDS
            //    {
            //        ClientId = client.Id,
            //        ClientNumber = client.ClientNumber,
            //        FirstName = client.FirstName,
            //        Birthdate = client.BirthDate.ToString("dd-MM-yyyy")
            //    };
            //    DataGridViewKlanten.Rows.Add(clientDS);
            //    // DataGridViewKlanten.Columns["ClientId"].Visible = false; // hide ClientId
            //}
        }

        //---------------- 

        //private void dataGridViewKlanten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    // Geeft BUGS 
        //}

        private void LblChange_Click(object sender, EventArgs e)
        {
            var client = _clientManager.GetClient(_selectedClientId.GetValueOrDefault());
            if (client != null)
            {
                client.FirstName = TextBoxFirstName.Text;

                var ok = DateTime.TryParse(TextBoxBirthDate.Text, out DateTime resultDate);
                if (ok) // No error
                {
                    client.BirthDate = resultDate;
                    _clientManager.UpdateClient(client);
                    FrmDataGridView_Load(null, null);
                }

            }
        }

        // Onderstaande werkt goed, je kan alleen op de Row Header klikken, dan werkt het 
        private void DataGridViewKlanten_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var clientDS = DataGridViewKlanten.SelectedRows[0].DataBoundItem as ClientDS;
                this._selectedClientId = clientDS?.ClientId;
                TextBoxClientNumber.Text = clientDS?.ClientNumber.ToString().PadLeft(6);
                TextBoxFirstName.Text = clientDS?.FirstName;
                TextBoxBirthDate.Text = clientDS?.Birthdate;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fout opgetreden: \n" +
                    $"Message: {ex.Message}\n" +
                    $"Source: {ex.Source}");
            }
        }

        //private void DataGridViewKlanten_RowEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    // Geeft BUGS 
        //}
    }
}
