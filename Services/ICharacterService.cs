using System.Collections.Generic;
using System.Threading.Tasks;
using CoreRPG.DTOs.Character;
using CoreRPG.Models;

namespace CoreRPG.Services
{
    public interface ICharacterService
    {
         Task<List<GetCharacterDto>> GetAllCharacters();

         Task<GetCharacterDto> GetCharacterById(int id);

         Task<List<GetCharacterDto>> AddCharacter(AddCharacterDto newCharacter);

         Task<GetCharacterDto> UpdateCharacter(UpdateCharacterDto updatedCharacter);
    }
}