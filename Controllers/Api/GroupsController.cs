using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.ModelBinding;
using AutoMapper;
using Bet.DTO;
using Bet.Models;

namespace Bet.Controllers.Api
{
    public class GroupsController : ApiController
    {
        private ApplicationDbContext _context;

        public GroupsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/groups
        public IEnumerable<GroupDto> GetGroups()
        {
            return _context.Groups.ToList().Select(Mapper.Map<GroupImpl, GroupDto>);
        }

        //GET /api/games/1
        public IHttpActionResult GetGroup(int id)
        {
            var group = _context.Groups.SingleOrDefault(g => g.Id == id);

            if (group == null)
            {
                return BadRequest();
            }

            return Ok(Mapper.Map<GroupImpl, GroupDto>(group));
        }

        //POST api/games
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult CreateGroup(GroupDto groupDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var group = Mapper.Map<GroupDto, GroupImpl>(groupDto);
            _context.Groups.Add(group);
            _context.SaveChanges();

            groupDto.Id = group.Id;
            return Created(new Uri(Request.RequestUri+ "/"+ group.Id), groupDto);
        }
       
        //PUT /api/groups/1
        [System.Web.Http.HttpPut]
        public void UpdateGroup(int id, GroupDto groupDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var groupInDb = _context.Groups.SingleOrDefault(g => g.Id == id);
            if (groupDto == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map(groupDto, groupDto);

            _context.SaveChanges();
        }

        //DELETE /api/groups/1
        [System.Web.Http.HttpDelete]
        public void DeleteGroup(int id)
        {
            var groupInDb = _context.Groups.SingleOrDefault(g => g.Id == id);
            if (groupInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Groups.Remove(groupInDb);
            _context.SaveChanges();
        }
    }
}