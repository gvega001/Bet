using System;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;
using Bet.DTO;
using Bet.Models;

namespace Bet.Controllers.Api
{
    public class NewBetsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewBetsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult CreateNewBets(NewBetDto newBets)
        {
            var bet = _context.Bets.Single(
                b => b.Id == newBets.Bet.Id);
            var game = _context.Games.Single(
                g => g.Id == newBets.Game.Id);

            var group = _context.Groups.Single(
                g => g.Id == newBets.Group.Id);

            BetDto betDto = Mapper.Map<BetImpl, BetDto>(bet);
            GameDto gameDto = Mapper.Map<GameImpl, GameDto>(game);
            GroupDto groupDto = Mapper.Map<GroupImpl, GroupDto>(group);

            var newBet = new NewBet
            {
                
                Bet = betDto,
                Game = gameDto,
                Group =  groupDto

            };
            return Ok(_context.MakeBets.Add(newBet)) ;

        }
    }
}