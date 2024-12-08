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
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetOrders();
        }

        public Order GetById(int id)
        {
            return _orderRepository.GetOrderById(id);

        }

        public Order Post(Order order)
        {
            return _orderRepository.Post(order);
        }

        public Order Update(int id,Order order)
        {
            return _orderRepository.Updade(id, order);
        }
        public void Delete(int id)
        {
            _orderRepository.Delete(id);
        }
    }
}
