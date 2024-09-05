using GitCraft.Controllers;
using Microsoft.AspNetCore.Mvc;
using GitCraft.Controllers;

namespace GitCraft.Models;
[ApiController]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
    private readonly ILogger<CharacterController> _logger;
    private readonly GitCraftContext _context;

    public CharacterController(ILogger<CharacterController> logger, GitCraftContext context)
    {
        _logger = logger;
        _context = context;
    }
    // GET
    [HttpPost("createcharacter")]
    public async Task<IActionResult> CreateCharacter([FromBody] Character character)
    {
        if (character == null)
        {
            return BadRequest("fandme ikke lavet en bruger");
        }
        
        _context.Character.Add(character);
        await _context.SaveChangesAsync();
        
        return Ok("ja nu den fandme lavet");
    }

   

    
}