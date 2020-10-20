using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using p2pRest.ManagerDb;
using p2pRest.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace p2pRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistryController : ControllerBase
    {
        private ManageRegistry _mgRegistry = new ManageRegistry();
        

        // GET: api/<RegistryController>
        [HttpGet("{filename}")]
        public string Get(string filename)
        {
            return _mgRegistry.GetAll(filename);
        }

        // GET api/<RegistryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RegistryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RegistryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RegistryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
