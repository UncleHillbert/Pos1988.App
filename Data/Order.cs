namespace Pos1988.Data;

public class Order
{
    public int Id { get; set; }

    public string Status { get; set; }

    public DateTime OrderDate { get; set; }

    public int TableId { get; set; }

    public virtual Table Table { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; }

    public decimal Total { get; set; }
}
