using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoisonIvy.AniListAPI.Helpers;
using PoisonIvy.AniListAPI.Models;

namespace PoisonIvy.AniListAPI.DTO.Shared
{
    public class BrowseCriteriaDTO
    {
        public static BrowseCriteriaDTO CriterToCriteriaDTO(BrowseCriteria criteria)
        {
            var result = new BrowseCriteriaDTO()
            {
                year = criteria.Year.ToString(),
                season = criteria.Season?.GetDescription(),
                type = criteria.Type?.GetDescription(),
                status = criteria.AiringStatus?.GetDescription(),
                genres =  criteria.ExcludeGenres != null ? $"{criteria.ExcludeGenres.Select(x => x.GetDescription())}," : null,
                genres_exclude = criteria.ExcludeGenres != null ? $"{criteria.ExcludeGenres.Select(x => $"{x.GetDescription()},")}" : null,
                sort = criteria.SortType?.GetDescription(),
                SortOrder = criteria.IsDescending ? "desc" : null,
                airing_data = criteria.IncludeAiringData ? "true" : null,
                full_page = criteria.IncludeFullPage ? "true" : null,
                page = null
            };

            if (result.genres != null)
            {
                result.genres = result.genres.Last() == ',' ? result.genres.Substring(0, result.genres.Length - 1) : result.genres;
            }

            if (result.genres_exclude != null)
            {
                result.genres_exclude = result.genres_exclude.Last() == ',' ? result.genres_exclude.Substring(0, result.genres_exclude.Length - 1) : result.genres_exclude;
            }

            return result;
        }

        public string year { get; set; }
        public string season { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public string genres { get; set; }
        public string genres_exclude { get; set; }
        public string sort { get; set; }
        public string SortOrder { get; set; }
        public string airing_data { get; set; }
        public string full_page { get; set; }
        public string page { get; set; }

    }
}
