using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TerminalServer.Models;

namespace TerminalServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentSystemController : ControllerBase
    {
        private readonly PaymentSystemContext _context;

        public PaymentSystemController(PaymentSystemContext context)
        {
            _context = context;
        }

        // GET: api/PaymentSystem
        [HttpGet]
        public IEnumerable<Seller> Get()
        {
            var qq = _context.Sellers.ToList();
            var qq2 = _context.Terminals.ToList();

            return _context.Sellers;
        }

        // GET: api/PaymentSystem/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PaymentSystem
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/PaymentSystem/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
