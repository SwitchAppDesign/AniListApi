using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class Tag
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsSpoiler { get; set; }
        public bool IsAdult { get; set; }
        public bool IsDemographic { get; set; }
        public int Denied { get; set; }
        public string Category { get; set; }
        public int Votes { get; set; }
        public bool IsSeriesSpoiler { get; set; }
    }
}
