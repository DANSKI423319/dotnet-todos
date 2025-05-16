using Core.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Core.Services;

public class TodoService
{
    private readonly AppDbContext _dbContext;

    public TodoService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Todo>> GetAllAsync()
    {
        return await _dbContext.Todos.ToListAsync();
    }

    public async Task<Todo?> GetAsync(int id)
    {
        return await _dbContext.Todos.FindAsync(id);
    }

    public async Task AddAsync(Todo todo)
    {
        await _dbContext.Todos.AddAsync(todo);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<bool> UpdateAsync(Todo todo)
    {
        var existingTodo = await _dbContext.Todos.FindAsync(todo.Id);
        if (existingTodo == null)
        {
            return false;
        }

        existingTodo.Title = todo.Title;
        existingTodo.Description = todo.Description;
        existingTodo.IsCompleted = todo.IsCompleted;

        await _dbContext.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var todo = await _dbContext.Todos.FindAsync(id);
        if (todo == null)
        {
            return false;
        }

        _dbContext.Todos.Remove(todo);
        await _dbContext.SaveChangesAsync();
        return true;
    }
}