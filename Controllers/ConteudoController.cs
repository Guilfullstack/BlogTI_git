using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DevOps.Models;

namespace DevOps.Controllers;

public class ConteudoController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ConteudoController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Ansible()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
