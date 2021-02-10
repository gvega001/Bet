using System.Collections.Generic;
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

        public ActionResult Index(string id)
        {
            var playerViewModel = new PlayerViewModels();
            playerViewModel.Player = _context.Players.SingleOrDefault(p => p.Id == id);
            if (playerViewModel.Player == null)
                return HttpNotFound();
            return View(playerViewModel);
        }

        public ActionResult Details(string id)
        {
            var playerViewModel = new PlayerViewModels();
            playerViewModel.Player = _context.Players.SingleOrDefault(p => p.Id == id);
            var getDetails = playerViewModel.GetDetails();
            playerViewModel.Details = getDetails;
            if (playerViewModel.Player == null || playerViewModel.Details == null)
                return HttpNotFound();
            return View(playerViewModel);

        }

      

    }
}