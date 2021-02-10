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
            var betViewModel = new BetViewModel();
            betViewModel.Player = new Player();

            return View(betViewModel);
        }
    }
}