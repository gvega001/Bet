using System.Linq;
using System.Web.Http.Results;
using System.Web.Mvc;
using System.Web.Security;
using Antlr.Runtime.Misc;
using AutoMapper;
using Bet.DTO;
using Bet.Models;
using Bet.Models.ViewModels;

namespace Bet.Controllers
{
    [Authorize]
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


        public ActionResult Index()
        {
            if (User!=null)
            {
                return View();
            }
            return HttpNotFound();
          
        }
      
        public ActionResult New()
        {
            var bet = new BetDto();
            return View("BetForm", bet);
        }
      
        public ActionResult Save()
        {
            var bet = new BetDto();

            return View("BetForm", bet);
        }
       
        public ActionResult Details(int id)
        {
            var console = _context.Bets.Select(Mapper.Map<BetImpl,BetDto>).SingleOrDefault(g => g.Id == id);
            
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