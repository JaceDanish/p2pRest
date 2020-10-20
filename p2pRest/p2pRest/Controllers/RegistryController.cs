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

        // POST api/<RegistryController>
        [HttpPost("{filename}")]
        public int Post([FromBody] String jSon, String filename)
        {
            return _mgRegistry.Register(filename, jSon);
        }

        // PUT api/<RegistryController>/5
        [HttpPut("{filename}")]
        public int Put(String filename, [FromBody] string jSon)
        {
            return _mgRegistry.Deregister(filename, jSon);
        }
    }
}
