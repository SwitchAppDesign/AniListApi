using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class MediaStats
    {
        public ScoreDistribution[] scoreDistribution { get; set; }
        public StatusDistribution[] statusDistribution { get; set; }
        public AiringProgression[] airingProgression { get; set; }
    }
}
