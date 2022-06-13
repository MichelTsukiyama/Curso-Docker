using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC1.Models;

namespace MVC1.Controllers;

public class HomeController : Controller
{
    private IRepository repository;
    private string message;

    public HomeController(IRepository repo, IConfiguration config)
    {
        this.repository = repo;
        message = config["MESSAGE"] ?? "ASPNET Core MVC - Docker";
    }

    public IActionResult Index()
    {
        ViewBag.Message = message;
        return View(repository.Produtos);
    }
}
