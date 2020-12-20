using System.Collections.Generic;
using CoreRPG.Models;

namespace CoreRPG.Controllers.Services
{
    public interface ICharacterService
    {
         List<Character> GetAllCharacters();

         Character GetCharacterById(int id);

         List<Character> AddCharacter(Character newCharacter);
    }
}