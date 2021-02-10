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
            playerViewModel.FirstName = "Gabriel";
            playerViewModel.LastName = "Vega";
            Player player = new Player();
            playerViewModel._player = player;
            return View(playerViewModel);
        }

    }
}