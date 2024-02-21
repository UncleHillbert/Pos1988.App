namespace Pos1988.Data;

public class Order
{
    public int Id { get; set; }
    public DateTime Created { get; set; }

    public List<OrderItem> Items { get; set; }
    public decimal Price { get; set; }
    public decimal Total { get; set; }
}
