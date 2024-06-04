using DotnetTodos.Models;

namespace DotnetTodos.Services;

public static class TodoService
{
    static List<Todo> Todos { get; }
    static int nextId = 3;
    static TodoService()
    {
        Todos = new List<Todo>
        {
            new Todo { Id = 1, Title = "Create Repository", IsCompleted = false },
            new Todo { Id = 2, Title = "Push to Repository", Description = "Push the code to the repository", IsCompleted = false }
        };
    }

    public static List<Todo> GetAll() => Todos;

    public static Todo? Get(int id) => Todos.FirstOrDefault(p => p.Id == id);

    public static void Add(Todo Todo)
    {
        Todo.Id = nextId++;
        Todos.Add(Todo);
    }

    public static void Delete(int id)
    {
        var Todo = Get(id);
        if (Todo is null)
            return;

        Todos.Remove(Todo);
    }

    public static void Update(Todo Todo)
    {
        var index = Todos.FindIndex(p => p.Id == Todo.Id);
        if (index == -1)
            return;

        Todos[index] = Todo;
    }
}