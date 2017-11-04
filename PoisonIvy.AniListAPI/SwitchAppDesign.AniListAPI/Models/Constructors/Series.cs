using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using PoisonIvy.AniListAPI.DTO;
using PoisonIvy.AniListAPI.Extentions;
using PoisonIvy.AniListAPI.Helpers;
using PoisonIvy.AniListAPI.Types;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class Series
    {
        public static Series ConstructFromDto(SeriesDTO dto)
        {
            var seasonAndYear = dto.season != null ? AniListApiHelper.GetSeasonType($"{dto.season}") : null;

            return new Series()
            {
                Id = dto.id,
                TitleRomaji = dto.title_romaji,
                TitleEnglish = dto.title_english,
                TitleJapanese = dto.title_japanese,
                Type =  dto.type?.GetEnumValue<MediaTypes>() ?? MediaTypes.NotFound,
                SeriesType = dto.series_type?.GetEnumValue<SeriesType>() ?? Types.SeriesType.NotFound,
                StartDate = dto.start_date,
                EndDate = dto.end_date,
                Season = seasonAndYear?.First().Value ?? Seasons.NotFound,
                Year = seasonAndYear?.First().Key,
                Description = dto.description,
                IsAdult = dto.adult,
                AverageScore = dto.average_score,
                Popularity = dto.popularity,
                IsFavourite = dto.favourite,
                ImageUrlSmall = dto.image_url_sml,
                ImageUrlMedium = dto.image_url_med,
                ImageUrlLarge = dto.image_url_lge,
                ImageUrlBanner = dto.image_url_banner,
                Genres = dto.genres?.Select(x => x.GetEnumValue<Genres>()).ToList(),
                Synonyms = dto.synonyms,
                YoutubeId = dto.youtube_id,
                Hashtag = dto.hashtag,
                UpdatedAt = dto.updated_at,
                ScoreDistribution = dto.score_distribution,
                ListStats = dto.list_stats != null ?  ListStats.ConstructFromDto(dto.list_stats) : null,
                TotalEpisodes = dto.total_episodes,
                Duration = dto.duration,
                AiringStatus = dto.airing_status?.GetEnumValue<AiringStatus>() ?? Types.AiringStatus.NotFound,
                Source = dto.source?.GetEnumValue<AnimeSourceTypes>() ?? AnimeSourceTypes.NotFound,
                Classification = dto.classification,
                AiringStats = dto.airing_stats != null ? ConvertAiringStatsDtoDictionaryToDictionary(dto.airing_stats) : null
            };
        }

        private static Dictionary<string, AiringStats> ConvertAiringStatsDtoDictionaryToDictionary(Dictionary<string, AiringStatsDTO> dtoAiringStats)
        {
            var result = new Dictionary<string, AiringStats>();

            foreach (var airingStatsDto in dtoAiringStats)
            {
                result.Add(airingStatsDto.Key, Models.AiringStats.ConstructFromDto(airingStatsDto.Value));    
            }

            return result;
        }
    }
}
