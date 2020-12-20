using System.Collections.Generic;
using System.Linq;
using CoreRPG.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreRPG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character> {
            new Character { Id = 1, Name = "Aeris" },
            new Character { Id = 2, Name = "Barrett" },
            new Character { Id = 3, Name = "Cloud" }
        };

        [HttpGet("GetAll")]
        public IActionResult Get() {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id) {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public IActionResult AddCharacter(Character character) {
            characters.Add(character);
            return Ok(characters);
        }
    }
}