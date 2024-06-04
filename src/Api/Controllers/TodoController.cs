using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTodos()
        {
            return Ok("Hello World");
        }
    }
}