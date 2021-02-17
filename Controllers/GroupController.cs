using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using Bet.DTO;
using Bet.Models;
using Bet.Models.ViewModels;

namespace Bet.Controllers
{
    public class GroupController : Controller
    {
        // GET private ApplicationDbContext _context;
        private ApplicationDbContext _context;
        public GroupController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult New()
        {
            var group = new GroupDto();
          
            return View("GroupForm",group);
        }
       
      
    }
}