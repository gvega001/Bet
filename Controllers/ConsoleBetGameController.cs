using System.Web.Mvc;

namespace Bet.Controllers
{
    public class ConsoleBetGameController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
    }
}