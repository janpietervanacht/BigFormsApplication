using BigFormsApplication.Forms.ViewModels;
using Business.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BigFormsApplication.Forms
{
    public partial class FrmDragDropListBoxToListBox : Form
    {
        int index = 0;

        readonly IClientManager _clientManager;

        public FrmDragDropListBoxToListBox(IClientManager clientManager)
        {
            InitializeComponent();
            _clientManager = clientManager;
        }

        private void FrmDragDropListBoxToListBox_Load(object sender, EventArgs e)
        {

            var listClients = _clientManager.GetAll();
            ListBoxLeft.Items.Clear();
            ListBoxLeft.ValueMember = "Client"; // Prop uit ClientVM
            ListBoxLeft.DisplayMember = "LineInListBox"; // Get prop uit ClientVM, moet een string zijn

            foreach (var client in listClients)
            {
                var clientVM = new ClientVM
                {
                    Client = client
                    // LineInListBox is een get property die zichzelf invult
                };

                ListBoxLeft.Items.Add(clientVM);
            }
        }

        private void Panel2_DragEnter(object sender, DragEventArgs e)
        {
            Label3.Visible = true;
        }

        private void ListBoxLeft_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            var listBoxSender = sender as ListBox;
            //  index = listBoxSender.IndexFromPoint(e.X, e.Y); // x en y coordinaat van muis OOK GOED
            index = listBoxSender.IndexFromPoint(e.Location); // x en y coordinaat van muis

            if (index < 0) return;

            var item = listBoxSender.Items[index];
            // stuur een collectie weg van items 
            listBoxSender.DoDragDrop(item, DragDropEffects.Move);

        }

        private void ListBoxRight_DragEnter(object sender, DragEventArgs e)
        {
            // GetDataPresent, daarmee kan je controleren of er in e.Data een ClientVM model zit
            if (e.Data.GetDataPresent(typeof(ClientVM)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ListBoxRight_DragDrop(object sender, DragEventArgs e)
        {
            // De sender bij een DragDrop is de ListBox waar het arriveert, niet waar het vandaan komt

            var listBoxSender = sender as ListBox;

            listBoxSender.ValueMember = "Client"; // Prop uit ClientVM
            listBoxSender.DisplayMember = "LineInListBox"; // Get prop uit ClientVM, moet een string zijn

            var clientVM = e.Data.GetData(typeof(ClientVM)) as ClientVM;
            listBoxSender.Items.Add(clientVM);
            ListBoxLeft.Items.RemoveAt(index);
        }

        private void Panel2_MouseLeave(object sender, EventArgs e)
        {
            Label3.Visible = false;
        }
    }
}
