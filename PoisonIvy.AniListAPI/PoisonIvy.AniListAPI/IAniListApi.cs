using System.Collections.Generic;
using System.Threading.Tasks;
using PoisonIvy.AniListAPI.Models;
using PoisonIvy.AniListAPI.Types;

namespace PoisonIvy.AniListAPI
{
    public interface IAniListApi
    {
        Task<List<Series>> SearchSeries(string searchPhrase);
        Task<Series> GetSeries(long anilistAnimeid);
        Task<SeriesPage> GetSeriesPage(long anilistAnimeid);
        Task<Dictionary<long, SeriesPage>> GetListOfSeriesPages(IEnumerable<long> anilistSeriesIds);
        Task<Dictionary<string, long>> GetAnimeAiringTimes(long anilistAnimeId);
        Task<List<Character>> SearchCharacters(string searchPhrase);
        Task<Character> GetCharacter(long anilistCharacterId);
        Task<List<Staff>> SearchStaff(long anilistCharacterId);
        Task<Staff> GetStaff(long anilistCharacterId);
        Task<List<Actor>> SearchActor(long anilistCharacterId);
        Task<Actor> GetActor(long anilistCharacterId);
        Task<List<Studio>> SearchStudios(long anilistCharacterId);
        Task<Studio> GetStudio(long anilistCharacterId);
        Task<List<Series>> BrowseSeries(BrowseCriteria criteria);
        Task<Dictionary<MediaTypes, List<Series>>> BrowseSeasons(Seasons? season);
        Task<List<string>> GetGenreList();
    }
}