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
    public class GamesController : ApiController
    {
        private ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/games
        public IEnumerable<GameDto> GetGames()
        {
            return _context.Games.ToList().Select(Mapper.Map<GameImpl, GameDto>);
        }
        
        //GET /api/games/1
        public GameDto GetGame(int id)
        {
            var game = _context.Games.SingleOrDefault(g => g.Id == id);

            if (game == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return Mapper.Map<GameImpl, GameDto>(game);
        }

        //POST /api/games
        [System.Web.Mvc.HttpPost]
        public GameDto CreateGame(GameDto gameDto)
        {
            if (Equals(!ModelState.IsValid))
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var game = Mapper.Map<GameDto, GameImpl>(gameDto);
            _context.Games.Add(game);
            _context.SaveChanges();

            gameDto.Id = game.Id;
            return gameDto;
        }

        //PUT /api/games/1
        [System.Web.Http.HttpPut]
        public void UpdateGame(int id, GameDto gameDto)
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

            _context.SaveChanges();
        }

        //DELETE /api/games/1
        [System.Web.Http.HttpDelete]
        public void DeleteGame(int id)
        {
            var gameInDb = _context.Games.SingleOrDefault(g => g.Id == id);
            if (gameInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Games.Remove(gameInDb);
            _context.SaveChanges();

        }
    }
}