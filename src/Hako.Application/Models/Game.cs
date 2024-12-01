namespace Hako.Application.Models;
/// <summary>
/// Representation of a game object.
/// </summary>
public sealed class Game
{
    /// <summary>
    /// Id of the game.
    /// </summary>
    public required Guid Id { get; init; }
    /// <summary>
    /// Title of the game.
    /// </summary>
    public required string Title { get; set; }
    /// <summary>
    /// The games year of release.
    /// </summary>
    public required int YearOfRelease { get; set; }
    /// <summary>
    /// Publisher of the game.
    /// </summary>
    public required string Publisher { get; set; }
    /// <summary>
    /// The games genres.
    /// </summary>
    public List<string> Genres { get; init; } = new();
}
