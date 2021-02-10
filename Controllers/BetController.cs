using System.Collections.Generic;
using System.Web.Mvc;
using Bet.Models.ViewModels;

namespace Bet.Controllers
{
    public class BetController : Controller
    {
        // GET
        public ActionResult Index()
        {
            var bet = new BetViewModel();
            LinkedList<BetViewModel> _bets = new LinkedList<BetViewModel>();
            return View(bet);
        }
    }
}