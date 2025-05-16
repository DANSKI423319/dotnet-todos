using Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
    private readonly TodoService _todoService;

    public TodoController(TodoService todoService)
    {
        _todoService = todoService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Todo>>> GetAll()
    {
        return await _todoService.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Todo>> Get(int id)
    {
        var todo = await _todoService.GetAsync(id);

        if (todo == null)
        {
            return NotFound();
        }

        return todo;
    }

    [HttpPost]
    public async Task<IActionResult> Create(Todo todo)
    {
        await _todoService.AddAsync(todo);

        return CreatedAtAction(nameof(Get), new { id = todo.Id }, todo);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Todo todo)
    {
        if (id != todo.Id)
        {
            return BadRequest();
        }

        var success = await _todoService.UpdateAsync(todo);
        if (!success)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await _todoService.DeleteAsync(id);
        if (!success)
        {
            return NotFound();
        }

        return NoContent();
    }
}