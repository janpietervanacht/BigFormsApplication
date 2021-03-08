using System.Collections.Generic;
using Model;

namespace Business.Interfaces
{
    public interface IClientManager
    {
        Client GetClient(int clientId);
        void UpdateClient(Client client);
        void AddClient(Client client);
        void DeleteClient(int clientId);
        List<Client> GetAll();
        int CreateNewClientNumber();
    }
}