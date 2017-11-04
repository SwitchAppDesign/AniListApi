using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class Airing
    {
        public DateTime? Time { get; set; }
        public long Countdown { get; set; }
        public int NextEpisode { get; set; }
    }
}
