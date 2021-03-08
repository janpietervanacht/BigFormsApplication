using BigFormsApplication.DependencyInfra;
using BigFormsApplication.Forms.ViewModels;
using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigFormsApplication.Forms
{
    public partial class FrmSimpleDragDrop : Form
    {
        public FrmSimpleDragDrop()
        {
            InitializeComponent();
        }

        private void FrmSimpleDragDrop_Load(object sender, EventArgs e)
        {
        }

        private void Label2_DragEnter(object sender, DragEventArgs e)
        {
            // Probeer een item van je desktop te slepen naar label2
            // Let op de vorm van de muispointer
            e.Effect = DragDropEffects.All;
        }

        private void Label2_DragDrop(object sender, DragEventArgs e)
        {
            Label2.Text = (string)e.Data.GetData(DataFormats.Text);
            Label2.BackColor = Color.Red;
            Panel2.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
        }


        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            Label1.DoDragDrop(Label1.Text, DragDropEffects.Copy);
        }

        private void TextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox1.DoDragDrop(TextBox1.Text, DragDropEffects.Copy);
        }

        private void Panel2_DragEnter(object sender, DragEventArgs e)
        {
            Panel2.BackColor = Color.Azure;
        }

        private void Label2_MouseLeave(object sender, EventArgs e)
        {
            Label2.Text = "Weg!";
            Label2.BackColor = Color.Crimson;
        }
    }
}
