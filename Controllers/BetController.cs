using System.Collections.Generic;
using System.Web.Mvc;
using Bet.Models;
using Bet.Models.ViewModels;

namespace Bet.Controllers
{
    public class BetController : Controller
    {
        // GET
        public ActionResult Index()
        {
            var betViewModel = new BetViewModels();

            return View(betViewModel);
        }

        public ActionResult New()
        {

            return View();
        }
    }
}