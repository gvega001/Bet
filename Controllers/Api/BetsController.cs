using System;
using System.Linq;
using System.Net;
using System.Web.Http;
using AutoMapper;
using Bet.DTO;
using Bet.Models;

namespace Bet.Controllers.Api
{
    public class BetsController : ApiController
    {
        private ApplicationDbContext _context;

        public BetsController()
        {
            _context = new ApplicationDbContext();
        }
        // get player bets
        // GET /api/bets
        public IHttpActionResult GetBets(int id)
        {
            var bet = _context.Bets.SingleOrDefault(b => b.PlayerId == id);

            if (bet == null)
            {
                return BadRequest();
            }

            return Ok(Mapper.Map<BetImpl, BetDto>(bet)); 
        }

        //GET /api/bets/1
        public IHttpActionResult GetBet(int id)
        {
            var bet = _context.Bets.SingleOrDefault(b => b.Id == id);

            if(bet == null)
            {
                return BadRequest();
            }

            return Ok(Mapper.Map<BetImpl, BetDto>(bet));
        }

        //POST /api/bets
        [HttpPost]
        public IHttpActionResult CreateBet(BetDto betDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var bet = Mapper.Map<BetDto, BetImpl>(betDto);
            _context.Bets.Add(bet);
            _context.SaveChanges();
            
            betDto.Id = bet.Id;
            return Created(new Uri(Request.RequestUri + "/" + bet.Id), betDto);
        }

        // PUT /api/bets/1
        [HttpPut]
        public IHttpActionResult UpdateBet(int id, BetDto betDto)
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
           return Ok(_context.SaveChanges());
        }

        // DELETE /api/bets/1
        [HttpDelete]
        public IHttpActionResult DeleteBet(int id)
        {
            var betInDb = _context.Bets.SingleOrDefault(c => c.Id == id);
            if (betInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Bets.Remove(betInDb);
            return Ok(_context.SaveChanges());
        }

    }
}