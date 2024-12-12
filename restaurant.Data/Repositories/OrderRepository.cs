using restaurant.Core.enties;
using restaurant.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace restaurant.Data.Repositories
{
    public class OrderRepository:IOrderRepository 
    {

        static int count = 0;
        private DataContext _context;

        public OrderRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> GetAll()
        { 
            return _context.orders;

        }

        public Order GetBtId(int id) 
        
        {
            int index = _context.orders.ToList().FindIndex(o => o.OrderId == id);
            return _context.orders.ToList()[index];
        }

        public Order Post(Order order)
        {
            order.OrderId = count++;
            _context.orders.Add(order);
            _context.SaveChanges();
            return order;
        }

        public Order Update(int id, Order order)
        {
            int index = _context.orders.ToList().FindIndex((Order o) => { return o.OrderId == id; });
            _context.orders.ToList()[index].OrderDate =order.OrderDate;
            _context.orders.ToList()[index].OrderStatus = order.OrderStatus;
            _context.orders.ToList()[index].Totalcost =order.Totalcost;
            _context.SaveChanges();
            return _context.orders.ToList()[index];
        }

        public void Delete(int id)
        {
            int index = _context.orders.ToList().FindIndex((Order o) => { return o.OrderId == id; });
            _context.SaveChanges();
            _context.orders.ToList().RemoveAt(index);
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Order Updade(int id, Order value)
        {
            throw new NotImplementedException();
        }
    }
}
