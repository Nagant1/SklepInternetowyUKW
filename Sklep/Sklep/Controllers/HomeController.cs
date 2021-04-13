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
            var categories = db.Categories.ToList();
            IndexViewModel ivm = new IndexViewModel();
            ivm.Categories = categories;
            return View(ivm);
        }
        
        public ActionResult StaticSite(string name)
        {
            return View(name);
        }
    
    }
}