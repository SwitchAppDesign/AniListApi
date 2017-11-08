using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class MediaStreamingEpisode
    {
        /// <summary>
        /// Title of the episode
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Url of episode image thumbnail
        /// </summary>
        public string thumbnail { get; set; }

        /// <summary>
        /// The url of the episode
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// The site location of the streaming episodes
        /// </summary>
        public string site { get; set; }
    }
}
