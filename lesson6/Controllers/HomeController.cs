using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lesson5.Models;
using System.Data.Common;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Globalization;
using System.Collections.Frozen;
using NuGet.Protocol;

namespace lesson5.Controllers;

public class HomeController : Controller
{
  
// PersianCalendar pc = new PersianCalendar();
//         DateTime thisDate = DateTime.Now;
    private readonly MydbCon db;
    private readonly ILogger<HomeController> _logger;

    private readonly IWebHostEnvironment WebHostEnvironment;


    public HomeController(ILogger<HomeController> logger,MydbCon mydbCon,IWebHostEnvironment WebHostEnvironment)
    {
        this.WebHostEnvironment = WebHostEnvironment;
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
        var qposts = db.posts.ToList(); 
        
        return View(qposts);

    }

    
    public IActionResult insertPosts(posts Posts)
    {

        #region Upload
        string UniqueFileName = Guid.NewGuid() + Posts.Image.FileName;
        string UploadFolder = Path.Combine(WebHostEnvironment.WebRootPath, UniqueFileName);
        using(FileStream fs = new FileStream(UploadFolder, FileMode.Create))
        {
            Posts.Image.CopyTo(fs);
        }
        #endregion

        #region Save_To_db
        Posts.ImagePath = UniqueFileName;
        db.posts.Add(Posts);
        db.SaveChanges();  
        #endregion

         return RedirectToAction("Index");
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
