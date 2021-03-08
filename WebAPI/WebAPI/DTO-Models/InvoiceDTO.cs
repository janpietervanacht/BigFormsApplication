// We gebruiken exact hetzelfde DTO-model voor de Client applicatie
// als voor de WebAPI. Ook met dezelfde class namen, anders 
// worden, aan client zijde, sommige group-level-tags niet 
// herkend bij het inlezen van de json string.


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using Model;

namespace WebAPI.DTO_Models
{
    public class InvoiceDTO  
    {

        // NOT DONE: classes uit Model opnemen in een outgoing / incoming DTO
        // Je wil ook niet dat als je database verandert, dat dan de communicatie
        // met de buitenwereld ook verandert.

        // Onderstaande geeft altijd een JSON-infinite-object van meer dan 32, want
        // ApplicDbContext zal altijd impliciet alle referenties (Foreign Key en 1:N)
        // gaan invullen. 

        // public Model.Invoice Invoice { get; set; }  // NOOIT DOEN

        public int InvoiceNumber { get; set; }  // functioneel fact nr
        public decimal Amount { get; set; }
        public string InvoiceDescription { get; set; }
        public string FullReferenceInvoice { get; set; }
        
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
