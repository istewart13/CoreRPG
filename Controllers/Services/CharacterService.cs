using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CoreRPG.Controllers.DTOs.Character;
using CoreRPG.Models;

namespace CoreRPG.Controllers.Services
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character> {
            new Character { Id = 1, Name = "Aeris" },
            new Character { Id = 2, Name = "Barrett" },
            new Character { Id = 3, Name = "Cloud" }
        };
        private readonly IMapper _mapper;

        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<List<GetCharacterDto>> GetAllCharacters()
        {
            return characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
        }

        public async Task<GetCharacterDto> GetCharacterById(int id)
        {
            return _mapper.Map<GetCharacterDto>(characters.FirstOrDefault(c => c.Id == id));
        }

        public async Task<List<GetCharacterDto>> AddCharacter(AddCharacterDto newCharacter)
        {
            characters.Add(_mapper.Map<Character>(newCharacter));
            return characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
        }
    }
}