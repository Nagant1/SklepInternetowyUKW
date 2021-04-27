using Sklep.DAL;
using Sklep.Infrastructure;
using Sklep.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sklep.Controllers
{
    public class CartController : Controller
    {
        CartManager cartManager;
        FilmsContext db;
        ISessionManager session;

        public CartController()
        {
            db = new FilmsContext();
            session = new SessionManager();
            cartManager = new CartManager(db, session);
        }
        
        // GET: Cart
        public ActionResult Index()
        {
            CartViewModel cvm = new CartViewModel()
            {
                CartItems = cartManager.GetCartItems(),
                TotalPrice = cartManager.GetCartValue()
            };

            return View();
        }

        public ActionResult AddToCart(int id)
        {
            cartManager.AddToCart(id);

            return RedirectToAction("Index");
        }
    }
}