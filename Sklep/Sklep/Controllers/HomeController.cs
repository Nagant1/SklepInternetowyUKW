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
            

            IndexViewModel model = new IndexViewModel();
            
            var nowosci = db.Films.OrderByDescending(f => f.Length).Take(3);
            model.Top3LongestFilms = nowosci;
            return View(model);

        }
        
        public ActionResult StaticSite(string name)
        {
            return View(name);
        }
    
    }
}