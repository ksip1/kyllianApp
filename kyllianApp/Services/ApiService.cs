using System.Net.Http.Json;
using kyllianApp.Models;

namespace kyllianApp.Services;

public class ApiService
{
    private readonly HttpClient _httpClient = new();

    public async Task<List<Character>> GetCharactersAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<CharacterResponse>("https://rickandmortyapi.com/api/character");
        return response?.Results ?? new List<Character>();
    }

    private class CharacterResponse
    {
        public List<Character> Results { get; set; }
    }
}
