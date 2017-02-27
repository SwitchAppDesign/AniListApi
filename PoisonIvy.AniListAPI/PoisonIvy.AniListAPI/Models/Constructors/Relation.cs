using System;
using System.Collections.Generic;
using PoisonIvy.AniListAPI.DTO;
using PoisonIvy.AniListAPI.Helpers;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class Relation
    {
        public static Relation ConstructFromDto(RelationDTO dto)
        {
            return new Relation()
            {
                Id = dto.id,
                TitleRomaji = dto.title_romaji,
                TitleEnglish = dto.title_english,
                TitleJapanese = dto.title_japanese,
                Type = dto.type,
                StartDate = dto.start_date,
                EndDate = dto.end_date,
                Season = dto.season,
                SeriesType = dto.series_type,
                Synonyms = dto.synonyms,
                Genres = dto.genres,
                IsAdult = dto.adult,
                AverageScore = dto.average_score,
                Popularity = dto.popularity,
                UpdatedAt = dto.updated_at,
                ImageUrlSmall = dto.image_url_sml,
                ImageUrlMedium = dto.image_url_med,
                ImageUrlLarge = dto.image_url_lge,
                ImageUrlBanner = dto.image_url_banner,
                TotalEpisodes = dto.total_episodes,
                AiringStatus = dto.airing_status,
                RelationType = AniListApiHelper.GetRelationType(dto.relation_type)
            };
        }
    }
}