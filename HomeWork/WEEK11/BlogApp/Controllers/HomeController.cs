using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogApp.Models;

namespace BlogApp.Controllers;

public class HomeController : Controller
{
   
    public IActionResult Index()
    {
        return View();
    }

}
