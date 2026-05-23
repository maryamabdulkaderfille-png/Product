
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace product.Pages.Product;

public class IndexModel : PageModel
{
    private readonly AppDbContext _context;

    public IndexModel(AppDbContext context)
    {
        _context = context;
    }

    public List<global::product.Models.Product> products { get; set; } = new();

    public void OnGet()
    {
        products = _context.Products.ToList();
    }
}