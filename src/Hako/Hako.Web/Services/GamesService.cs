using Hako.Contracts.Responses;

namespace Hako.Web.Services;

public class GamesService
{
    private readonly HttpClient _httpClient;

    public GamesService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<GameResponse>> GetGames()
    {
        var result = await _httpClient.GetFromJsonAsync<IEnumerable<GameResponse>>("/api/games");


        return result;
    }
}
