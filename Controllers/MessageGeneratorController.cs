using System.Security.Cryptography.X509Certificates;
using System.Web.Mvc;
using Bet.Models;
using Bet.Models.ViewModels;

namespace Bet.Controllers
{
    public class MessageGeneratorController : Controller
    {
        // GET
        private ApplicationDbContext _context;
        public MessageGeneratorController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var messageGeneratorViewModel = new MessageGeneratorViewModels();
            return View("Message",messageGeneratorViewModel);
        }

        public ActionResult Message()
        {
            var messageGeneratorView = new MessageGeneratorViewModels();
           
            return View("Message", messageGeneratorView);
        }

    }
}