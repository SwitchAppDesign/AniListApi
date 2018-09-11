using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class AiringSchedule
    {
        /// <summary>
        /// The id of the airing schedule item
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// Time the episode airs
        /// </summary>
        public int? airingAt { get; set; }

        /// <summary>
        /// Seconds until episode starts airing
        /// </summary>
        public int? timeUntilAiring { get; set; }

        /// <summary>
        /// The airing episode number
        /// </summary>
        public int? episode { get; set; }

        /// <summary>
        /// The associate media id of the airing episode
        /// </summary>
        public int? mediaId { get; set; }

        /// <summary>
        /// The associate media of the airing episode
        /// </summary>
        public Media media { get; set; }
    }
}
