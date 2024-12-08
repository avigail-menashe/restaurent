using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using restaurant.Core.Services;
using restaurant.Core.enties;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace rstaurantProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

  

    public class ClientsController : ControllerBase
    {
        private IClientService _clientService;
        
        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        static int count = 3;
        // GET: api/<ClientsController>
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _clientService.GetClients();
        }

        // GET api/<ClientsController>/5
        [HttpGet("{id}")]
        public Client Get(int id)
        {
            
            return _clientService.GetClientById(id);

        }

        // POST api/<ClientsController>
        [HttpPost]
        public Client Post([FromBody] Client value)
        {
           
            _clientService.Post(value);
             return value;
        }

        // PUT api/<ClientsController>/5
        [HttpPut("{id}")]
        public Client Put(int id, [FromBody] Client value)
        {
           return _clientService.Put(id, value);
        }

        // DELETE api/<ClientsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
         _clientService.Delete(id);

        }
    }
}
