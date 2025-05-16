namespace Core.Entities;

public class Todo : BaseEntity
{
    public required string Task { get; set; }
    public DateTime? CompletedAt { get; set; }
}