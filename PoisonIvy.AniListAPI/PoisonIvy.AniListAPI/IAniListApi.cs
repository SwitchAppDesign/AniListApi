using System.Collections.Generic;
using System.Threading.Tasks;
using PoisonIvy.AniListAPI.Models;
using PoisonIvy.AniListAPI.Types;

namespace PoisonIvy.AniListAPI
{
    public interface IAniListApi
    {
        Task<List<Series>> SearchSeriesAsync(string searchPhrase);
        Task<Series> GetSeriesAsync(long anilistAnimeid);
        Task<SeriesPage> GetSeriesPageAsync(long anilistAnimeid);
        Task<Dictionary<long, SeriesPage>> GetListOfSeriesPagesAsync(IEnumerable<long> anilistSeriesIds);
        Task<Dictionary<string, long>> GetAnimeAiringTimesAsync(long anilistAnimeId);
        Task<List<Character>> SearchCharactersAsync(string searchPhrase);
        Task<Character> GetCharacterAsync(long anilistCharacterId);
        Task<List<Staff>> SearchStaffAsync(string searchPhrase);
        Task<Staff> GetStaffAsync(long anilistStaffId);
        Task<List<Actor>> SearchActorAsync(string searchPhrase);
        Task<Actor> GetActorAsync(long anilistActorId);
        Task<List<Studio>> SearchStudiosAsync(string searchPhrase);
        Task<Studio> GetStudioAsync(long anilistStudioId);
        Task<List<Series>> BrowseSeriesAsync(BrowseCriteria criteria);
        Task<Dictionary<MediaTypes, List<Series>>> BrowseSeasonsAsync(Seasons? season);
        Task<List<string>> GetGenreListAsync();
    }
}