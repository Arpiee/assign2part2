using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assign2API.Models;

namespace Assign2API.Controllers
{
    [Produces("application/json")]
    [Route("api/Choppers")]
    public class ChoppersController : Controller
    {
        private Model1 db;

        public ChoppersController(Model1 db)
        {
            this.db = db;
        }


        // GET: api/Choppers
        [HttpGet]
        public IEnumerable<Chopper> Get()
        {
            return db.Choppers.OrderBy(a => a.Title).ToList();
        }

        // GET: api/Choppers/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var chopper = db.Choppers.SingleOrDefault(a => a.ChopperId == id);

            if (chopper == null)
            {
                return NotFound();
            }

            return Ok(chopper);
        }
        
        // POST: api/Choppers
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Choppers/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
