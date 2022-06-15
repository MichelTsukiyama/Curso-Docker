using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC2.Models;

namespace MVC2.Controllers;

public class HomeController : Controller
{
    private IRepository repository;
    private string message;

    public HomeController(IRepository repo, IConfiguration config)
    {
        this.repository = repo;
        message = $"Docker - ({config["HOSTNAME"]})";
    }

    public IActionResult Index()
    {
        ViewBag.Message = message;
        return View(repository.Produtos);
    }
}
