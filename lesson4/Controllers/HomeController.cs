using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lesson4.Models;

namespace lesson4.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        using Microsoft.AspNetCore.Mvc;
using projectZ.Models;
using System.Diagnostics;

namespace projectZ.Controllers
{
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
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Store(Products product02)
        {
            List<usertbl> products = new List<usertbl>();
            simpledatabase_withLists user = new simpledatabase_withLists();
            user.Id = 1;
            user.Name = "JohnDoe";
            user.Coin = 568000;
            user.InvitedUser = 1;
            user.userIsVIP = false;
            user.gender = true; // male = true || female = false 
            usertbl.Add(user);
           
           user.Id =2;
            user.Name = "mrX";
            user.Coin = 5222;
            user.InvitedUser = 5;
            user.userIsVIP = true;
            user.gender = true; // male = true || female = false 
            usertbl.Add(user);

            user.Id = 3;
            user.Name = "misY";
            user.Coin = 6999999;
            user.InvitedUser = 90;
            user.userIsVIP = true;
            user.gender = false; // male = true || female = false 
            usertbl.Add(user);

            user.Id = 4;
            user.Name = "sandy";
            user.Coin = 89000;
            user.InvitedUser = 0;
            user.userIsVIP = false;
            user.gender = false; // male = true || female = false 
            usertbl.Add(user);


           
            var users = usertbl.Where(x=>x.userIsVIP == true ).ToList();
            
            var menCount= usertbl.Count(x=>x.gender == true );
            ViewBag.menCount = menCount;

            return View(users);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
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
