using AutoMapper;
using CoreRPG.DTOs.Character;
using CoreRPG.Models;

namespace CoreRPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}