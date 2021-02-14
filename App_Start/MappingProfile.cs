using AutoMapper;
using Bet.Models;
using System;
using Bet.DTO;

namespace Bet
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
           
            Mapper.CreateMap<BetImpl,BetDto>();
            Mapper.CreateMap<BetDto, BetImpl>();
            Mapper.CreateMap<GameImpl, GameDto>();
            Mapper.CreateMap<GameDto, GameImpl>();
        }

    }
}