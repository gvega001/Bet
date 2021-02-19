using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Bet.DTO;
using Bet.Models;
using Bet.Models.ViewModels;

namespace Bet.Controllers
{
    public class GameController : Controller
    {
        // GET
        private ApplicationDbContext _context;
        public GameController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult New()
        {
            var game = new GameDto();
            return View("GameForm",game);
        }
       
       
      
        public ActionResult Save()
        {
            var game = new GameDto();
            return View("GameForm", game);
        }

        public ActionResult Details(int id)
        {
            var console = _context.Games.Select(Mapper.Map<GameImpl,GameDto>).SingleOrDefault(g => g.Id == id);
            
            return View("GameForm", console);
        }
        public ActionResult Edit(int id)
        {
            var game = _context.Games.SingleOrDefault(g => g.Id == id);
            
            if (game == null)
            {
                return HttpNotFound();
            }

            return RedirectToAction("Index", game);
        }
    }
}