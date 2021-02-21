using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Bet.Controllers.Api;
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

        public ActionResult Save(int id, GameDto gameDto)
        {

            var game = _context.Games.Select(Mapper.Map<GameImpl, GameDto>).SingleOrDefault(g => g.Id == id);
            var gamesUpdated = new GamesController();

            gamesUpdated.UpdateGame(id, gameDto);

            return View("Save", game);
        }
        public ActionResult Details(int id)
        {
            var console = _context.Games.Select(Mapper.Map<GameImpl,GameDto>).SingleOrDefault(g => g.Id == id);
            
            return View("Details", console);
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