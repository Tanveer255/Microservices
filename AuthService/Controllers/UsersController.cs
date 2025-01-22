using Microsoft.AspNetCore.Mvc;
using JwtAuthentication.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IJwtAuthenticationService _authService;
        public UsersController(IJwtAuthenticationService authService)
        {
            _authService = authService;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "user1", "user2" };
        }
        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLogin user)
        {
            if (user.Username == "admin" && user.Password == "admin123")
            {
                var token = _authService.GenerateTokenAsync(user.Username);
                return Ok(new { token });
            }
            return Unauthorized();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        public class UserLogin
        {
            public string Username { get; set; } = "admin";
            public string Password { get; set; } = "admin123";
        }
    }
}
