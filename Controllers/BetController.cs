using System.Linq;
using System.Web.Mvc;
using AutoMapper;
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

        public ActionResult Index()
        {
            var console = _context.Bets.ToList().Select(Mapper.Map<BetImpl, BetDto>);

            return View(console);
        }
        public ActionResult New()
        {
            var bet = new BetDto();
            return View("BetForm", bet);
        }


       

        public ActionResult Details(int id)
        {
            var console = _context.Bets.SingleOrDefault(g => g.Id == id);
            
            return View( console);
        }
        public ActionResult Edit(int id)
        {
            var bet = _context.Bets.SingleOrDefault(g => g.Id == id);

            if (bet == null)
            {
                return HttpNotFound();
            }

            return RedirectToAction("Index", bet);
        }
    }
}