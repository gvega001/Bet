using System.Web.Http;
using System.Web.Mvc;
using Bet.Models;

namespace Bet.Controllers.Api
{
    public class GamesController : ApiController
    {
        private ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/games
        public ActionResult Index()
        {
            return View();
        }
    }
}