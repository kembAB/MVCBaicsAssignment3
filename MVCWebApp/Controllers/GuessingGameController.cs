using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCWebApp.Models.GuessingGame;
using MVCWebApp.Models;
using System.Diagnostics;

namespace MVCWebApp.Controllers
{
    public class GuessingGameController : Controller
    {
        //random number generating
        [HttpGet]
        public IActionResult Index()
        {
            var model = new GuessingProperties();
            model.GenerateRandomNumber();
            return View(model);
        }
      
        [HttpPost]
        public IActionResult Index(GuessingProperties mymodel)
        {

            if (ModelState.IsValid)
            {
                mymodel.ShowResult = true;
                var resul = new comparePlyerRandomNum();
                ViewBag.Result = resul.GetResult(ref mymodel);
            }
            return View(mymodel);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Errror { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
