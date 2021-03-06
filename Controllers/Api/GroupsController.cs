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
    public class GroupsController : ApiController
    {
        private ApplicationDbContext _context;

        public GroupsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/groups

        public IHttpActionResult GetGroups()
        {
           var groupDtos = _context.Groups.ToList().Select(Mapper.Map<GroupImpl, GroupDto>);

           
            return Ok (groupDtos) ; 
        }

        //GET /api/groups/1
        public IHttpActionResult GetGroup(int id)
        {
            var group = _context.Groups.SingleOrDefault(g => g.Id == id);

            if (group == null)
            {
                return BadRequest();
            }

            return Ok(Mapper.Map<GroupImpl, GroupDto>(group));
        }

        //POST api/groups
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
        [System.Web.Mvc.HttpPost]

        public IHttpActionResult UpdateGroup(int id, GroupDto groupDto)
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

            return Ok(_context.SaveChanges());

        }

        //DELETE /api/groups/1
        [System.Web.Mvc.HttpPost]

        public IHttpActionResult DeleteGroup(int id)
        {
            var groupInDb = _context.Groups.SingleOrDefault(g => g.Id == id);
            if (groupInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Groups.Remove(groupInDb);
            return Ok(_context.SaveChanges());

        }
    }
}