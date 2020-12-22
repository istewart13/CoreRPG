using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoreRPG.DTOs.Character;
using CoreRPG.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreRPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCharacter(AddCharacterDto character)
        {
            return Ok(await _characterService.AddCharacter(character));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
            GetCharacterDto response = null;
            try {
                response = await _characterService.UpdateCharacter(updatedCharacter);
            } catch (Exception ex) {
                return NotFound(ex.Message);
            }

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            List<GetCharacterDto> response = null;
            try {
                response = await _characterService.DeleteCharacter(id);
            } catch (Exception ex) {
                return NotFound(ex.Message);
            }

            return Ok(response);
        }
    }
}