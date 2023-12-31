namespace Entities;
public class Product

{
    public int ProductId { get; set; }
    public string? ProductName { get; set; }=String.Empty;

    public decimal Price { get; set; }

    public string? Description { get; set; }
}
