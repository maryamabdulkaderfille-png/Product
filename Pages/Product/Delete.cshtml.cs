using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace product.Pages.Product;

public class DeleteModel : PageModel
{
    private readonly AppDbContext _context;

    public DeleteModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public global::product.Models.Product product { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        product = _context.Products.Find(id)!;
        if (product == null)
        {
            return NotFound();
        }

        return Page();
    }

    public IActionResult OnPost()
    {
        _context.Products.Remove(product);
        _context.SaveChanges();

        return RedirectToPage("Index");
    }
}