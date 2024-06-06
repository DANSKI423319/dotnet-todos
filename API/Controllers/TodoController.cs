using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

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

    [HttpGet("{id}")]
    public ActionResult<Todo> Get(int id)
    {
        var todo = TodoService.Get(id);

        if (todo == null)
        {
            return NotFound();
        }

        return todo;
    }

    [HttpPost]
    public IActionResult Create(Todo todo)
    {
        TodoService.Add(todo);

        return CreatedAtAction(nameof(Get), new { id = todo.Id }, todo);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Todo todo)
    {
        if (id != todo.Id)
        {
            return BadRequest();
        }

        var existingTodo = TodoService.Get(id);
        if (existingTodo is null)
        {
            return NotFound();
        }

        TodoService.Update(todo);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var todo = TodoService.Get(id);

        if (todo is null)
        {
            return NotFound();
        }

        TodoService.Delete(id);

        return NoContent();
    }
}