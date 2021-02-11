using System.Web.Mvc;
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

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var console = new ConsoleBetGameViewModel();
            return View(console);
        }
    }
}