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
          
            var group = new ConsoleBetGameViewModel().Group;
            console.Game = _context.Games.Find(game);
          

            return View(console);
        }
        public ActionResult Details()
        {
            var console = new ConsoleBetGameViewModel();
            var game = new ConsoleBetGameViewModel().Game;
            var bet = new ConsoleBetGameViewModel().Bet;
            var group = new ConsoleBetGameViewModel().Group;
            console.Game = _context.Games.Find(game);
            console.Bet = _context.Bets.Find(bet);
            console.Group = _context.Groups.Find(group);

            return View(console);
        }
        public ActionResult New()
        {
            var groupView = new ConsoleBetGameViewModel();
            return View(groupView);
        }
        [HttpPost]
        public ActionResult Create(GroupImpl gGroup)
        {
            _context.Groups.Add(gGroup);
            _context.SaveChanges();
            return RedirectToAction("Index", "Group");
        }


        public ActionResult Edit(GroupImpl gGroup)
        {
            _context.Groups.Add(gGroup);
            _context.SaveChanges();
            return RedirectToAction("Index", "Group");
        }
    }
}