using BigFormsApplication.Extensions;
using Business.Interfaces;
using Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BigFormsApplication.Forms
{
    public partial class FrmTabPages : Form
    {
        readonly IClientManager _clientManager;
        readonly IInvoiceManager _invoiceManager;

        private bool _tabPageWithClientListExists;

        public FrmTabPages(IClientManager clientManager, IInvoiceManager invoiceManager)
        {
            InitializeComponent();
            _clientManager = clientManager;
            _invoiceManager = invoiceManager;
            _tabPageWithClientListExists = false;
        }

        private void FrmTabPages_Load(object sender, EventArgs e)
        {
            // De ListBoxClienten is multi-select. Dat betekent dat deze listbox niet reageert op
            // 1 geselecteerd item, maar dat er op een extra button moet worden geklikt, nadat er 1 of 
            // meerdere items zijn geselecteerd. 

            TabControl.SelectTab(1); // Index = 0, 1, 2 (VLNR) Toon blad 1
            // TabControl.SelectTab("TabPageOrange"); // Werkt hetzelfde
        }

        private void ButtonAddTabPage_Click(object sender, EventArgs e)
        {
            var tabPages = TabControl.TabPages;

            var tabPage = new TabPage
            {
                BackColor = Color.Purple,
                Text = $"Tab nummer {TabControl.TabCount}",
            };

            var label = new Label
            {
                Name = $"LabelForTab{TabControl.TabCount}",
                Text = $"Label voor tab nummer {TabControl.TabCount}",
                Width = 400,
                BackColor = Color.LightBlue,
                Location = new Point(25, 50)
            };
            tabPage.Controls.Add(label);

            tabPages.Add(tabPage);

            // - Alternatief hieronder is ook goed: --------------------- 

            //var tabPages = TabControl.TabPages;
            //var lastTabIndex = tabPages.Count - 1;

            //lastTabIndex++; 
            //tabPages.Add($"Tab nummer {lastTabIndex + 1}");
            //var tabPage = tabPages[lastTabIndex]; 
            //tabPage.BackColor = Color.Purple;
            //tabPage.Width = 400;

            //var label = new Label
            //{
            //    Text = $"Label voor tab {tabPage.Text}",
            //    Width = 400,
            //    BackColor = Color.LightBlue,
            //    Location = new Point(25, 50) 

            //};
            //tabPage.Controls.Add(label); 

            //-----------------------------------------

        }

        private void ButtonRemoveLastTabPage_Click(object sender, EventArgs e)
        {
            int selectedIndex = TabControl.TabCount - 1;
            var tabPages = TabControl.TabPages;

            // Check of deze tabPage de lijst van Clienten is:
            if (tabPages[selectedIndex].Name == "TabPageListClients")
            {
                _tabPageWithClientListExists = false;
            }

            if (selectedIndex >= 3)
            {
                TabControl.TabPages.RemoveAt(selectedIndex);

                //TabControl.SelectTab(TabControl.TabCount - 1);
                //TabControl.TabPages.Remove(TabControl.SelectedTab);
            }
            else
            {
                MessageBox.Show("Eerste 3 tabbladen kan u niet weghalen");
            }
        }


        private void ButtonCreateTabPageListClients_Click(object sender, EventArgs e)
        {

            if (_tabPageWithClientListExists)
            {
                MessageBox.Show("Er is al een tab-blad met een lijst van clienten");
                return;
            }
            _tabPageWithClientListExists = true;

            // Create a new TabPage with a ListView, which contains clients
            // Create it without a designer           

            var tabPages = TabControl.TabPages;
            var label = new Label
            {
                Name = "LabelListClients",
                Text = "Klantenlijst",
                Location = new Point(10, 30),
                Size = new Size(900, 100)
            };
            tabPages.Add(
                new TabPage
                {
                    Name = "TabPageListClients",
                    Text = "Tab met klanten",
                    BackColor = Color.LightSalmon,
                });
            // tabPages[tabPages.Count - 1].Controls.Add(label);

            // Create the listview
            CreateListView();

            // create the textbox
            var tabPage = tabPages[tabPages.Count - 1];
            CreateTextBox(tabPage);
        }



        private void ListViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bij selecteren in een listView moet je altijd try catch gebruiken

            TextBoxClient?.Clear();

            try
            {
                var client = (Client)ListViewClients.SelectedItems[0].Tag;
                if (client != null)
                {
                    FillTextBoxForOneClient(client);
                }
            }
            catch (Exception)
            {
            }
        }

        private void FillTextBoxForOneClient(Client client)
        {
            this.TextBoxClient.Location = new System.Drawing.Point(34, 300);
            this.TextBoxClient.Name = "TextBoxClientNumber";
            this.TextBoxClient.ReadOnly = true;
            this.TextBoxClient.Size = new System.Drawing.Size(963, 255);
            this.TextBoxClient.TabIndex = 1;

            this.TextBoxClient.Text =
                $"Klantnummer: {client.ClientNumber}\n" +
                $"Klantnaam: {client.FirstName} + {client.LastName}\n" +
                $"Land:  {client.Country?.CountryDescription}";
        }


        private void CreateTextBox(TabPage tabPage)
        {
            this.TextBoxClient = new RichTextBox();
            this.TextBoxClient.Location = new Point(34, 300);
            this.TextBoxClient.Name = "TextBoxClientNumber";
            this.TextBoxClient.ReadOnly = true;
            this.TextBoxClient.Size = new Size(963, 255);
            this.TextBoxClient.TabIndex = 1;
            tabPage.Controls.Add(TextBoxClient);
        }


        private void CreateListView()
        {
            var tabPage = TabControl.TabPages[TabControl.TabPages.Count - 1];

            this.ListViewClients = new ListView();
            this.ClientNumber = new ColumnHeader();
            this.ClientFullName = new ColumnHeader();

            // creëer de ListView
            this.ListViewClients.Columns.AddRange(new ColumnHeader[] {
            this.ClientNumber,
            this.ClientFullName});

            this.ListViewClients.GridLines = true;
            this.ListViewClients.HideSelection = false;
            this.ListViewClients.Location = new Point(34, 15);
            this.ListViewClients.Name = "ListViewClienten";
            this.ListViewClients.Size = new Size(963, 255);
            this.ListViewClients.TabIndex = 0;
            this.ListViewClients.UseCompatibleStateImageBehavior = false;
            this.ListViewClients.View = View.Details;  // NIET VERGETEN
            this.ListViewClients.SelectedIndexChanged += new EventHandler(this.ListViewClients_SelectedIndexChanged);
            // 
            // ClientNumber
            // 
            this.ClientNumber.Text = "Klant nr";
            this.ClientNumber.Width = 100;
            // 
            // ClientFirstName
            // 
            this.ClientFullName.Text = "Klant naam";
            this.ClientFullName.Width = 600;
            //  VOEG LISTVIEW TOE AAN DE FORM. 
            tabPage.Controls.Add(ListViewClients);

            ListViewClients.Items.Clear();
            var clientList = _clientManager.GetAll();

            foreach (var client in clientList)
            {
                var clientNumberAlfa = client.ClientNumber.ToString().PadLeft(6, '0');
                var row = new string[] { clientNumberAlfa, client.FirstName + " " + client.LastName };

                var listViewItem = new ListViewItem(row)
                {
                    Tag = client
                };
                ListViewClients.Items.Add(listViewItem);
            }

        }



    }








}
