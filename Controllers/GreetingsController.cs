using DotnetApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace DotnetApi.Controllers
{

    [Route("api/users")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        [HttpGet]
        [Produces("application/json")]
        public List<User> GetUser()
        {
            var users = new List<User>
            {
                new User { Id = Guid.NewGuid(), Name = "Alice", Email = "alice@example.com" },
                new User { Id = Guid.NewGuid(), Name = "Bob", Email = "bob@example.com" },
                new User { Id = Guid.NewGuid(), Name = "Charlie", Email = "charlie@example.com" }
            };

            return users;
        }

    }
}