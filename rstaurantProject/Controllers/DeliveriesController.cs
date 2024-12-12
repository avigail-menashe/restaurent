using Microsoft.AspNetCore.Mvc;
using restaurant.Core.enties;
using restaurant.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rstaurantProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveriesController : ControllerBase
    {
        private IDeliveryService _deliveryService;
        public DeliveriesController(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }
        // GET: api/<DeliveriesController>
        [HttpGet]
        public IEnumerable<Delivery> Get()
        {
            return _deliveryService.GetDeliveries();
        }

        // GET api/<DeliveriesController>/5
        [HttpGet("{id}")]
        public Delivery Get(int id)
        {
            return _deliveryService.GetDeliveryById(id);
        }

        // POST api/<DeliveriesController>
        [HttpPost]
        public Delivery Post([FromBody] Delivery value)
        {
            _deliveryService.Post(value);
            return value;
        }

        // PUT api/<DeliveriesController>/5
        [HttpPut("{id}")]
        public Delivery Put(int id, [FromBody] Delivery value)
        {
            return _deliveryService.Put(id, value);
        }

        // DELETE api/<DeliveriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _deliveryService.Delete(id);
        }
    }
}
