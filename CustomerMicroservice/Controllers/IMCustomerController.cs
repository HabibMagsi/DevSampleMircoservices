using CustomerMicroservice.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IMCustomerController : ControllerBase
    {
        private static List<Customer> _customerList = new List<Customer>();
        // GET: api/<IMCustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerList;
        }

        // GET api/<IMCustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _customerList[id];
            
        }

        // POST api/<IMCustomerController>
        [HttpPost]
        public void Post([FromBody] Customer cust)
        {
            _customerList.Add(cust);
        }

        // PUT api/<IMCustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer cust)
        {
            _customerList[id-1] = cust;
        }

        // DELETE api/<IMCustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _customerList.RemoveAt(id);
        }
    }
}
