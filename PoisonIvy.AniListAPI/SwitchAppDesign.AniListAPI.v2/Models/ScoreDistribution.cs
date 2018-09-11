using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class ScoreDistribution
    {
        public int score { get; set; }

        /// <summary>
        /// The amount of list entries with this score
        /// </summary>
        public int amount { get; set; }
    }
}
