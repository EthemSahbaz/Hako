using Hako.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Hako.ApiService.Controllers;

[ApiController]
[Route("api")]
public class GamesController : ControllerBase
{
    private readonly IGameRepository _gameRepository;

    public GamesController(IGameRepository gameRepository)
    {
        _gameRepository = gameRepository;
    }

    [HttpGet("games")]
    public async Task<IActionResult> Get()
    {
        var games = await _gameRepository.GetAllAsync();

        return Ok(games);
    }
}
