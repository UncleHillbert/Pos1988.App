namespace Pos1988.Data;

public class Table
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Capacity { get; set; }

    public string Location { get; set; }

    public string Category { get; set; }

    public bool IsAvailable { get; set; }

    public int? OrderId { get; set; }

    public virtual Order Order { get; set; }
}

