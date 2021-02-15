using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
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

        public ViewResult Index(int id)
        {

            var player = _context.PlayerViewModels.SingleOrDefault(p => p.Id == id);
            return View(player);
        }

        public ActionResult New()
        {
            var viewModel = new PlayerViewModels();
            return View("PlayerForm", viewModel);
        }
       
    }
}