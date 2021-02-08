using System.Web.Mvc;
using Bet.Models;

namespace Bet.Controllers
{
    public class PlayerController : Controller
    {
        // GET Player/
        public ActionResult Index()
        {
            return View();
        }
    }
}