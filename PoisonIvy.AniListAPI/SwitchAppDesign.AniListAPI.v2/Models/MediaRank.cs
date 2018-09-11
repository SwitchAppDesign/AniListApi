using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class MediaRank
    {
        /// <summary>
        /// The id of the rank
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// The numerical rank of the media
        /// </summary>
        public int? rank { get; set; }

        /// <summary>
        /// The type of ranking
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// The format the media is ranked within
        /// </summary>
        public string format { get; set; }

        /// <summary>
        /// The year the media is ranked within
        /// </summary>
        public int year { get; set; }

        /// <summary>
        /// The season the media is ranked within
        /// </summary>
        public string season { get; set; }

        /// <summary>
        /// If the ranking is based on all time instead of a season/year
        /// </summary>
        public bool allTime { get; set; }

        /// <summary>
        /// String that gives context to the ranking type and time span
        /// </summary>
        public string context { get; set; }
    }
}
