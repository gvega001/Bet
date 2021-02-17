using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;
using Bet.DTO;
using Bet.Migrations;
using Bet.Models;
using Bet.Models.ViewModels;

namespace Bet.Controllers
{
    public class PlayerController : Controller
    {

        // GET Player/
        private ApplicationDbContext _context;
        public PlayerController()
        {
            _context = new ApplicationDbContext();
        }

        public ViewResult Index()
        {

            return View();
        }

        public ActionResult New()
        {
            var viewModel = new PlayerDto();
            return View("PlayerForm", viewModel);
        }
       
    }
}