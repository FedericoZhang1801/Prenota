using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using prenota5H.Models;

namespace prenota5H.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private static List<Utente> Utenti = new List<Utente>();
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

    
    public IActionResult Prenota()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Prenotato(Utente u)
    {
        Utenti.Add( u );
        return View( Utenti );
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
