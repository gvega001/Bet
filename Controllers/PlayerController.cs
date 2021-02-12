using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Bet.Models;
using Bet.Models.ViewModels;

namespace Bet.Controllers
{
    public class PlayerController : Controller
    {

        // GET Player/
        private ApplicationDbContext _context;
        public PlayerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {

            var player = _context.Players.SingleOrDefault();
           
            return View(player);
        }

        public ViewResult Details(int id)
        {
            var playerViewModel = new PlayerViewModels();
            playerViewModel.Player = _context.Players.SingleOrDefault(p => p.Id == id); 
            return View(playerViewModel);

        }
        public ActionResult New()
        {
            var playerView = new NewPlayerViewModels();
            return View(playerView.Player);
        }
        [HttpPost]
        public ActionResult Create(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
            return RedirectToAction("Index", "Player");
        }

    
        public ActionResult Edit(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();

            return RedirectToAction("Index", "Player");
        }
    
    }
}