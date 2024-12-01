namespace Hako.Contracts.Responses;
public sealed class GamesResponse
{
    public required IEnumerable<GameResponse> Items { get; init; } = Enumerable.Empty<GameResponse>();
}
