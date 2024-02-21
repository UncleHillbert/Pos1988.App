namespace Pos1988.Data;

public class OrderItem
{
    public int Id { get; set; }

    public int Quantity { get; set; }

    public int MenuItemId { get; set; }

    public virtual MenuItem MenuItem { get; set; }

    public int OrderId { get; set; }

    public virtual Order Order { get; set; }
}
