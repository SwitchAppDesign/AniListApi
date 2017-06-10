using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoisonIvy.AniListAPI.DTO;
using PoisonIvy.AniListAPI.Extentions;
using PoisonIvy.AniListAPI.Helpers;
using PoisonIvy.AniListAPI.Types;

namespace PoisonIvy.AniListAPI.Models
{
    partial class SeriesPage
    {
        public static SeriesPage ConstructFromDto(SeriesPageDTO dto)
        {
            var seasonAndYear = dto.season != null ? AniListApiHelper.GetSeasonType($"{dto.season}") : null;

            return new SeriesPage()
            {
                Id = dto.id,
                TitleRomaji = dto.title_romaji,
                TitleEnglish = dto.title_english,
                TitleJapanese = dto.title_japanese,
                Type = dto.type?.GetEnumValue<MediaTypes>() ?? MediaTypes.NotFound,
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
                ListStats = dto.list_stats,
                TotalEpisodes = dto.total_episodes,
                Duration = dto.duration,
                AiringStatus = dto.airing_status?.GetEnumValue<AiringStatus>() ?? Types.AiringStatus.NotFound,
                Source = dto.source?.GetEnumValue<AnimeSourceTypes>() ?? AnimeSourceTypes.Other,
                Classification = dto.classification,
                AiringStats = dto.airing_stats != null ? ConvertAiringStatsDtoDictionaryToDictionary(dto.airing_stats) : null,
                Characters = dto.characters?.Select(BasicCharacter.ConstructFromDto).ToList(),
                Staff = dto.staff?.Select(BasicStaff.ConstructFromDto).ToList(),
                Studio = dto.studio?.Select(Models.Studio.ConstructFromDto).ToList(),
                ExternalLinks = dto.external_links?.Select(ExternalLink.ConstructFromDto).ToList(),
                Rankings = dto.rankings?.Select(Ranking.ConstructFromDto).ToList(),
                Relations = dto.relations?.Select(Relation.ConstructFromDto).ToList(),
                Tags = dto.tags?.Select(Tag.ConstructFromDto).ToList(),
                Airing = dto.airing != null ? Models.Airing.ConstructFromDto(dto.airing) : null
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
