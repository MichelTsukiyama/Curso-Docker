﻿using System.Diagnostics;
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
        message = config["MESSAGE"] ?? "ASPNET Core MVC - Docker";
    }

    public IActionResult Index()
    {
        ViewBag.Message = message;
        return View(repository.Produtos);
    }
}
