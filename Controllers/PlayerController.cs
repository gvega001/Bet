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
            
            PlayerViewModels viewModels = new PlayerViewModels();
            return View(viewModels);
        }

        public ActionResult New()
        {
            var playerView = new PlayerFormViewModel();
            return View("PlayerForm", playerView.Player);
        }
        [HttpPost]
        public ActionResult Save(Player player)
        {
            if (player.Id == 0)
            {
                _context.Players.Add(player);
            }
            else
            {
                var playerInDb = _context.Players.Single(p => p.Id == player.Id);

                playerInDb.FirstName = player.FirstName;
                playerInDb.LastName = player.LastName;
                playerInDb.MembershipId = player.MembershipId;
                playerInDb.Bets = player.Bets;
                playerInDb.IsSubscribed = player.IsSubscribed;
                playerInDb.DateOfBirth = player.DateOfBirth;
                playerInDb.Email = player.Email;
                playerInDb.PhoneNumber = player.PhoneNumber;
            }
           
            _context.SaveChanges();
            return RedirectToAction("Index", "Player");
        }
        public ActionResult Details(int id)
        {
            PlayerViewModels playerViewModel = new PlayerViewModels();
            var player= _context.Players.Include(p=>p.MembershipType).SingleOrDefault(p => p.Id == id);
            if (player == null)
            {
                return HttpNotFound();
            }
            playerViewModel.Player = player;
            return View(player);

        }
        public ActionResult Edit(int id)
        {
            var player = _context.Players.Include(p => p.MembershipType).SingleOrDefault(p => p.Id == id);

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