using Model.ConstantsAndEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Client
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Actief/Inactief:")]
        [Required]
        [RegularExpression("^[AI]$", ErrorMessage = "Waarde moet A/I zijn")]
        public char ActionCode { get; set; }

        [Required]
        [DisplayName("Klantnummer:")]  // functioneel klantnummer
        public int ClientNumber { get; set; }  // automatische generatie

        //-------------------------------- 
        [Required]
        [DisplayName("Is een popster J/N:")]
        public bool IsPopstar { get; set; }

        [DisplayName("Jaarinkomen popster (optioneel)")]
        public int? PopstarYearIncome { get; set; } // nullable value variable
        //--------------------------------

        [Required]
        [DisplayName("Geslacht (M/V):")]  // M of V
        [RegularExpression("^[MV]$", ErrorMessage = "Waarde moet M/V zijn")]
        public char Gender { get; set; }

        // Leeftijd wordt berekend, niet opgeslagen 
        //[DisplayName("Leeftijd:")]
        //[Required(ErrorMessage = "Leeftijd is verplicht")]
        //public int Age { get; set; }


        [DisplayName("Voornaam:")]
        [Required(ErrorMessage = "Voornaam is verplicht")]
        public string FirstName { get; set; }


        [DisplayName("Achternaam:")]
        [Required(ErrorMessage = "Achternaam is verplicht")]
        public string LastName { get; set; }


        [DisplayName("Geboortedatum:")]
        [Required(ErrorMessage = "Geboortedatum is verplicht")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}")]
        public DateTime BirthDate { get; set; }


        [DisplayName("Is verzekerd?:")]
        [Required(ErrorMessage = "Verzekerd (?) is verplicht")]
        public bool IsInsured { get; set; }
      
        public int? CountryId { get; set; }  // Client kent OPTIONEEL 1 land (vraagteken) 
        public Country Country { get; set; }  // Dit is een Foreign Key naar de country tabel  .Include 

        public List<Invoice> InvoiceList { get; set; } // Aanleggen 1 op N relatie

        //[Required]
        //[DisplayName("Leeftijds fase client:")]
        //public ClientAgeEnum ClientType { get; set; } // Kind, Volwassene, Bejaarde (10, 20, 30)
        // TODO: Enum werkt nog niet in de view       
    }
}
