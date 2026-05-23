using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace product.Pages.Product;

public class EditModel : PageModel
{
    private readonly AppDbContext _context;

    public EditModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public global::product.Models.Product product { get; set; } = new();

    public void OnGet(int id)
    {
        product = _context.Products.Find(id)!;
    }

    public IActionResult OnPost()
    {
        _context.Products.Update(product);
        _context.SaveChanges();

        return RedirectToPage("Index");
    }
}