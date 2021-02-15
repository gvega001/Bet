using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Bet.DTO;
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
        public ActionResult Index(int id)
        {

            var bet = _context.Bets.SingleOrDefault(b => b.Id == id);
            if (bet == null)
            {
                return HttpNotFound();
            }
             
            return View(bet);
        }
        public ActionResult New()
        {
           
            return View("BetForm");
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

                betInDb.Guess = betImpl.Guess;
            }
            
            _context.SaveChanges();

            return RedirectToAction("Index", "Bet");

        }
        public ActionResult Details(int id)
        {
            var bet = _context.Bets.SingleOrDefault(b=>b.Id==id);
            if (bet == null)
            {
                return HttpNotFound();
            }

            return View("BetForm",bet);
        }
        
        public ActionResult Edit(int id)
        {
            var bet = _context.Bets.SingleOrDefault(b => b.Id == id);
            if (bet == null)
            {
                return HttpNotFound();
            }

            return RedirectToAction("Index", "Bet");
        }
    }
}