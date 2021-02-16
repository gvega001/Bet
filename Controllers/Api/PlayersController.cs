
using System;
using System.Linq;
using System.Net;
using System.Web.Http;
using AutoMapper;
using Bet.DTO;
using Bet.Models;
using Bet.Models.ViewModels;

namespace Bet.Controllers.Api
{
    public class PlayersController : ApiController
    {
        private ApplicationDbContext _context;

        public PlayersController()
        {
            _context = new ApplicationDbContext();
        }
        //GET /api/players/1
        //GET /api/bets/1
        public IHttpActionResult GetPlayer(int id)
        {
            var player = _context.PlayerViewModels.SingleOrDefault(p => p.Id == id);

            if (player == null)
            {
                return BadRequest();
            }

            return Ok(Mapper.Map<PlayerViewModels, PlayerDto>(player));
        }

        //POST /api/players
        [HttpPost]
        public IHttpActionResult CreatePlayer(PlayerDto playerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var player = Mapper.Map<PlayerDto, PlayerViewModels>(playerDto);
            _context.PlayerViewModels.Add(player);
            _context.SaveChanges();

            playerDto.Id = player.Id;
            return Created(new Uri(Request.RequestUri + "/" + player.Id), playerDto);
        }

        // PUT /api/players/1
        [HttpPut]
        public IHttpActionResult UpdatePlayer(int id, PlayerDto playerDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var playerInDb = _context.PlayerViewModels.SingleOrDefault(p => p.Id == id);
            if (playerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map(playerDto, playerInDb);

           return Ok(_context.SaveChanges()) ;
        }

        // DELETE /api/players/1
        [HttpDelete]
        public IHttpActionResult DeletePlayers(int id)
        {
            var playersInDb = _context.PlayerViewModels.SingleOrDefault(p => p.Id == id);
            if (playersInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.PlayerViewModels.Remove(playersInDb);
            return Ok(_context.SaveChanges());
        }

    }
}