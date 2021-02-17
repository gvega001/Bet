using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Mvc;
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

        // GET /api/bets
        public IEnumerable<BetDto> GetBets()
        {

            return _context.Bets.ToList().Select(Mapper.Map<BetImpl,BetDto>);
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
        [System.Web.Mvc.HttpPost]
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
        [System.Web.Http.HttpPut]
        public void UpdateBet(int id, BetDto betDto)
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