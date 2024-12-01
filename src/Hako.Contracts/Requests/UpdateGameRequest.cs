namespace Hako.Contracts.Requests;
public sealed class UpdateGameRequest
{
    public required string Title { get; init; }
    public required int YearOfRelease { get; init; }
    public required string Publisher { get; init; }
    public IEnumerable<string> Genres { get; init; } = Enumerable.Empty<string>();
}
