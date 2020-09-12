using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DatingApp.API.Data;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            this._context = context;
        }

        // GET api/values
        [HttpGet]
        // // public ActionResult<IEnumerable<string>> Get()
        // public IActionResult GetValues()
        // {
        //     List<Models.Value> values = this._context.Values.ToList();

        //     return Ok(values);
        //     //return new string[] { "value1", "value2" };
        // }
        public async Task<IActionResult> GetValues ()
        {
            List<Models.Value> values = await this._context.Values.ToListAsync();

            return Ok(values);
            //return new string[] { "value1", "value2" };            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        // public IActionResult GetValue(int id)
        // {
        //     Models.Value value = this._context.Values.FirstOrDefault(x => x.Id.Equals(id));

        //     return Ok(value);
        // }
        public async Task<IActionResult> GetValue(int id)
        {
            Models.Value value = await this._context.Values.FirstOrDefaultAsync(x => x.Id.Equals(id));

            return Ok(value);
        }        

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
