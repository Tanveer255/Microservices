using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DocsService.Controllers.JobDocuments
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstalationOrdersController : ControllerBase
    {
        // GET: api/<InstalationOrdersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "InstalationOrder1", "InstalationOrder2" };
        }

        // GET api/<InstalationOrdersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<InstalationOrdersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<InstalationOrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<InstalationOrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
