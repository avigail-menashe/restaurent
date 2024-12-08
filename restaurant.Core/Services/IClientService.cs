using restaurant.Core.enties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.Core.Services
{
    public interface IClientService
    {
        public List<Client> GetClients();
        public Client GetClientById(int id);
        public Client Post(Client value);
        public Client Put(int id, Client value);
        public void Delete(int id);
    }
}
