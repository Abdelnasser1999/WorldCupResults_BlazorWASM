using System.Net.Http.Json;
using WorldCupResult_BlazorWASM.Models;

namespace WorldCupResult_BlazorWASM.Services
{
    public class StatsService : IStatsService
    {
        private readonly HttpClient _http;
        private readonly string _baseUrl = "https://api.football-data.org/v4";

        public StatsService(HttpClient http)
        {
            _http = http;
            _http.DefaultRequestHeaders.Add("X-Auth-Token", "920f081232ea4952ad3fec1127d44667");
        }

        public async Task<MatchesResponse> GetAllMatches()
        {
            return await _http.GetFromJsonAsync<MatchesResponse>($"{_baseUrl}/competitions/WC/matches");
        }

        public async Task<StatsRespons> GetStats()
        {
            return await _http.GetFromJsonAsync<StatsRespons>($"{_baseUrl}/competitions/WC/standings");
        }
    }
}