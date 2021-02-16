using System.Linq;
using System.Web.Mvc;
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
        public ActionResult Index()
        {
            var groupViewModel = new GroupViewModels();
            return View(groupViewModel);
        }

        public ActionResult New()
        {
            var group = new GroupImpl();
          
            return View("GroupForm",group);
        }
        [HttpPost]
        public ActionResult Save(GroupImpl gGroup)
        {
            if (gGroup.Id == 0)
            {
                _context.Groups.Add(gGroup);
            }
            
            _context.SaveChanges();
            return RedirectToAction("Index", "Group");
        }
        public ActionResult Details(int id)
        {
            var group = _context.Groups.SingleOrDefault(g => g.Id == id);
            var groupViewModel = new GroupViewModels();
            groupViewModel.GroupImpl = group;
            return View(groupViewModel);
        }

        public ActionResult Edit(int id)
        {
            var group = _context.Groups.SingleOrDefault(g => g.Id == id);
            if (group == null)
            {
                return HttpNotFound();
            }
            _context.Groups.Add(group);
            _context.SaveChanges();
            return RedirectToAction("Index", "Group");
        }

      
    }
}