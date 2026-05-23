using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace product.Pages.Product;

public class CreateModel : PageModel
{
    private readonly AppDbContext _context;

    public CreateModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public string CustomerName { get; set; } = string.Empty;

    [BindProperty]
    public string ProductName { get; set; } = string.Empty;

    [BindProperty]
    public DateTime ProductDate { get; set; }

    [BindProperty]
    public int Quantity { get; set; }

    [BindProperty]
    public decimal Price { get; set; }

    public IActionResult OnPost()
    {
        var product = new global::product.Models.Product
        {
            CustomerName = CustomerName,
            ProductName = ProductName,
            ProductDate = ProductDate,
            Quantity = Quantity,
            Price = Price
        };

        _context.Products.Add(product);
        _context.SaveChanges();

        return RedirectToPage();
    }
}