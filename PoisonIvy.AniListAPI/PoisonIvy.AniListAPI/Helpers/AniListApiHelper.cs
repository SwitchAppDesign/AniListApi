using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using PoisonIvy.AniListAPI.DTO.Shared;
using PoisonIvy.AniListAPI.Models;
using PoisonIvy.AniListAPI.Types;

namespace PoisonIvy.AniListAPI.Helpers
{
    internal class AniListApiHelper
    {
        private static readonly string BaseUrl = "https://anilist.co/api/";
        private static readonly string AuthUrl = "auth/access_token";
        private static readonly string AnimeUrl = "anime/";
        private static readonly string MangaUrl = "manga/";
        private static readonly string StudioUrl = "studio/";
        private static readonly string SearchUrl = "search/";
        private static readonly string CharacterUrlSuffix = "/characters";
        private static readonly string CharacterUrl = "characters/";
        private static readonly string StaffUrlSuffix = "/staff";
        private static readonly string StaffUrl = "staff/";
        private static readonly string ActorsUrlSuffix = "/actors";
        private static readonly string ActorsUrl = "actors/";
        private static readonly string AiringUrl = "/airing";
        private static readonly string PageUrl = "/page";
        private static readonly string BrowseUrl = "browse/";
        private static readonly string GenreListUrl = "genre_list";

        public static string GetBaseUrl()
        {
            return BaseUrl;
        }

        public static string GetUrl(AnilistTypes anilistType, QueryType? queryType, object queryParameter)
        {
            switch (anilistType)
            {
                case AnilistTypes.Anime:
                    return $"{AnimeUrl}{GetQueryTypeUrl(queryType, queryParameter)}";
                case AnilistTypes.Manga:
                    return $"{MangaUrl}{GetQueryTypeUrl(queryType, queryParameter)}";
                case AnilistTypes.Actor:
                    return $"{ActorsUrl}{GetQueryTypeUrl(queryType, queryParameter)}";
                case AnilistTypes.Character:
                    return $"{CharacterUrl}{GetQueryTypeUrl(queryType, queryParameter)}";
                case AnilistTypes.Staff:
                    return $"{StaffUrl}{GetQueryTypeUrl(queryType, queryParameter)}";
                case AnilistTypes.Studio:
                    return $"{StudioUrl}{GetQueryTypeUrl(queryType, queryParameter)}";
                case AnilistTypes.BrowseAnime:
                    return $"{BrowseUrl}anime{GetBrowseUrlParameteres(BrowseCriteriaDTO.CriterToCriteriaDTO((BrowseCriteria)queryParameter))}";
                case AnilistTypes.GenreList:
                    return $"{GenreListUrl}";
            }

            return null;
        }

        private static string GetQueryTypeUrl(QueryType? queryType, object queryParameter)
        {
            switch (queryType)
            {
                case QueryType.Search:
                    return $"{SearchUrl}{queryParameter}";
                case QueryType.Single:
                    return $"{queryParameter}";
                case QueryType.Page:
                    return $"{queryParameter}{PageUrl}";
                case QueryType.Airing:
                    return $"{queryParameter}{AiringUrl}";
                case QueryType.AnimeCharacters:
                    return $"{queryParameter}{CharacterUrlSuffix}";
                case QueryType.AnimeStaff:
                    return $"{queryParameter}{StaffUrlSuffix}";
                case QueryType.AnimeActors:
                    return $"{queryParameter}{ActorsUrlSuffix}";
            }

            return null;
        }

        public static RelationType GetRelationType(string relationType)
        {
            switch (relationType)
            {
                case "sequel":
                    return RelationType.Sequel;
                case "prequel":
                    return RelationType.Prequel;
                default:
                    return RelationType.None;
            }
        }

        public static Dictionary<int, Seasons?> GetSeasonType(string season)
        {
            var seasonNumber = -1;
            var yearNumber = -1;
            var currentYear = int.Parse(DateTime.UtcNow.Year.ToString().Substring(1, 3));

            if (!int.TryParse($"{season.Substring(0, 2)}", out yearNumber))
            {
                return null;
            }

            if (!int.TryParse($"{season.Last()}", out seasonNumber))
            {
                return null;
            }

            var year = seasonNumber > currentYear ? int.Parse($"19{yearNumber}") : int.Parse($"20{yearNumber}");

            switch (seasonNumber)
            {
                case 1:
                    return new Dictionary<int, Seasons?>() { { year, Seasons.Winter } };
                case 2:
                    return new Dictionary<int, Seasons?>() { { year, Seasons.Spring } };
                case 3:
                    return new Dictionary<int, Seasons?>() { { year, Seasons.Summer } };
                case 4:
                    return new Dictionary<int, Seasons?>() { { year, Seasons.Fall } };
            }

            return null;
        }

        public static string GetAuthUrl(List<KeyValuePair<string, string>> paramaters)
        {
            return UrlToUrlParams($"{AuthUrl}", paramaters);
        }

        public static string FirstCharToUpper(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            return input.First().ToString().ToUpper() + input.Substring(1);
        }

        private static string UrlToUrlParams(string baseUrl, List<KeyValuePair<string, string>> paramaters)
        {
            bool hasParams;

            if (paramaters.Count > 0)
            {
                hasParams = true;
            }
            else
            {
                hasParams = false;
            }

            if (hasParams)
                baseUrl += "?";

            paramaters.ForEach(param =>
            {
                baseUrl += param.Key + "=" + param.Value + "&";
            });

            if (hasParams)
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }

            return baseUrl;
        }

        private static string GetBrowseUrlParameteres(BrowseCriteriaDTO criteria)
        {
            var result = new StringBuilder("?");

            var properties = criteria.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (property.GetValue(criteria, null) != null)
                {
                    result.Append($"{property.Name}={property.GetValue(criteria, null)}&");
                }
            }

            return $"{result.ToString().Substring(0, result.ToString().Length - 1)}";
        }
    }
}
