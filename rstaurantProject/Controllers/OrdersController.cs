using Microsoft.AspNetCore.Mvc;
using restaurant.Core.enties;
using restaurant.Core.Services;
using restaurant.Data;
using restaurant.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rstaurantProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        private IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        

        // GET: api/<OrdersController>
        [HttpGet]
        public List<Order> Get()
        {
            return _orderService.GetOrders();
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
           return _orderService.GetOrderById(id);
        }

        // POST api/<OrdersController>
        [HttpPost]
        public Order Post([FromBody]Order value)
        {
            _orderService.Post(value);
            return value;
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public Order Put(int id, [FromBody]Order value)
        {
            return _orderService .Update(id, value);
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
          _orderService .Delete(id);
        }
    }
}
