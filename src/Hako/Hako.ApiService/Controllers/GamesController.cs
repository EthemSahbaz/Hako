using Hako.ApiService.Mapping;
using Hako.Application.Models;
using Hako.Application.Repositories;
using Hako.Contracts.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Hako.ApiService.Controllers;

[ApiController]
public class GamesController : ControllerBase
{
    private readonly IGameRepository _gameRepository;

    public GamesController(IGameRepository gameRepository)
    {
        _gameRepository = gameRepository;
    }


    [HttpPost(ApiEndpoints.Games.Create)]
    public async Task<IActionResult> Create([FromBody] CreateGameRequest createRequest)
    {

        var game = createRequest.MapToGame();

        await _gameRepository.CreateAsync(game);

        // Always only return response objects instead of domain model.
        var response = game.MapToResponse();

        return Created($"{ApiEndpoints.Games.Create}/{response.Id}", response);
    }

    [HttpGet(ApiEndpoints.Games.GetAll)]
    public async Task<IActionResult> GetAll()
    {
        var games = await _gameRepository.GetAllAsync();

        var response = games.MapToResponses();

        return Ok(response);
    }

    [HttpGet(ApiEndpoints.Games.Get)]
    public async Task<IActionResult> Get([FromRoute] Guid id)
    {
        var game = await _gameRepository.GetByIdAsync(id);

        if (game is null)
        {
            return NotFound();
        }

        var response = game.MapToResponse();

        return Ok(response);
    }

    [HttpPut(ApiEndpoints.Games.Update)]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateGameRequest updateRequest)
    {
        var game = updateRequest.MapToGame(id);

        var updated = await _gameRepository.UpdateAsync(game);

        if (!updated)
        {
            return NotFound();
        }

        var response = game.MapToResponse();

        return Ok(response);
    }

    [HttpDelete(ApiEndpoints.Games.Delete)]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        var deleted = await _gameRepository.DeleteAsync(id);

        if (!deleted)
        {
            return NotFound();
        }

        return Ok();

    }

}
