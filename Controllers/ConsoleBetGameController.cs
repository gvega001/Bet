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
            var game = new ConsoleBetGameViewModel().Game;
          
            console.Game = _context.Games.Find(game);

            return View(console);
        }
        public ActionResult New()
        {
            var game = new GameImpl();
            var viewModel = new ConsoleBetGameViewModel();
            viewModel.Game = game;
            return View("GameForm",game);
        }
       
       
        [HttpPost]
        public ActionResult Save(GameImpl game)
        {
            if (game.Id == 0)
            {
                _context.Games.Add(game);
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "ConsoleBetGame");
        }

        public ActionResult Details(int id)
        {
            var console = _context.Games.SingleOrDefault(g => g.Id == id);
            var viewModel = new ConsoleBetGameViewModel();
            viewModel.Game = console;
            return View(console);
        }
        public ActionResult Edit(int id)
        {
            var game = _context.Games.SingleOrDefault(g => g.Id == id);

            if (game == null)
            {
                return HttpNotFound();
            }
            _context.Games.Add(game);
            _context.SaveChanges();
            return RedirectToAction("Index", "ConsoleBetGame");
        }
    }
}