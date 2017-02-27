using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoisonIvy.AniListAPI.Types;

namespace PoisonIvy.AniListAPI.Models
{
    public class BrowseCriteria
    {
        public int Year { get; set; }
        public Seasons? Season { get; set; }
        public SeriesType? Type { get; set; }
        public AiringStatus? AiringStatus { get; set; }
        public List<Genres> IncludeGenres { get; set; }
        public List<Genres> ExcludeGenres { get; set; }
        public SortTypes? SortType { get; set; }
        public bool IsDescending { get; set; }
        public bool IncludeAiringData { get; set; }
        public bool IncludeFullPage { get; set; }
        public int Page { get; set; }
    }
}
