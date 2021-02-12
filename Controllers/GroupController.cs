using System.Linq;
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
            groupViewModel.Player = _context.Players.SingleOrDefault();
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
            var groupView = new GroupViewModels();
            return View(groupView.Group);
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