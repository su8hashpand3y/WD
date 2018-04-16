using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WD.Models;

namespace WD.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        //public IActionResult ADD([FromServices]IServiceProvider s)
        //{
        //    var c = s.GetService(typeof(WDContext)) as WDContext;
        //    c.Posts.Add(new Post());
        //    c.SaveChanges();
        //    return View();
        //}

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
