namespace Domain.Models;

public class LineType
{
    public Guid Id { get; private set; }
    public string Name { get; set; } = null!;

    private LineType(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public static LineType Create(string name)
        => new(Guid.NewGuid(), name);
}