using Hako.Application.Models;

namespace Hako.Application.Repositories;
public interface IGameRepository
{
    /// <summary>
    /// Create a game and add it to the repository.
    /// </summary>
    /// <param name="game">Game object.</param>
    /// <returns>
    /// Returns a bool showing if the game could be added.
    /// </returns>
    Task<bool> CreateAsync(Game game);

    /// <summary>
    /// Gets a game by its id.
    /// </summary>
    /// <param name="id">Id of the game.</param>
    /// <returns>Returns the game object or null, if the game could not be found.</returns>
    Task<Game?> GetByIdAsync(Guid id);
    /// <summary>
    /// Gets all games from the repository.
    /// </summary>
    /// <returns>Return an IEnumerable of games.</returns>
    Task<IEnumerable<Game>> GetAllAsync();
    /// <summary>
    /// Updates an game object.
    /// </summary>
    /// <param name="game">Game object.</param>
    /// <returns>Returns a bool showing if the game could be updated.</returns>
    Task<bool> UpdateAsync(Game game);
    /// <summary>
    /// Deletes a game from the repository.
    /// </summary>
    /// <param name="id">Id of the game.</param>
    /// <returns>Return a bool, showing if the game could be deleted.</returns>
    Task<bool> DeleteAsync(Guid id);
}
