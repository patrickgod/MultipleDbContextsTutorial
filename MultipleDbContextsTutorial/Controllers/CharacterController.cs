using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultipleDbContextsTutorial.Data;
using MultipleDbContextsTutorial.Models;

namespace MultipleDbContextsTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly UserDbContext _userDbContext;
        private readonly CharacterDbContext _characterDbContext;

        public CharacterController(UserDbContext userDbContext, CharacterDbContext characterDbContext)
        {
            _userDbContext = userDbContext;
            _characterDbContext = characterDbContext;
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<UserResponseDto>> GetCharacters(int userId)
        {
            var user = await _userDbContext.Users.FirstAsync(u => u.Id == userId);
            var characters = await _characterDbContext.Characters.Where(c => c.UserId == user.Id).ToListAsync();

            var result = new UserResponseDto(user.Id, user.Name, characters);

            return Ok(result);
        }
    }
}
