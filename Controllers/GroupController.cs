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
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
           
            return View();
        }

        public ActionResult Save()
        {
            var group = new GroupDto();
          
            return View("GroupForm",group);
        }

        public ActionResult Details(int id)
        {
            var groups = _context.Groups.SingleOrDefault(g => g.Id == id);
            if (groups ==null)
            {
                return HttpNotFound("No groups returned");
            }
            var groupDtos= _context.Groups.Select(Mapper.Map<GroupImpl,GroupDto>).SingleOrDefault(g => g.Id == id);
            return View(groupDtos);
        }
        public ActionResult Save(int id)
        {
            var group = new GroupDto();

            return View("GroupForm", group);
        }


    }
}