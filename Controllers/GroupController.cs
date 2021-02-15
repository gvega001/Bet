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
            var console = _context.Groups.ToList().Select(Mapper.Map<GroupImpl, GroupDto>);
            return View(console);
        }

        public ActionResult New()
        {
            var group = new GroupDto();
          
            return View("GroupForm",group);
        }
       
      
    }
}