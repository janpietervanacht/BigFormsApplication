#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

using DataAccess.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using WebAPI.DTO_Models;

namespace WebAPI.Controllers
{
    [Route("api/v{version:ApiVersion}/invoice")]
    // [ApiVersion("1.0")]  // Afgesterd, deze versie wordt default 1.0

    [ApiController]
    [ProducesResponseType(StatusCodes.Status400BadRequest)] // Voor alle ActionMethods geldig

    // Warning XML zegt dat er geen XML documentatie is voor objecten, die publiek zichtbaar zijn.
    // Dit geeft vele onnodige warnings.

    // Via intellisense heb ik warning CS1591 uitgeschakeld voor de class ClientApiController
    // Zie de #pragma disable en #pragma restore

    // Je kan de gehele warning CS1591 ook uitschakelen via
    // Project -> Properties -> Build -> Suppress warnings : zet "1591;" er achteraan
    // En doe een Save All

    public class InvoiceController : ControllerBase

    {

        // De controller heeftrepository nodig, gebruik DI
        private readonly IClientRepository _clientRepository;
        private readonly ICountryRepository _countryRepository;
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly ILogger<InvoiceController> _logger;
        public InvoiceController(IClientRepository clientRepository,
            IInvoiceRepository invoiceRepository,
            ICountryRepository countryRepository,
            ILogger<InvoiceController> logger)
        {
            _clientRepository = clientRepository;
            _invoiceRepository = invoiceRepository;
            _countryRepository = countryRepository;
            _logger = logger;
        }

        // ----------------------- GetAllInvoicesForOneClient -------------------------------------
        // Retrieve op basis van Id, Windows Front End mag het ClientId weten

        [HttpGet("{clientNumber:int}", Name = "GetByClientNr")]
        // [HttpGet("{clientNumber}", Name="Haal alle invoices op per klantnummer")]

        // Best Practice: geef niet een List<InvoiceOutgDTO> terug, maar een class waar de list in zit verwerkt  
        // Want dan kan je ook totalen meegeven aan de outgoing DTO.

        [ProducesResponseType(200, Type = typeof(InvoiceListDTO))]
        [ProducesResponseType(404)] // not found
        [ProducesDefaultResponseType] // Als bovenstaande niet van toepassing, dan deze
        public IActionResult GetByClientNr(int clientNumber)
        {
            var client = _clientRepository.GetByClientNumber(clientNumber);
            // Variabele 'client' bevat op deze regel geen lijst van Invoices  
            var clientRef = client.ClientNumber.ToString().PadLeft(6);

            var invoiceList = _invoiceRepository.GetAllByClientNumber(clientNumber);
            // Runtime via intellisense: 
            // Variabele 'invoiceList' bevat op deze regel toch een ingevulde Client
            // ondanks dat er geen .Include(i=>i.Client) voorkomt in de code van GetAllByClientNumber(). 
            // Dit hoort zo.

            // Variabele 'client' bevat op deze regel ineens wèl een lijst van Invoices  
            // Dat hoort ook zo.  

            // ------------------ Target Property Uitleg -----------------

            //  Je haalt eerst een client op. 
            //  Het interne geheugen kent nu deze client.
            //  Daarna haal je alle invoices op van deze client. Omdat de client bekend is in het 
            //  interne geheugen, krijgen al deze invoices in het interne geheugen nu ook een volledige Client.

            //  In het interne geheugen worden automatisch zoveel mogelijk koppelingen gelegd.  
            //  Bij het ophalen van de invoices wordt de inhoud van 'client' gewijzigd,  
            //  'client' krijgt automatisch een lijst van Invoices  

            // Je hebt dan een oneindige door-klik in intellisense (is normaal)
            // maar dat wil je niet voor export-modellen in web-api, 
            // want dan klapt JSON / XML eruit (oneindige object cycle)
            // CONCLUSIE: GEBRUIK NOOIT CLASSES VAN MODEL IN EEN EXPORT-MODEL VAN EEN WEB-API
            //            OOK FUNCTIONEEL GEZIEN IS DAT LOGISCH, DE BUITENWERELD MAG NIET ZOMAAR EEN NIEUW
            //            VELD KRIJGEN
            //----------------------------------------------------------------------------

            if (invoiceList == null)
            {
                return NotFound();  // 404
            }
            else
            // Stuur altijd een DTO naar de buitenwereld, nooit het object zelf
            {
                var invoiceListDTO = new InvoiceListDTO()
                {
                    ListOfDTOInvoices =
                            invoiceList.Select
                                    (i => new InvoiceDTO
                                    {
                                        InvoiceNumber = i.InvoiceNumber,
                                        InvoiceDescription = i.InvoiceDescription,
                                        Amount = i.Amount,
                                        FullReferenceInvoice = clientRef + " - " + i.InvoiceNumber.ToString().PadLeft(8),
                                    }
                                    ).ToList(),
                    ClientFullName = client.FirstName + " " + client.LastName
                    // Overige totaalvelden setten zichzelf via get properties
                };

                return Ok(invoiceListDTO);
            }
        }

        //[HttpGet("{clientNumker:int}", Name = "MaxInvoiceAmount")]
        //[ProducesResponseType(200, Type = typeof(InvoiceOutgDTOList))]
        //[ProducesResponseType(404)] // not found
        //[ProducesDefaultResponseType] // Als bovenstaande niet van toepassing, dan deze
        //public IActionResult MaxInvoiceAmount(int clientNumker)
        //{
        //    int result = 100; 
        //    return Ok(result); 
        //}

    }
}

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
