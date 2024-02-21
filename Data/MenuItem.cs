namespace Pos1988.Data;

public class MenuItem
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public string Category { get; set; }

    public bool IsSelected { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; }

}
