using restaurant.Core.enties;
using restaurant.Core.Repositories;
using restaurant.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.Service
{
    public class ClientSerivce : IClientService
    {
        private IClientRepository _clientRepository;

        public ClientSerivce (IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public List<Client> GetClients()
        {
            return _clientRepository.Get();
               
        }

        public Client GetClientById(int id)
        {
            return _clientRepository.Get(id);      
        }

        public Client Post(Client client)
        {
            return _clientRepository.Post(client);
        }

        public Client Put(int id, Client client)
        {
           return _clientRepository.Put(id, client);
        }

        public void Delete(int id)
        {
            _clientRepository.Delete(id);
        }
        
    }
}
