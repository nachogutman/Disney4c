using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Disney4c.Models;

namespace Disney4c.Controllers;

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
    public IActionResult VerDetallePersonaje(int IdPersonaje)
    {
        ViewBag.InfoPersonaje = BD.VerInfoPersonaje(IdPersonaje);
        ViewBag.listaPersonajes = BD.ListarPersonajes();
        return View("DetallePersonaje");
    }
    public IActionResult VerPersonajes()
    {
        ViewBag.listaPersonajes = BD.ListarPersonajes();
        return View ("Personajes");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
