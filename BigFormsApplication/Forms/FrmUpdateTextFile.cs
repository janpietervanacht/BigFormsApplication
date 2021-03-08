using Business.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace BigFormsApplication.Forms
{
    public partial class FrmUpdateTextFile : Form
    {
        string _fileNameOrig;

        public FrmUpdateTextFile()
        {
            InitializeComponent();
        }

        private void FrmUpdateTextFile_Load(object sender, EventArgs e)
        {
            LblInformationMessage.Visible = false;
        }

        private void ButtonOpenDialog_Click(object sender, EventArgs e)
        {
            _fileNameOrig = null;
            LblInformationMessage.Visible = false;

            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text file|*.txt|JSON file|*.json|XML file|*.xml";
            openFileDialog.Title = "Schrijf de tekst naar een u door u gekozen file";


            string result = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _fileNameOrig = openFileDialog.FileName;

                LblInformationMessage.Text = $"Inhoud opgehaald uit {_fileNameOrig}";
                LblInformationMessage.Visible = true;
                LblInformationMessage.ForeColor = Color.Blue;

                try
                {
                    using (var sr = new StreamReader(openFileDialog.FileName))
                    {
                        result = sr.ReadToEnd();
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            };
            RichTxbTekst.Text = result;
        }

        // ButtonWriteTofile maakt automatisch een kopie file aan, geen SaveFileDiaLog
        private void ButtonWriteToFile_Click(object sender, EventArgs e)
        {
            // Maak een extra file aan voor de output
            var fileNameResult = $"{_fileNameOrig} gemuteerd {DateTime.Now:yyyy-MM-dd HH.mm.ss}.txt";
            // Schrijf de output weg
            using (var sw = File.CreateText(fileNameResult))
            {
                sw.Write(RichTxbTekst.Text);
            }
            RichTxbTekst.Clear();
            LblInformationMessage.Text = $"Inhoud weggeschreven naar {fileNameResult}";
            LblInformationMessage.Visible = true;
            LblInformationMessage.ForeColor = Color.Red;

        }

        private void ButtonSaveUsingFileDialog_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            // De Filter krijgt 3 indices, vanaf 1
            // 1 = txt
            // 2 = json
            // 3 = xml
            saveFileDialog.Filter = "Text file|*.txt|JSON file|*.json|XML file|*.xml";
            saveFileDialog.Title = "Schrijf de tekst naar een u door u gekozen file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //var fs =  (FileStream)saveFileDialog.OpenFile();
                //var fullFileNameWithPath = fs.Name;

                string fullFileNameWithPath = saveFileDialog.FileName;
                using (var sw = File.CreateText(fullFileNameWithPath))
                {
                    sw.Write(RichTxbTekst.Text);
                }
                RichTxbTekst.Clear();
                LblInformationMessage.Text = $"Inhoud weggeschreven naar {fullFileNameWithPath}";
                LblInformationMessage.Visible = true;
                LblInformationMessage.ForeColor = Color.Red;
            }

        }
    }
}
