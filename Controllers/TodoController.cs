using DotnetTodos.Services;
using DotnetTodos.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetTodos.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
    public TodoController()
    {
        // 
    }

    [HttpGet]
    public ActionResult<List<Todo>> GetAll()
    {
        return TodoService.GetAll();
    }
}