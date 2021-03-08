using DataAccess.ApplicDbContext;
using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Model;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly ApplicDbContext.DatabaseContext _dbContext;
        private readonly ILogger<ClientRepository> _logger;

        //private string dbgPref = "Debug level from JPVA: ";
        //private string infoPref = "Info level from JPVA: ";
        //private string warnPref = "Warning level from JPVA: ";
        //private string errPref = "Error level from JPVA: ";

        public InvoiceRepository(ApplicDbContext.DatabaseContext dbContext, ILogger<ClientRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public void Add(Invoice invoice)
        {
            throw new System.NotImplementedException();
        }

        public int CountNrOfInvoices(int clientId)
        {
            var result = _dbContext.Invoices
               .Where(i => i.ClientId == clientId)
               .Count();
            return result;
        }

        public void Delete(int InvoiceId)
        {
            throw new System.NotImplementedException();
        }

        public Invoice Get(int InvoiceId)
        {
            throw new System.NotImplementedException();
        }

        public List<Invoice> GetAll()
        {
            var result = _dbContext.Invoices
                .OrderBy(i => i.InvoiceNumber)
                .Include(i => i.Client).ThenInclude(c => c.Country)
                .ToList();

            return result;
        }

        public List<Invoice> GetAllByClientId(int clientId)
        {
            var result = _dbContext.Invoices
                .Where(i => i.ClientId == clientId)
                // Include hieronder halen we eruit, 
                // anders krijgen we "a  possible object cycle" in JSON
                // een oneindige verwijzing in JSON fact->client->facturen->clienten etc
                //     .Include(i => i.Client).ThenInclude(c=>c.Country)
                .OrderBy(i => i.InvoiceNumber)
                .ToList();

            return result;
        }

        public List<Invoice> GetAllByClientNumber(int clientNumber)
        {
            var result = _dbContext.Invoices
          //      .Include(i => i.Client)
                .Where(i => i.Client.ClientNumber == clientNumber)
                .OrderBy(i => i.InvoiceNumber)
                .ToList();

            return result;
        }

        public List<Invoice> GetAllNotSend()
        {
            var result = _dbContext.Invoices
                .Where(i => i.InvoiceSend == false)
                .ToList();
            return result;
        }

        public Invoice GetByInvoiceNumber(int invoiceNumber)
        {
            var result = _dbContext.Invoices
                .Include(i => i.Client)
                .SingleOrDefault(i => i.InvoiceNumber == invoiceNumber); 
            return result;
        }

        public void Update(Invoice invoice)
        {
            throw new System.NotImplementedException();
        }
    }
}
