using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CoreRPG.Data;
using CoreRPG.DTOs.Character;
using CoreRPG.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreRPG.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public CharacterService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<List<GetCharacterDto>> GetAllCharacters()
        {
            List<Character> dbCharacters = await _context.Characters.ToListAsync();
            return dbCharacters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
        }

        public async Task<GetCharacterDto> GetCharacterById(int id)
        {
            Character dbCharacter = await _context.Characters.FirstOrDefaultAsync(c => c.Id == id);
            return _mapper.Map<GetCharacterDto>(dbCharacter);
        }

        public async Task<List<GetCharacterDto>> AddCharacter(AddCharacterDto newCharacter)
        {
            var character = _mapper.Map<Character>(newCharacter);
            await _context.Characters.AddAsync(character);
            await _context.SaveChangesAsync();
            return _context.Characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
        }

        public async Task<GetCharacterDto> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
            Character character = null;
            try {
                character = await _context.Characters.FirstOrDefaultAsync(c => c.Id == updatedCharacter.Id);
                character.Name = updatedCharacter.Name;
                character.Class = updatedCharacter.Class;
                character.Defence = updatedCharacter.Defence;
                character.HitPoints = updatedCharacter.HitPoints;
                character.Intelligence = updatedCharacter.Intelligence;
                character.Strength = updatedCharacter.Strength;

                _context.Characters.Update(character);
                await _context.SaveChangesAsync();
            } catch (Exception ex) {
                throw;
            }

            return _mapper.Map<GetCharacterDto>(character);
        }

        public async Task<List<GetCharacterDto>> DeleteCharacter(int id)
        {
            Character character = null;
            try {
                character = await _context.Characters.FirstAsync(c => c.Id == id);
                _context.Characters.Remove(character);
                await _context.SaveChangesAsync();
            } catch (Exception ex) {
                throw;
            }

            return _context.Characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
        }
    }
}