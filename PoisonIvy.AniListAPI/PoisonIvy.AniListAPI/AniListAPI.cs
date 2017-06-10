using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
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

            return await Login();
        }

        public async Task<List<Series>> SearchSeries(string searchPhrase)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.Anime, QueryType.Search, searchPhrase));

            try
            {
                var rawSeries = await GenericGet<List<SeriesDTO>>(url);

                return rawSeries?.Select(Series.ConstructFromDto).ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        public async Task<Series> GetSeries(long anilistAnimeid)
        {
            var url = AniListApiHelper.GetUrl(AnilistTypes.Anime, QueryType.Single, anilistAnimeid);

            try
            {
                var rawAnime = await GenericGet<SeriesDTO>(url);
                return rawAnime != null ? Series.ConstructFromDto(rawAnime) : null;
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve series. Error: {e}");
            }
        }

        public async Task<SeriesPage> GetSeriesPage(long anilistAnimeid)
        {
            var url = AniListApiHelper.GetUrl(AnilistTypes.Anime, QueryType.Page, anilistAnimeid);

            try
            {
                var rawAnime = await GenericGet<SeriesPageDTO>(url);
                return rawAnime != null ? SeriesPage.ConstructFromDto(rawAnime) : null;
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve series. Error: {e}");
            }
        }

        public async Task<Dictionary<long, SeriesPage>> GetListOfSeriesPages(IEnumerable<long> anilistSeriesIds)
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
                    var rawAnime = await GenericGet<SeriesPageDTO>(url);

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

        public async Task<Dictionary<string, long>> GetAnimeAiringTimes(long anilistAnimeId)
        {
            var url = AniListApiHelper.GetUrl(AnilistTypes.Anime, QueryType.Airing, anilistAnimeId);

            try
            {
                return await GenericGet<Dictionary<string, long>>(url);
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve next airing times. Error: {e}");
            }
        }

        public async Task<List<Character>> SearchCharacters(string searchPhrase)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.Character, QueryType.Search, searchPhrase));

            try
            {
                var rawCharacters = await GenericGet<List<CharacterDTO>>(url);

                return rawCharacters?.Select(Character.ConstructFromDto).ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        public async Task<Character> GetCharacter(long anilistCharacterId)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.Character, QueryType.Single, anilistCharacterId));

            try
            {
                var rawCharacters = await GenericGet<CharacterDTO>(url);

                return Character.ConstructFromDto(rawCharacters);
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        public async Task<List<Staff>> SearchStaff(long anilistCharacterId)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.Character, QueryType.Single, anilistCharacterId));

            try
            {
                var rawStaff = await GenericGet<List<StaffDTO>>(url);

                return rawStaff?.Select(Staff.ConstructFromDto).ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        public async Task<Staff> GetStaff(long anilistCharacterId)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.Character, QueryType.Single, anilistCharacterId));

            try
            {
                var rawStaff = await GenericGet<StaffDTO>(url);

                return Staff.ConstructFromDto(rawStaff);
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        public async Task<List<Actor>> SearchActor(long anilistCharacterId)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.Character, QueryType.Single, anilistCharacterId));

            try
            {
                var rawActors = await GenericGet<List<ActorDTO>>(url);

                return rawActors?.Select(Actor.ConstructFromDto).ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        public async Task<Actor> GetActor(long anilistCharacterId)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.Character, QueryType.Single, anilistCharacterId));

            try
            {
                var rawActor = await GenericGet<ActorDTO>(url);

                return Actor.ConstructFromDto(rawActor);
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        public async Task<List<Studio>> SearchStudios(long anilistCharacterId)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.Character, QueryType.Single, anilistCharacterId));

            try
            {
                var rawStudio = await GenericGet<List<StudioDTO>>(url);

                return rawStudio?.Select(Studio.ConstructFromDto).ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        public async Task<Studio> GetStudio(long anilistCharacterId)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.Character, QueryType.Single, anilistCharacterId));

            try
            {
                var rawStudio = await GenericGet<StudioDTO>(url);

                return Studio.ConstructFromDto(rawStudio);
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        public async Task<List<Series>> BrowseSeries(BrowseCriteria criteria)
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.BrowseAnime, null, criteria));

            try
            {
                var rawAnime = await GenericGet<List<SeriesDTO>>(url);

                return rawAnime?.Select(Series.ConstructFromDto).ToList();
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        /// <summary>
        /// Returns a dictionary of series for the specified season grouped by type.
        /// </summary>
        /// <param name="season">Season type to fetch series for (pass in null for current season).</param>
        /// <returns></returns>
        public async Task<Dictionary<MediaTypes, List<Series>>> BrowseSeasons(Seasons? season)
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
                var rawAnime = await GenericGet<List<SeriesDTO>>(url);
                var test = rawAnime?.Select(Series.ConstructFromDto).ToList();
                return rawAnime?.GroupBy(x => x.type.GetEnumValue<MediaTypes>(), (key, series) => series.Select(Series.ConstructFromDto).ToList()).ToDictionary(x => x.FirstOrDefault().Type.Value, x => x);
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        public async Task<List<string>> GetGenreList()
        {
            var url = HttpUtility.HtmlEncode(AniListApiHelper.GetUrl(AnilistTypes.GenreList, QueryType.Search, null));

            try
            {
                var rawGenreList = await GenericGet<List<string>>(url);

                return rawGenreList;
            }
            catch (Exception e)
            {
                throw new Exception($"Failed to retrieve search. Error: {e}");
            }
        }

        #region The Dark Side
        private async Task<bool> Login()
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
                _authTicket = await GenericPost<Authentication>(url, null);
                UpdateAuthHeader();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        private async Task<T> GenericPost<T>(string url, HttpContent content, bool isVerifyInstance = false)
        {
            HttpResponseMessage response = await _client.PostAsync(url, content);

            //This check is due to the token timeout that may occur while the app is running.
            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                if (!isVerifyInstance)
                {
                    await Login();
                    return await GenericPost<T>(url, content, true);
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

        private async Task<T> GenericGet<T>(string url, bool isVerifyInstance = false)
            where T : class
        {
            HttpResponseMessage response = await _client.GetAsync(url);

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                if (!isVerifyInstance)
                {
                    await Login();
                    return await GenericGet<T>(url, true);
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
