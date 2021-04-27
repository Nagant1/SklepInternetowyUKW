using Sklep.DAL;
using Sklep.Models;
using Sklep.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sklep.Controllers
{
    public class HomeController : Controller
    {
        FilmsContext db = new FilmsContext();
        
        // GET: Home
        public ActionResult Index()
        {
            

            
            
            var Top3LongestFilms = db.Films.OrderByDescending(f => f.Length).Take(3);
            
            return View(Top3LongestFilms);

        }
        
        public ActionResult StaticSite(string name)
        {
            return View(name);
        }
        
        public ActionResult Test()
        {
            return View();
        }
    }
}