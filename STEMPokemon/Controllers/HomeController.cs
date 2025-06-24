using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using STEMPokemon.Models;
using STEMPokemon.Services;

namespace STEMPokemon.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly SQLPokemonRepository _repo;

    public HomeController(ILogger<HomeController> logger, SQLPokemonRepository repo)
    {
        _logger = logger;
        _repo = repo;
    }

    public IActionResult Index()
    {
        var allPokemons = _repo.GetAllPokemons();
        return View(allPokemons);
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
