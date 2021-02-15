using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Bet.Models;
using Bet.Models.ViewModels;

namespace Bet.Controllers
{
    public class BetController : Controller
    {
      
        private ApplicationDbContext _context;
        public BetController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index(int id)
        {
            var bet = _context.Bets.SingleOrDefault(b => b.Id == id);

          
            return View(bet);
        }
        public ActionResult New(int id)
        {
           
            var bet = _context.Bets.SingleOrDefault(b => b.Id == id);
            return View("BetForm", bet);
        }
        [HttpPost]
        public ActionResult Save(BetImpl betImpl)
        {
            if (!ModelState.IsValid)
            {
                var bet = new BetImpl();
                return View("BetForm", bet);
            }

            if (betImpl.Id == 0)
            {
                _context.Bets.Add(betImpl);
            }
            else
            {
                var betInDb = _context.Bets.Single(b => b.Id == betImpl.Id);
       
                betInDb.LowestPossibleNumber = betImpl.LowestPossibleNumber;
                betInDb.MaxPossibleNumber = betImpl.MaxPossibleNumber;
                betInDb.MoneyBet = betImpl.MoneyBet;
                betInDb.PlayerId = betImpl.PlayerId;
                betInDb.Guess = betImpl.Guess;
            }
            
            _context.SaveChanges();

            return RedirectToAction("Index", "Bet");

        }
        public ActionResult Details(int id)
        {
            var bet = _context.Bets.SingleOrDefault(b=>b.PlayerId==id);
            if (bet == null)
            {
                return HttpNotFound();
            }
            var betViewModel =  new BetFormViewModels
            {
                Bet = bet
            };

            return View("BetForm",bet);
        }
        
        public ActionResult Edit(int id)
        {
            var bet = _context.Bets.SingleOrDefault(b => b.PlayerId == id);
            if (bet == null)
            {
                return HttpNotFound();
            }

            return RedirectToAction("Index", "Bet");
        }
    }
}