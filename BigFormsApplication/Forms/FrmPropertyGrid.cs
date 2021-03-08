using BigFormsApplication.Extensions;
using BigFormsApplication.Forms.ViewModels;
using Business.Interfaces;
using Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BigFormsApplication.Forms
{
    public partial class FrmPropertyGrid : Form
    {
        readonly IClientManager _clientManager;
        readonly IInvoiceManager _invoiceManager;

        private ClientVM clientVM;

        public FrmPropertyGrid(IClientManager clientManager, IInvoiceManager invoiceManager)
        {
            InitializeComponent();
            _clientManager = clientManager;
            _invoiceManager = invoiceManager;
            PropertyGrid1.Visible = false;
        }

        private void FrmPropertyGrid_Load(object sender, EventArgs e)
        {
            RichTextBoxForChangedItem.Text = "";
            LabelExplanation.Text = "";

            var listClients = _clientManager.GetAll();
            // De ListBoxClients is Selection-Mode = one 

            ListBoxClients.Items.Clear();

            ListBoxClients.ValueMember = "Client"; // Prop uit ClientVM
            ListBoxClients.DisplayMember = "LineInListBox"; // Get prop uit ClientVM, moet een string zijn

            foreach (var client in listClients)
            {
                var clientVM = new ClientVM
                {
                    Client = client
                    // ,  LineInListBox is een get property die zichzelf invult
                };

                ListBoxClients.Items.Add(clientVM);
            }

        }

        private void ListBox1_Click(object sender, EventArgs e)
        {
            PropertyGrid1.Visible = true;
            PropertyGrid1.SelectedObject = sender;
            PropertyGrid1.Text = "List Box";
            LabelExplanation.Text = "Wijzig een property, daarna ENTER intoetsen";
            RichTextBoxForChangedItem.Text = "";
        }


        private void ListBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            clientVM = ListBoxClients.SelectedItem as ClientVM;
            PropertyGrid1.SelectedObject = clientVM?.Client;
            LabelExplanation.Text = "Wijzig een property, daarna ENTER intoetsen";

            LabelFirstName2.Text = clientVM.Client.FirstName;
            LabelClientNumber2.Text = clientVM.Client.ClientNumber.ToString().PadLeft(6, '0');
            RichTextBoxForChangedItem.Text = "";
        }

        private void PanelWithCustomer_Click(object sender, EventArgs e)
        {
            RichTextBoxForChangedItem.Text = "";
            PropertyGrid1.Visible = true; 
            PropertyGrid1.SelectedObject = sender;
          
        }

        private void PropertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs propValChg)
        {
            var typeSelectedObj = PropertyGrid1.SelectedObject
                .GetType().Name.ToString(); // Dankzij Name: geen namespace getoond
            var chgPropName = propValChg.ChangedItem.PropertyDescriptor.Name; 
            var chgPropLabel = propValChg.ChangedItem.Label;
            
            // show type: int32, string, DateTime etc:
            var chgPropType = propValChg.ChangedItem.PropertyDescriptor.PropertyType.Name; 
            var oldValue = propValChg.OldValue?.ToString();
            var newValue = propValChg.ChangedItem.Value.ToString();

            RichTextBoxForChangedItem.Text =
                $"Geselecteerd object Type : {typeSelectedObj}\n" +
                $"Gewijzigde prop name     : {chgPropName}\n" +
                $"Gewijzigde prop label    : {chgPropLabel}\n" +
                $"Gewijzigde prop type     : {chgPropType}\n" +
                $"Oude waarde              : {oldValue}\n" +
                $"Nieuwe waarde            : {newValue}";

        }


        private void PropertyGrid1_SelectedGridItemChanged(object sender, SelectedGridItemChangedEventArgs e)
        {
            RichTextBoxForChangedItem.Text = "";
        }
    }


}
