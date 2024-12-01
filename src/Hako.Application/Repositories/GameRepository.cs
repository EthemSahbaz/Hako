using Hako.Application.Models;

namespace Hako.Application.Repositories;
internal sealed class GameRepository : IGameRepository
{
    private readonly List<Game> _games = new();
    public Task<bool> CreateAsync(Game game)
    {
        _games.Add(game);

        return Task.FromResult(true);
    }

    public Task<Game?> GetByIdAsync(Guid id)
    {
        var game = _games.SingleOrDefault(x=> x.Id == id);

        return Task.FromResult(game);
    }

    public Task<IEnumerable<Game>> GetAllAsync()
    {
        return Task.FromResult(_games.AsEnumerable());
    }

    public Task<bool> UpdateAsync(Game game)
    {
        var gameIndex = _games.FindIndex(x=> x.Id == game.Id);

        if (gameIndex == -1)
        {
            return Task.FromResult(false);
        }

        _games[gameIndex] = game;

        return Task.FromResult(true);
        
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        var removedCount = _games.RemoveAll(x=> x.Id == id);

        var gameRemoved = removedCount > 0;

        return Task.FromResult(gameRemoved);

    }
}
