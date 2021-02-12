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
        public ViewResult Index()
        {

            var player = _context.Players.SingleOrDefault();
            
            var viewModel = new BetViewModels(player);
          
            return View(viewModel);
        }
        public ActionResult New()
        {
            var player = _context.Players.SingleOrDefault(); 
            var groupView = new BetViewModels(player);
            return View(groupView.Bet);
        }
        public ViewResult Details()
        {
            var player = _context.Players.SingleOrDefault();
            var betViewModel = new BetViewModels(player);

            betViewModel.Bet = _context.Bets.SingleOrDefault();
            
            return View(betViewModel);
        }
      
        [HttpPost]
        public ActionResult Create(BetImpl bet)
        {
            _context.Bets.Add(bet);
            _context.SaveChanges();


            return RedirectToAction("Index", "Bet");

        }
        public ActionResult Edit(BetImpl bet)
        {
            _context.Bets.Add(bet);
            _context.SaveChanges();


            return RedirectToAction("Index", "Bet");
        }
    }
}