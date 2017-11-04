using System;
using System.Collections.Generic;
using PoisonIvy.AniListAPI.Types;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class Relation
    {
        public long Id { get; set; }
        public string TitleRomaji { get; set; }
        public string TitleEnglish { get; set; }
        public string TitleJapanese { get; set; }
        public string Type { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Season { get; set; }
        public string SeriesType { get; set; }
        public List<string> Synonyms { get; set; }
        public List<string> Genres { get; set; }
        public bool IsAdult { get; set; }
        public decimal AverageScore { get; set; }
        public int? Popularity { get; set; }
        public long UpdatedAt { get; set; }
        public string ImageUrlSmall { get; set; }
        public string ImageUrlMedium { get; set; }
        public string ImageUrlLarge { get; set; }
        public string ImageUrlBanner { get; set; }
        public int? TotalEpisodes { get; set; }
        public string AiringStatus { get; set; }
        public RelationType RelationType { get; set; }
    }
}