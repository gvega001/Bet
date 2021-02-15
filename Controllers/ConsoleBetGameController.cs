using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Bet.DTO;
using Bet.Models;
using Bet.Models.ViewModels;

namespace Bet.Controllers
{
    public class ConsoleBetGameController : Controller
    {
        // GET
        private ApplicationDbContext _context;
        public ConsoleBetGameController()
        {
            _context = new ApplicationDbContext();
        }

      
        public ActionResult Index()
        {
            var console =_context.Games.ToList().Select(Mapper.Map<GameImpl, GameDto>);

            return View(console);
        }
        public ActionResult New()
        {
            var game = new GameDto();
            return View("GameForm",game);
        }
       
      
    }
}