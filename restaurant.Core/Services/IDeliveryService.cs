using restaurant.Core.enties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.Core.Services
{
    public interface IDeliveryService
    {
        public IEnumerable<Delivery> GetDeliveries();
        public Delivery GetDeliveryById(int id);
        public Delivery Post(Delivery value);
        public Delivery Put(int id, Delivery value);
        public void Delete(int id);
    }
}
