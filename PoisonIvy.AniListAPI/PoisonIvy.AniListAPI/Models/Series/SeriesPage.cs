using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoisonIvy.AniListAPI.Types;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class SeriesPage
    {
        public long Id { get; set; }
        public string TitleRomaji { get; set; }
        public string TitleEnglish { get; set; }
        public string TitleJapanese { get; set; }
        public MediaTypes Type { get; set; }
        public SeriesType SeriesType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Seasons Season { get; set; }
        public int? Year { get; set; }
        public string Description { get; set; }
        public bool IsAdult { get; set; }
        public decimal AverageScore { get; set; }
        public int? Popularity { get; set; }
        public bool IsFavourite { get; set; }
        public string ImageUrlSmall { get; set; }
        public string ImageUrlMedium { get; set; }
        public string ImageUrlLarge { get; set; }
        public string ImageUrlBanner { get; set; }
        public List<Genres> Genres { get; set; }
        public List<string> Synonyms { get; set; }
        public string YoutubeId { get; set; }
        public string Hashtag { get; set; }
        public string UpdatedAt { get; set; }
        public Dictionary<string, int> ScoreDistribution { get; set; }
        public Dictionary<string, int> ListStats { get; set; }
        public int? TotalEpisodes { get; set; }
        public int? Duration { get; set; }
        public AiringStatus AiringStatus { get; set; }
        public AnimeSourceTypes Source { get; set; }
        public string Classification { get; set; }
        public Dictionary<string, AiringStats> AiringStats { get; set; }
        public List<BasicCharacter> Characters { get; set; }
        public List<BasicStaff> Staff { get; set; }
        public List<Studio> Studio { get; set; }
        public List<ExternalLink> ExternalLinks { get; set; }
        public List<Ranking> Rankings { get; set; }
        public List<Relation> Relations { get; set; }
        public List<Tag> Tags { get; set; }
        public Airing Airing { get; set; }
    }
}
