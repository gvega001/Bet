using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using AutoMapper;
using Bet.DTO;
using Bet.Models;

namespace Bet.Controllers.Api
{
    public class GamesController : ApiController
    {
        private ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/games
        public IHttpActionResult GetGames(int id)
        {
            var game = _context.Games.SingleOrDefault(g => g.Id==id);

            if (game == null)
            {
                return BadRequest();
            }

            return Ok(Mapper.Map<GameImpl, GameDto>(game)) ;
        }
        
        //GET /api/games/1
        public IHttpActionResult GetGame(int id)
        {
            var game = _context.Games.SingleOrDefault(g => g.Id == id);

            if (game == null)
            {
                return BadRequest();
            }

            return Ok(Mapper.Map<GameImpl, GameDto>(game));
        }

        //POST /api/games
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult CreateGame(GameDto gameDto)
        {
            if (Equals(!ModelState.IsValid))
            {
                return BadRequest();
            }

            var game = Mapper.Map<GameDto, GameImpl>(gameDto);
            _context.Games.Add(game);
            _context.SaveChanges();

            gameDto.Id = game.Id;
            return Created(new Uri(Request.RequestUri + "/" + game.Id),gameDto);
        }

        //PUT /api/games/1
        [HttpPut]
        public IHttpActionResult UpdateGame(int id, GameDto gameDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var gameInDb = _context.Games.SingleOrDefault(g => g.Id == id);
            if (gameInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map(gameDto, gameInDb);

            return Ok(_context.SaveChanges());

        }

        //DELETE /api/games/1
        [HttpDelete]
        public IHttpActionResult DeleteGame(int id)
        {
            var gameInDb = _context.Games.SingleOrDefault(g => g.Id == id);
            if (gameInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Games.Remove(gameInDb);
            return Ok(_context.SaveChanges());

        }
    }
}