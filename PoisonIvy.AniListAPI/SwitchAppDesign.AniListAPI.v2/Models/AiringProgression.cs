using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class AiringProgression
    {
        /// <summary>
        /// The episode the stats were recorded at. .5 is the mid point between 2 episodes airing dates.
        /// </summary>
        public decimal episode { get; set; }
        
        /// <summary>
        /// The average score for the media
        /// </summary>
        public int score { get; set; }
        
        /// <summary>
        /// The amount of users watching the anime
        /// </summary>
        public int watching { get; set; }
    }
}
