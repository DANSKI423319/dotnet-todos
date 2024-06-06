namespace Core.Entities;

public class Todo : BaseEntity
{
    public required string Title { get; set; }
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
}