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

        public ViewResult Index(string id)
        {

            var player = _context.Players.SingleOrDefault(p => p.Id == id);
           
            return View(player);
        }

        public ViewResult Details(string id)
        {
            var playerViewModel = new PlayerViewModels();
            playerViewModel.Player = _context.Players.SingleOrDefault(p => p.Id == id); 
            return View(playerViewModel);

        }

        public ActionResult Edit(string id)
        {
            var player = _context.Players.SingleOrDefault(p => p.Id == id);

            return View(player);
        }
        public ActionResult Create()
        {
            
            var viewModel = new NewPlayerViewModels();


            return View(viewModel);
        }

    }
}