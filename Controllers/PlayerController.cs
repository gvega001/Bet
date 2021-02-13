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
            var viewModel = new PlayerFormViewModel
            {
                
            };
            return View("PlayerForm", viewModel.Player);
        }
        [HttpPost]
        public ActionResult Save(Player player)
        {
            if (player.PlayerId == 0)
            {
                _context.Players.Add(player);
            }
            else
            {
                var playerInDb = _context.Players.SingleOrDefault(p => p.Id == player.Id);
                playerInDb.Bets = player.Bets;
                playerInDb.DateOfBirth = player.DateOfBirth;
                playerInDb.FirstName = player.FirstName;
                playerInDb.LastName = player.LastName;
                playerInDb.MembershipType = MembershipTypes.Enabled;
                playerInDb.MembershipId = player.MembershipId;
                playerInDb.IsSubscribed = player.IsSubscribed;

            }
           
            _context.SaveChanges();
            return RedirectToAction("Index", "Player");
        }
        public ActionResult Details(int id)
        {
            PlayerViewModels playerViewModel = new PlayerViewModels();
            var player= _context.Players.SingleOrDefault(p => p.PlayerId == id);
            if (player == null)
            {
                return HttpNotFound();
            }
            playerViewModel.Player = player;
            return View(player);

        }
        public ActionResult Edit(int id)
        {
            var player = _context.Players.Include(p => p.MembershipType).SingleOrDefault(p => p.PlayerId == id);

            if (player == null)
            {
                return HttpNotFound();
            }
            var playerViewModel = new PlayerFormViewModel
            {
                Player = player
            };

            return RedirectToAction("PlayerForm", player);
        }
    }
}