using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RazorIssue8502_api.Models;

namespace RazorIssue8502_api.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public async Task<IActionResult> AppendLineItems(int startIndex, int numberOfLines, int? discount)
    {
        var items = new List<LineItemWithIndex>();

        for (var i = startIndex; i < startIndex + numberOfLines; i++)
        {
            items.Add(new LineItemWithIndex(i, discount ?? 0));
        }

        return PartialView("~/Views/Shared/AppendLineItems.cshtml", items);
    }
}
