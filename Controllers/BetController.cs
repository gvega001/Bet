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
            var betViewModel = new BetViewModels(player);
         
            betViewModel.Bet =_context.Bets.SingleOrDefault();

            return View(betViewModel);
        }

        public ViewResult Details()
        {
            var player = _context.Players.SingleOrDefault();
            var betViewModel = new BetViewModels(player);

            betViewModel.Bet = _context.Bets.SingleOrDefault();
            
            return View(betViewModel);
        }
        [HttpPost]
        public ActionResult Create(NewBetViewModels betViewModel)
        {
            _context.Bets.Add(betViewModel.Bet);
            _context.SaveChanges();

            return View();
          
        }
        [HttpPut]
        public ActionResult Edit(NewBetViewModels betViewModel)
        {
            _context.Bets.Add(betViewModel.Bet);
            _context.SaveChanges();

            return View();
        }
    }
}