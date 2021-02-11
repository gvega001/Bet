using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Bet.Models;
using Bet.Models.ViewModels;

namespace Bet.Controllers
{
    public class BetController : Controller
    {
        // GET
        private ApplicationDbContext _context;
        public BetController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var betViewModel = new BetViewModels();
            var bets = betViewModel.Bets;
            var id = betViewModel.PlayerId;
            betViewModel.Player = _context.Players.Find(id);
            betViewModel.Bets = _context.Bets.Find(bets);
            
            if (betViewModel.Player == null)
                return HttpNotFound();

            return View(betViewModel);
        }

        public ActionResult Details()
        {
            var betViewModel = new BetViewModels();
            var bets = betViewModel.Bets;
            var id = betViewModel.PlayerId;
            betViewModel.Player = _context.Players.Find(id);
            betViewModel.Bets = _context.Bets.Find(bets);

            if (betViewModel.Player == null)
                return HttpNotFound();

            return View(betViewModel);
        }

        public ActionResult New()
        {

            return View();
        }
    }
}