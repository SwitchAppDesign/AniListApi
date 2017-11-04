using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using PoisonIvy.AniListAPI.DTO;
using PoisonIvy.AniListAPI.Extentions;
using PoisonIvy.AniListAPI.Helpers;
using PoisonIvy.AniListAPI.Models;
using PoisonIvy.AniListAPI.Types;

namespace PoisonIvy.AniListAPI
{
    public class AniListApi : IAniListApi
    {
        private readonly HttpClient _client;
        private Authentication _authTicket;

        private string _authGrantType;
        private string _authClientId;
        private string _authClientSecret;

        private static AniListApi _instance;

        private AniListApi()
        {
            _client = new HttpClient {BaseAddress = new Uri(AniListApiHelper.GetBaseUrl())};
        }

        public static AniListApi Instance => _instance ?? (_instance = new AniListApi());

        /// <summary>
        /// Use your anilist api credentials here
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="grantType"></param>
        /// <returns></returns>
        public async Task<bool> Login(string clientId, string clientSecret, string grantType = "client_credentials")
        {
            _authClientId = clientId;
            _authClientSecret = clientSecret;
            _authGrantType = grantType;

            return await LoginAsync();
        }

        /// <summary>
        /// Gets a list of series.
        /// </summary>
        /// <param name="searchPhrase">The search used to find series.</param>
        /// <returns>Returns a list of series.</returns>
        public async Task<List<Series>> SearchSeriesAsync(string searchPhrase)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.Anime, QueryType.Search, searchPhrase));

            try
            {
                var rawSeries = await GenericGetAsync<List<SeriesDTO>>(url);

                return rawSeries?.Select(Series.ConstructFromDto).ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        /// <summary>
        /// Gets a single series.
        /// </summary>
        /// <param name="anilistAnimeid">The AniList numeric based identifier.</param>
        /// <returns>Returns a single series.</returns>
        public async Task<Series> GetSeriesAsync(long anilistAnimeid)
        {
            var url = AniListApiHelper.GetUrl(AnilistTypes.Anime, QueryType.Single, anilistAnimeid);

            try
            {
                var rawAnime = await GenericGetAsync<SeriesDTO>(url);
                return rawAnime != null ? Series.ConstructFromDto(rawAnime) : null;
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve series. Error: {e}");
            }
        }

        /// <summary>
        /// Gets a single series page.
        /// </summary>
        /// <param name="anilistAnimeid">The AniList numeric based identifier.</param>
        /// <returns>Returns a single AniList series page.</returns>
        public async Task<SeriesPage> GetSeriesPageAsync(long anilistAnimeid)
        {
            var url = AniListApiHelper.GetUrl(AnilistTypes.Anime, QueryType.Page, anilistAnimeid);

            try
            {
                var rawAnime = await GenericGetAsync<SeriesPageDTO>(url);
                return rawAnime != null ? SeriesPage.ConstructFromDto(rawAnime) : null;
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve series. Error: {e}");
            }
        }

        /// <summary>
        /// Gets a dictionary of series pages.
        /// </summary>
        /// <param name="anilistSeriesIds">A list of AniList numeric based identifiers.</param>
        /// <returns>Returns a dictionary of series pages where the key is the numeric based AniList identifier.</returns>
        public async Task<Dictionary<long, SeriesPage>> GetListOfSeriesPagesAsync(IEnumerable<long> anilistSeriesIds)
        {
            var result = new Dictionary<long, SeriesPage>();
            var seriesIds = anilistSeriesIds.ToList();

            if (!seriesIds.Any())
            {
                return null;
            }

            foreach (var anilistAnimeid in seriesIds)
            {
                var url = AniListApiHelper.GetUrl(AnilistTypes.Anime, QueryType.Page, anilistAnimeid);

                try
                {
                    var rawAnime = await GenericGetAsync<SeriesPageDTO>(url);

                    if (rawAnime != null)
                    {
                        result.Add(rawAnime.id, SeriesPage.ConstructFromDto(rawAnime));
                    }
                }
                catch (Exception e)
                {
                    throw new Exception($"Failed to retrieve series. Error: {e}");
                }
            }

            return result;
        }

        /// <summary>
        /// Gets a dictionary of airing times.
        /// </summary>
        /// <param name="anilistAnimeId">The AniList numeric based identifier.</param>
        /// <returns>Returns a dictionary of airing times. The key is the episode number. The value is the UNIX timestamp.</returns>
        public async Task<Dictionary<string, long>> GetAnimeAiringTimesAsync(long anilistAnimeId)
        {
            var url = AniListApiHelper.GetUrl(AnilistTypes.Anime, QueryType.Airing, anilistAnimeId);

            try
            {
                return await GenericGetAsync<Dictionary<string, long>>(url);
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve next airing times. Error: {e}");
            }
        }
        
        /// <summary>
        /// Gets a list of characters.
        /// </summary>
        /// <param name="searchPhrase">The string search phrase to search on.</param>
        /// <returns>Returns a list of characters.</returns>
        public async Task<List<Character>> SearchCharactersAsync(string searchPhrase)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.Character, QueryType.Search, searchPhrase));

            try
            {
                var rawCharacters = await GenericGetAsync<List<CharacterDTO>>(url);

                return rawCharacters?.Select(Character.ConstructFromDto).ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        /// <summary>
        /// Gets a single character.
        /// </summary>
        /// <param name="anilistCharacterId">The AniList numeric based identifier.</param>
        /// <returns>Returns a single character.</returns>
        public async Task<Character> GetCharacterAsync(long anilistCharacterId)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.Character, QueryType.Single, anilistCharacterId));

            try
            {
                var rawCharacters = await GenericGetAsync<CharacterDTO>(url);

                return Character.ConstructFromDto(rawCharacters);
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        /// <summary>
        /// Gets a list of staff.
        /// </summary>
        /// <param name="searchPhrase">The search phrase to search on.</param>
        /// <returns>returns a list of staff.</returns>
        public async Task<List<Staff>> SearchStaffAsync(string searchPhrase)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.Staff, QueryType.Search, searchPhrase));

            try
            {
                var rawStaff = await GenericGetAsync<List<StaffDTO>>(url);

                return rawStaff?.Select(Staff.ConstructFromDto).ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        /// <summary>
        /// Gets a single staff member.
        /// </summary>
        /// <param name="anilistStaffId">The AniList numeric based identifier.</param>
        /// <returns>Returns a single staff member.</returns>
        public async Task<Staff> GetStaffAsync(long anilistStaffId)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.Staff, QueryType.Single, anilistStaffId));

            try
            {
                var rawStaff = await GenericGetAsync<StaffDTO>(url);

                return Staff.ConstructFromDto(rawStaff);
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        /// <summary>
        /// Gets a list of actors.
        /// </summary>
        /// <param name="searchPhrase">The search phrase to search on.</param>
        /// <returns>Returns a list of actors.</returns>
        public async Task<List<Actor>> SearchActorAsync(string searchPhrase)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.Actor, QueryType.Search, searchPhrase));

            try
            {
                var rawActors = await GenericGetAsync<List<ActorDTO>>(url);

                return rawActors?.Select(Actor.ConstructFromDto).ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        /// <summary>
        /// Gets a single actor.
        /// </summary>
        /// <param name="anilistActorId">The AniList numeric based identifier.</param>
        /// <returns>Returns a single actor.</returns>
        public async Task<Actor> GetActorAsync(long anilistActorId)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.Actor, QueryType.Single, anilistActorId));

            try
            {
                var rawActor = await GenericGetAsync<ActorDTO>(url);

                return Actor.ConstructFromDto(rawActor);
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        /// <summary>
        /// Gets a list of studios.
        /// </summary>
        /// <param name="searchPhrase">The search phrase to search on.</param>
        /// <returns>Returns a list of studios.</returns>
        public async Task<List<Studio>> SearchStudiosAsync(string searchPhrase)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.Studio, QueryType.Search, searchPhrase));

            try
            {
                var rawStudio = await GenericGetAsync<List<StudioDTO>>(url);

                return rawStudio?.Select(Studio.ConstructFromDto).ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        /// <summary>
        /// Gets a single studio.
        /// </summary>
        /// <param name="anilistStudioId">The AniList numeric based identifier.</param>
        /// <returns>Returns a single studio.</returns>
        public async Task<Studio> GetStudioAsync(long anilistStudioId)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.Studio, QueryType.Single, anilistStudioId));

            try
            {
                var rawStudio = await GenericGetAsync<StudioDTO>(url);

                return Studio.ConstructFromDto(rawStudio);
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        /// <summary>
        /// Get a list of series using more in depth search criteria.
        /// </summary>
        /// <param name="criteria">The criteria used to search on.</param>
        /// <returns>Returns a list of series.</returns>
        public async Task<List<Series>> BrowseSeriesAsync(BrowseCriteria criteria)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.BrowseAnime, null, criteria));

            try
            {
                var rawAnime = await GenericGetAsync<List<SeriesDTO>>(url);

                return rawAnime?.Select(Series.ConstructFromDto).ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        /// <summary>
        /// Gets a dictionary of series for the specified season grouped by media type.
        /// </summary>
        /// <param name="season">Season type to fetch series for (specify nothing to get current season).</param>
        /// <returns>Returns a dictionary of series group by media type.</returns>
        public async Task<Dictionary<MediaTypes, List<Series>>> BrowseSeasonsAsync(Seasons? season = null)
        {
            var criteria = new BrowseCriteria()
            {
                Year = GetYear(season),
                Season = season ?? GetCurrentSeason(),
                IncludeAiringData = true,
                IncludeFullPage = true
            };

            var url = AniListApiHelper.GetUrl(AnilistTypes.BrowseAnime, null, criteria);

            try
            {
                var rawAnime = await GenericGetAsync<List<SeriesDTO>>(url);
                return rawAnime?.GroupBy(x => x.type.GetEnumValue<MediaTypes>(), (key, series) => series.Select(Series.ConstructFromDto).ToList()).ToDictionary(x => x.FirstOrDefault().Type.Value, x => x);
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        /// <summary>
        /// Gets a list of all genres used on anilist.
        /// </summary>
        /// <returns>A list of string based genres</returns>
        public async Task<List<string>> GetGenreListAsync()
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.GenreList, QueryType.Search, null));

            try
            {
                var rawGenreList = await GenericGetAsync<List<string>>(url);

                return rawGenreList;
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        #region The Dark Side
        private async Task<bool> LoginAsync()
        {
            var paramaters = new List<KeyValuePair<string, string>>()
            {
                {"grant_type", _authGrantType},
                {"client_id", _authClientId},
                {"client_secret", _authClientSecret}
            };

            var url = AniListApiHelper.GetAuthUrl(paramaters);

            try
            {
                _authTicket = await GenericPostAsync<Authentication>(url, null);
                UpdateAuthHeader();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        private async Task<T> GenericPostAsync<T>(string url, HttpContent content, bool isVerifyInstance = false)
        {
            HttpResponseMessage response = await _client.PostAsync(url, content);

            //This check is due to the token timeout that may occur while the app is running.
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                if (!isVerifyInstance)
                {
                    await LoginAsync();
                    return await GenericPostAsync<T>(url, content, true);
                }
                else
                {
                    throw new Exception("Unauthorized access. Please validate the login details.");
                }
            }

            response.EnsureSuccessStatusCode();

            string value = await response.Content.ReadAsStringAsync();

            T responseObj = JsonConvert.DeserializeObject<T>(value);

            return responseObj;
        }

        private async Task<T> GenericGetAsync<T>(string url, bool isVerifyInstance = false)
            where T : class
        {
            HttpResponseMessage response = await _client.GetAsync(url);

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                if (!isVerifyInstance)
                {
                    await LoginAsync();
                    return await GenericGetAsync<T>(url, true);
                }
                else
                {
                    throw new Exception("Unauthorized access. Please validate the login details.");
                }
            }

            response.EnsureSuccessStatusCode();

            if (response.Content == null)
            {
                return null;
            }

            string value = await response.Content.ReadAsStringAsync();

            if (value.Contains("error"))
            {
                return null;
            }

            if (value == "[]")
            {
                return null;
            }

            value = SanitizeValue(value);

            if (typeof(T) == typeof(string))
            {
                return value as T;
            }

            var responseObj = JsonConvert.DeserializeObject<T>(value);

            return responseObj;
        }

        private static string SanitizeValue(string value)
        {
            if (value.Contains(",\"airing_stats\":[]"))
            {
                value = value.Replace(",\"airing_stats\":[]", string.Empty);
            }

            if (value.Contains(",\"genres\":[]"))
            {
                value = value.Replace(",\"genres\":[]", string.Empty);
            }

            if (value.Contains(",\"synonyms\":[]"))
            {
                value = value.Replace(",\"synonyms\":[]", string.Empty);
            }

            if (value.Contains(",\"score_distribution\":[]"))
            {
                value = value.Replace(",\"score_distribution\":[]", string.Empty);
            }

            return value;
        }

        private void UpdateAuthHeader()
        {
            _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(AniListApiHelper.FirstCharToUpper(_authTicket.token_type), _authTicket.access_token);
        }

        private static int GetYear(Seasons? season)
        {
            var currentSeason = GetCurrentSeason();

            if (season == Seasons.Fall)
            {
                return currentSeason == Seasons.Winter ? DateTime.UtcNow.AddYears(-1).Year : DateTime.UtcNow.Year;
            }

            return DateTime.UtcNow.Year;
        }

        private static Seasons GetCurrentSeason()
        {
            var currentMonth = DateTime.UtcNow.Month;

            if (currentMonth >= 3 && currentMonth < 6)
            {
                return Seasons.Spring; ;
            }
            else if (currentMonth >= 6 && currentMonth < 9)
            {
                return Seasons.Summer;
            }
            else if (currentMonth >= 9 && currentMonth < 12)
            {
                return Seasons.Fall;
            }

            return Seasons.Winter;
        }
        #endregion
    }
}
