using System.Web.Http;
using System.Web.Mvc;

namespace Bet.Controllers.Api
{
    public class GamesController : ApiController
    {
        // GET
        public ActionResult Index()
        {
            return View();
        }
    }
}