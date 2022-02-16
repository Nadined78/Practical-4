using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SMS.Web.Models;

namespace SMS.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var longTime = DateTime.Now;
        var message = "Time Now";

        ViewBag.LongTime = longTime;
        ViewBag.Message = message;

        return View();
    }

    public IActionResult About()
    {
        // construct the view model
        var about = new AboutViewModel
        {
            Title = "Nadine",
            Message = "Hello",
            Company = "Doherty Enterprise",
            Formed = new DateTime(2020, 01, 01)   //single property needed to construct view model    
        };  

        // render the view
        return View(about); //view model passed to the view 
    } 

    public IActionResult Privacy()
    {
        return View();
    }
}