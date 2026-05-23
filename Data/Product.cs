namespace product.Models;

public class Product
{
    public int id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public DateTime ProductDate { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
