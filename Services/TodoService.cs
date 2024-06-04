using DotNetTodos.Models;

namespace DotNetTodos.Services;

public static class TodoService
{
    static List<Todo> Todos { get; }
    static int nextId = 3;
    static TodoService()
    {
        Todos = new List<Todo>
        {
            new Todo { Id = 1, Title = "Create Repository", Description = "Create a new repository on GitHub", IsCompleted = false },
            new Todo { Id = 2, Title = "Push to Repository", IsCompleted = false },
        };
    }

    public static List<Todo> GetAll() => Todos;

    public static Todo? Get(int id) => Todos.FirstOrDefault(t => t.Id == id);

    public static void Add(Todo todo)
    {
        todo.Id = nextId++;
        Todos.Add(todo);
    }

    public static void Delete(int id)
    {
        var todo = Get(id);
        if (todo is null)
            return;

        Todos.Remove(todo);
    }

    public static void Update(Todo todo)
    {
        var index = Todos.FindIndex(t => t.Id == todo.Id);
        if (index == -1)
            return;

        Todos[index] = todo;
    }
}