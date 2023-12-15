using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lesson5.Models;
using System.Data.Common;

namespace lesson5.Controllers;

public class HomeController : Controller
{
    private readonly MydbCon db;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger,MydbCon mydbCon)
    {
        db = mydbCon;
        _logger = logger;
    }

//  [HttpPost]
//     public IActionResult Ourplans (plans plns){
//         List<plans> Plans = new List<plans>();
//         plans plan = new plans();
//         plan.planName = "پلن پایه";
//         plan.planLimit= 1;
//         plan.planPrice = 0;
//         Plans.Add(plan);
//     }

    public IActionResult Index()
    {
        var qplans = db.plans.ToList(); 
        return View(qplans);

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
