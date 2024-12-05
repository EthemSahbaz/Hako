using Hako.Application.Models;
using Hako.Contracts.Requests;
using Hako.Contracts.Responses;

namespace Hako.ApiService.Mapping;
/// <summary>
/// Class for central and easier mapping of contract.
/// </summary>
public static class ContractMapping
{
    /// <summary>
    /// Mapping from game to gameresponse.
    /// </summary>
    /// <param name="game">Game that should be mapped to response.</param>
    /// <returns>Returns a GameResponse.</returns>
    public static GameResponse MapToResponse(this Game game)
    {
        return new GameResponse()
        {
            Id = game.Id,
            Title = game.Title,
            Genres = game.Genres,
            YearOfRelease = game.YearOfRelease,
            Publisher = game.Publisher
        };
    }

    /// <summary>
    /// Maps a create request to a game domain model.
    /// </summary>
    /// <param name="createRequest">Create request model.</param>
    /// <returns>Return a new game instance, mapped from a request.</returns>
    public static Game MapToGame(this CreateGameRequest createRequest)
    {
        return new Game()
        {
            Id = Guid.NewGuid(),
            Title = createRequest.Title,
            YearOfRelease = createRequest.YearOfRelease,
            Genres = createRequest.Genres.ToList(),
            Publisher = createRequest.Publisher,
        };
    }

    /// <summary>
    /// Maps a update request to a game domain model.
    /// </summary>
    /// <param name="updateRequest">Update request model.</param>
    /// <returns>Return a new game instance, mapped from a request.</returns>
    public static Game MapToGame(this UpdateGameRequest updateRequest, Guid id)
    {
        return new Game()
        {
            Id = id,
            Title = updateRequest.Title,
            YearOfRelease = updateRequest.YearOfRelease,
            Genres = updateRequest.Genres.ToList(),
            Publisher = updateRequest.Publisher,
        };
    }

    /// <summary>
    /// Maps a Collection of games to a gamesresponse object.
    /// </summary>
    /// <param name="games">Collection of game domain models</param>
    /// <returns>Return a reponse of games.</returns>
    public static GamesResponse MapToResponses(this IEnumerable<Game> games)
    {
        return new GamesResponse()
        {
            Items = games.Select(MapToResponse)
        };
    }
}
