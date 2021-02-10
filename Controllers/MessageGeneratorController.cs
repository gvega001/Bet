using System.Security.Cryptography.X509Certificates;
using System.Web.Mvc;
using Bet.Models.ViewModels;

namespace Bet.Controllers
{
    public class MessageGeneratorController : Controller
    {
        // GET
        public ActionResult Index()
        {
            var messageGeneratorViewModel = new MessageGeneratorViewModels();
            return View(messageGeneratorViewModel);
        }
    }
}