namespace Hako.Contracts.Responses;
public sealed class GameResponse
{
    public Guid Id { get; init; }
    public required string Title { get; init; }
    public required int YearOfRelease { get; init; }
    public required string Publisher { get; init; }
    public required IEnumerable<string> Genres { get; init; } = Enumerable.Empty<string>();
}
