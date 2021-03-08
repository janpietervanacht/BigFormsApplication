#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

// Best Practice: geef in de API niet een List<InvoicDTO> terug, 
// maar geef in de API een class terug waar de list in zit verwerkt.   
// Want dan kan je ook totalen meegeven aan de outgoing DTO.

// We gebruiken exact hetzelfde DTO-model voor de client applicatie
// als voor de WebAPI. Ook met dezelfde class namen, anders 
// worden, aan client zijde, sommige group-level-tags niet 
// herkend bij het inlezen van de json string.

using System.Collections.Generic;
using System.Linq;

namespace BigFormsApplication.DTO_Models
{
    public class InvoiceListDTO
    {
        // NOT DONE: classes uit Model opnemen in een outgoing / incoming DTO
        // Je wil ook niet dat als je database verandert, dat dan de communicatie
        // met de buitenwereld ook verandert.

        // Set is ook nodig, immers je deserialiseert JSON naar dit model toe. 
        public List<InvoiceDTO> ListOfDTOInvoices { get; set;  }

        public string ClientFullName { get; set; }

        public decimal TotalInvoiceAmount { get; set; }

        public decimal TotalNrOfInvoices { get; set; }

        public decimal LowestInvoiceAmount { get; set; }

        public decimal HighestInvoiceAmount { get; set; }

        public decimal AverageInvoiceAmount { get; set; }
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
