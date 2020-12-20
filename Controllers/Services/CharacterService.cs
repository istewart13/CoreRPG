using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<List<Character>> GetAllCharacters()
        {
            return characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }

        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }
    }
}