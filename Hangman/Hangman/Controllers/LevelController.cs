using System;
using System.Web.Mvc;

namespace Hangman.Controllers
{
    public class LevelController : Controller
    {
        public ActionResult Easy()
        {
            Random rnd = new Random();
            ViewBag.Words = Words.PickARandom(rnd, Words.easy);
            return View("GameField");
        }

        public ActionResult Medium()
        {
            Random rnd = new Random();
            ViewBag.Words = Words.PickARandom(rnd, Words.medium);
            return View("GameField");
        }

        public ActionResult Hard()
        {
            Random rnd = new Random();
            ViewBag.Words = Words.PickARandom(rnd, Words.hard);
            return View("GameField");
        }
    }
}