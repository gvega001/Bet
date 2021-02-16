using AutoMapper;
using Bet.Models;
using System;
using Bet.DTO;
using Bet.Models.ViewModels;

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
            Mapper.CreateMap<GroupImpl, GroupDto>();
            Mapper.CreateMap<GroupDto, GroupImpl>();
            Mapper.CreateMap<PlayerViewModels, PlayerDto>();
            Mapper.CreateMap<PlayerDto, PlayerViewModels>();
        }

    }
}