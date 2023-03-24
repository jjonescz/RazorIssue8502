using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorIssue8502.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public IEnumerable<dynamic> Items { get; private set; }

    public void OnGet()
    {
        Items = new dynamic[]
        {
            new {
                Index = 0,
                Sku = "sku1",
                ProductId = 123,
                Id = 456,
                Quantity = 0,
                Price = 42,
                Discount = 0,
                Description = "My product 1",
            },
            new {
                Index = 1,
                Sku = "sku2",
                ProductId = 124,
                Id = 457,
                Quantity = 1,
                Price = 43,
                Discount = 5,
                Description = "My product 2",
            }
        };
    }
}
