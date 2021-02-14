using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Routing;
using AutoMapper;
using Bet.Models;
using Bet.Models.DTO;

namespace Bet.Controllers.Api
{
    public class BetsController : ApiController
    {
        private ApplicationDbContext _context;

        public BetsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET /api/bets
        public IEnumerable<BetDTO> GetBets()
        {
            return _context.Bets.ToList().Select(Mapper.Map<BetImpl,BetDTO>);
        }

        //GET /api/bets/1
        public BetDTO GetBet(int id)
        {
            var bet = _context.Bets.SingleOrDefault(b => b.Id == id);

            if(bet == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return Mapper.Map<BetImpl,BetDTO>(bet);
        }

        //POST /api/bets
        [System.Web.Mvc.HttpPost]
        public BetDTO CreateBet(BetDTO betDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            }

            var bet = Mapper.Map<BetDTO, BetImpl>(betDto);
            _context.Bets.Add(bet);
            _context.SaveChanges();

            betDto.PlayerId = bet.PlayerId;

            return betDto;
        }

        // PUT /api/bets/1
        [System.Web.Http.HttpPut]
        public void UpdateBet(int id, BetDTO betDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var betInDb = _context.Bets.SingleOrDefault(c => c.Id == id);
            if (betInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map(betDto, betInDb);
           
            _context.SaveChanges();
        }

        // DELETE /api/bets/1
        [System.Web.Http.HttpDelete]
        public void DeleteBet(int id)
        {
            var betInDb = _context.Bets.SingleOrDefault(c => c.Id == id);
            if (betInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Bets.Remove(betInDb);
            _context.SaveChanges();
        }

    }
}