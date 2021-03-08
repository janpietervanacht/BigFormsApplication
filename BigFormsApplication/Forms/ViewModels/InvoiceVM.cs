using Model;

namespace BigFormsApplication.Forms.ViewModels
{
    public class InvoiceVM
    {
        public Invoice Invoice { get; set; }
        public string LineInListBox
        {
            get
            {
                return Invoice.InvoiceNumber + " - " + Invoice.InvoiceDescription;
            }
        }
    }
}
