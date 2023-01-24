using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SchoolProjectMVC.Models;

namespace SchoolProjectMVC.Controllers;

//Los Controllers se crean con el nombre de la View + Controller. Las actions con los cshtml.

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
//Para cada destino que quiero agregar. tengo que tener un action.
    public IActionResult Index()
    {
        //do stuff... aca se añade todo como la magia y despues se devuelve la view.
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult About()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
