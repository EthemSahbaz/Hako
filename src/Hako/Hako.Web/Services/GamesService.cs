using Hako.Contracts.Responses;

namespace Hako.Web.Services;

public class GamesService
{
    private readonly HttpClient _httpClient;

    public GamesService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<GamesResponse?> GetGames()
    {
        var result = await _httpClient.GetFromJsonAsync<GamesResponse>("/api/games");

        return result;
    }
}
