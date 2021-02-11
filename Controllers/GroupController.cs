using System.Web.Mvc;
using Bet.Models;
using Bet.Models.ViewModels;

namespace Bet.Controllers
{
    public class GroupController : Controller
    {
        // GET private ApplicationDbContext _context;
        private ApplicationDbContext _context;
        public GroupController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var groupViewModel = new GroupViewModels();
            var bets = _context.Bets.Find(groupViewModel.Bets);
            var player = _context.Players.Find(groupViewModel.Players);
            var game = _context.Games.FindAsync(groupViewModel);
            return View(groupViewModel);
        }

        public ActionResult Details()
        {
            var groupViewModel = new GroupViewModels();
            var bets = _context.Bets.Find(groupViewModel.Bets);
            var player = _context.Players.Find(groupViewModel.Players);
            var game = _context.Games.FindAsync(groupViewModel);
            return View(groupViewModel);
        }
        public ActionResult New()
        {

            return View();
        }
    }
}