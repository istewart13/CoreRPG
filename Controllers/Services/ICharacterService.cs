using System.Collections.Generic;
using System.Threading.Tasks;
using CoreRPG.Controllers.DTOs.Character;
using CoreRPG.Models;

namespace CoreRPG.Controllers.Services
{
    public interface ICharacterService
    {
         Task<List<GetCharacterDto>> GetAllCharacters();

         Task<GetCharacterDto> GetCharacterById(int id);

         Task<List<GetCharacterDto>> AddCharacter(AddCharacterDto newCharacter);
    }
}