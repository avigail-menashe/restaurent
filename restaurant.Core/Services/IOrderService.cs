using restaurant.Core.enties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.Core.Services
{
    public interface IOrderService
    {
        public IEnumerable<Order> GetOrders();
        public Order GetOrderById(int id);
        public Order Post(Order value);
        public Order Update(int id, Order value);
        public void Delete(int id);
    }
}
