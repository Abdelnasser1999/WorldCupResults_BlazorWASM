using WorldCupResult_BlazorWASM.Models;

namespace WorldCupResult_BlazorWASM.Services
{
    public interface IStatsService
    {
        Task<StatsRespons> GetStats();
        Task<MatchesResponse> GetAllMatches();
    }
}
