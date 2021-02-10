using System.Collections.Generic;
using System.Web.Mvc;
using Bet.Models;
using Bet.Models.ViewModels;

namespace Bet.Controllers
{
    public class PlayerController : Controller
    {
        // GET Player/
        public ActionResult Index()
        {
            var playerViewModel = new PlayerViewModels();
            Player player = new Player();
            playerViewModel.Player = player;
            return View(playerViewModel);
        }

    }
}