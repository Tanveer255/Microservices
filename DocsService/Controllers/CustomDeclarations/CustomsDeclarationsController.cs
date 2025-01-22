using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DocsService.Controllers.CustomDeclarations
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomsDeclarationsController : ControllerBase
    {
        // GET: api/<CustomsDeclarationsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "CustomsDeclarations1", "CustomsDeclarations1" };
        }

        // GET api/<CustomsDeclarationsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomsDeclarationsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomsDeclarationsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomsDeclarationsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
