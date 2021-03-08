using Business.Interfaces;
using DataAccess.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.BusinessManagers
{
    public class ClientManager : IClientManager
    {
        private readonly IClientRepository _clientRepository;

        // In de constructor geven we alle objecten mee
        // die deze class zelf weer gebruikt. 

        public ClientManager(IClientRepository clientRepository)
        {
            // Bij Dependency Injection in startup.cs is geregeld
            // dat IClientRepository slechts één keer (lifetime) een 
            // instantie van ClientRepository aanwijst. 
            _clientRepository = clientRepository;
        }


        public void AddClient(Client client)
        {
            _clientRepository.Add(client); 
        }

        public int CreateNewClientNumber()
        {
            var maxClientNumber = _clientRepository.GetMaxClientNumber() + 1;
            return maxClientNumber; 
        }

        public void DeleteClient(int clientId)
        {
            _clientRepository.Delete(clientId);  
        }

        public List<Client> GetAll()
        {
            var result = _clientRepository.GetAllClientsWithoutIncludingInvoices();
            return result; 
        }

        public Client GetClient(int clientId)
        {
            if (clientId == 0)
            {
                return null; 
            }
            var result = _clientRepository.Get(clientId); 
            return result;
        }

        public void UpdateClient(Client client)
        {
            _clientRepository.Update(client); 
        }
    }
}
