using restaurant.Core.enties;
using restaurant.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.Data.Repositories
{
    public class DeliveryRepository:IDeliveryRepository
    {
        private DataContext _context;
        public DeliveryRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Delivery> Get()
        {
            return _context.deliveries;
        }
        public Delivery Get(int id)
        {
            var index = _context.deliveries.ToList().FindIndex(x => x.Id == id);
            return _context.deliveries.ToList()[index];
        }
        public Delivery Post(Delivery delivery)
        {
            _context.deliveries.Add(delivery);
            _context.SaveChanges();
            return delivery;
        }
        public Delivery Put(int id, Delivery delivery)
        {
            int index = _context.deliveries.ToList().FindIndex(d => d.Id == id);
            _context.deliveries.ToList()[index].DeliveryAddress = delivery.DeliveryAddress;
            _context.deliveries.ToList()[index].DeliveryStatus = delivery.DeliveryStatus;
            _context.SaveChanges();
            return _context.deliveries.ToList()[index];
        }
        public void Delete(int id)
        {
            var index = _context.deliveries.ToList().FindIndex(d => d.Id == id);
            _context.SaveChanges();
            _context.deliveries.ToList().RemoveAt(index);
        }

        public Delivery Put(Delivery delivery)
        {
            throw new NotImplementedException();
        }

        Delivery IDeliveryRepository.Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
