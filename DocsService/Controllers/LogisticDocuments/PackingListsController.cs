using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DocsService.Controllers.LogisticDocuments
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackingListsController : ControllerBase
    {
        // GET: api/<PackingListsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "packingList1", "packingList1" };
        }

        // GET api/<PackingListsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PackingListsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PackingListsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PackingListsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
