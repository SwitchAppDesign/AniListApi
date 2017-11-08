using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class UserStats
    {
        /// <summary>
        /// The amount of anime the user has watched in minutes
        /// </summary>
        public int watchedTime { get; set; }

        /// <summary>
        /// The amount of manga chapters the user has read
        /// </summary>
        public int chaptersRead { get; set; }

        public UserActivityHistory[] activityHistory { get; set; }
        public StatusDistribution[] animeStatusDistribution { get; set; }
        public StatusDistribution[] mangaStatusDistribution { get; set; }
        public ScoreDistribution[] animeScoreDistribution { get; set; }
        public ScoreDistribution[] mangaScoreDistribution { get; set; }
    }
}
