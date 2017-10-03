using System;
using System.Linq;
using System.Web.Mvc;

namespace Hangman.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {          
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About the game.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact me.";
            return View();
        }

        public ActionResult EasyGame()
        {
            return View("GameField");
        }
    }
}