using AutoMapper;
using Bet.Models;
using Bet.Models.DTO;
using System;

namespace Bet
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
           
            Mapper.CreateMap<BetImpl,BetDto>();
            Mapper.CreateMap<BetDto, BetImpl>();
        }

    }
}