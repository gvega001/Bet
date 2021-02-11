using System.Web.Mvc;
using Bet.Models.ViewModels;

namespace Bet.Controllers
{
    public class ConsoleBetGameController : Controller
    {
        // GET
        public ViewResult Index()
        {
            var console = new ConsoleBetGameViewModel();
            return View(console);
        }
    }
}