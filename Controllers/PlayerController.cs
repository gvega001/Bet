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
            return View(playerViewModel);
        }

    }
}