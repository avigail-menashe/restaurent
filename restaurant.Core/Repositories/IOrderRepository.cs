using restaurant.Core.enties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.Core.Repositories
{
    public interface IOrderRepository
    {
        public List<Order> GetAll();
        public Order GetById(int id);
        public Order Post(Order value);
        public Order Updade(int id, Order value);
        public void Delete(int id);
    }
}
