#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Model;

namespace BigFormsApplication.DTO_Models
{
    public class InvoiceDTO  
    {

        // NOT DONE: classes uit Model opnemen in een outgoing / incoming DTO
        // Je wil ook niet dat als je database verandert, dat dan de communicatie
        // met de buitenwereld ook verandert.

        // public Model.Invoice Invoice { get; set; }  // NOOIT DOEN

        public int InvoiceNumber { get; set; }  // functioneel fact nr
        public decimal Amount { get; set; }
        public string InvoiceDescription { get; set; }
        public string FullReferenceInvoice { get; set; }
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
