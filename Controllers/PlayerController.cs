using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Bet.Migrations;
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
            
            PlayerViewModels viewModels = new PlayerViewModels();
            return View(viewModels);
        }

        public ActionResult New()
        {
            
            var viewModel = new PlayerViewModels()
            {
                
            };
            return View("PlayerForm", viewModel);
        }
        [HttpPost]
        public ActionResult Save(PlayerViewModels player)
        {
            if (player.Id == 0)
            {

                _context.PlayerViewModels.Add(player);
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Player");
        }
        public ActionResult Details(int id)
        {
            var playerViewModel = new PlayerViewModels();
            var player= _context.PlayerViewModels.SingleOrDefault(p => p.Id == id);
            if (player == null)
            {
                return HttpNotFound();
            }
            
            return View(playerViewModel);

        }
        public ActionResult Edit(int id)
        {
            var playerViewModel = new PlayerViewModels();
            var player = _context.PlayerViewModels.SingleOrDefault(p => p.Id == id);

            if (player == null)
            {
                return HttpNotFound();
            }

            return RedirectToAction("PlayerForm", playerViewModel);
        }
    }
}