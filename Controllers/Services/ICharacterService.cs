using System.Collections.Generic;
using System.Threading.Tasks;
using CoreRPG.Models;

namespace CoreRPG.Controllers.Services
{
    public interface ICharacterService
    {
         Task<List<Character>> GetAllCharacters();

         Task<Character> GetCharacterById(int id);

         Task<List<Character>> AddCharacter(Character newCharacter);
    }
}