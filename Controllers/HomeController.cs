using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Nisan2.Models;

namespace Nisan_2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {   
    var products = Repository.GetProducts.Where(p => p.IsActive && p.Listed);
    return View(products);
    }

    public IActionResult AllProducts()
    {
        var products = Repository.GetProducts.Where(p => p.IsActive);
        return View(products);
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
}
