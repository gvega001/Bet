using System.Linq;
using System.Web.Mvc;
using Bet.Models;
using Bet.Models.ViewModels;

namespace Bet.Controllers
{
    public class ConsoleBetGameController : Controller
    {
        // GET
        private ApplicationDbContext _context;
        public ConsoleBetGameController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var console = new ConsoleBetGameViewModel();
          
            return View(console.GameImpl);
        }
        public ActionResult New()
        {
            var game = new GameImpl();
            return View("GameForm",game);
        }
       
       
        [HttpPost]
        public ActionResult Save(GameImpl gameImpl)
        {
            if (!ModelState.IsValid)
            {
                var game = gameImpl;
                return View("GameForm", game);
            }
            if (gameImpl.Id == 0)
            {
                _context.Games.Add(gameImpl);
            }
            else
            {
                var gameImplInDb = _context.Games.Single(g => g.Id == gameImpl.Id);
                gameImplInDb.Bets = gameImpl.Bets;
                gameImplInDb.EventDateTime = gameImpl.EventDateTime;
                gameImplInDb.EventName = gameImpl.EventName;
                gameImplInDb.LastDateTime = gameImpl.LastDateTime;
                gameImplInDb.LastDateAndTimeToBest = gameImpl.LastDateTime.ToString();
                gameImplInDb.DateOfEvent = gameImpl.EventDateTime.ToString();
                gameImplInDb.Team1Name = gameImpl.Team1Name;
                gameImplInDb.Team2Name = gameImpl.Team1Name;
                gameImplInDb.Team1Score = gameImpl.Team1Score;
                gameImplInDb.Team2Score = gameImpl.Team2Score;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "ConsoleBetGame");
        }

        public ActionResult Details(int id)
        {
            var console = _context.Games.SingleOrDefault(g => g.Id == id);
            var viewModel = new ConsoleBetGameViewModel();
            viewModel.GameImpl = console;
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