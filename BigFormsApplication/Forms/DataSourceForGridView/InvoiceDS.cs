using System;

namespace BigFormsApplication.Forms.DataSourceForGridView
{
    public class InvoiceDS   // Invoice Data Source voor een DataGrid
    {
       
        public int InvoiceNumber { get; set; }  // functioneel fact nr
        public decimal Amount { get; set; }
        public string InvoiceDescription { get; set; }
        public string FullReferenceInvoice { get; set; }
    }
}
