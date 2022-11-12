using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EstacionamentoCode.Mvc.Models;
using EstacionamentoCode.Infra.Contexts;
using EstacionamentoCode.Dominio.Models;

namespace EstacionamentoCode.Mvc.Controllers;

public class HomeController : Controller
{
    private readonly Context _contexto;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, Context context)
    {
        _logger = logger;
        _contexto = context;
    }

    public IActionResult Index()
    {
        Estacionamento est = _contexto.Estacionamentos.FirstOrDefault();
        if (est == null)
            est = _contexto.CriarEstacionamentoTeste();

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
}
