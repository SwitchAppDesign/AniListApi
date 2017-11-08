using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class MediaTag
    {
        /// <summary>
        /// The id of the tag
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// The name of the tag
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// A general description of the tag
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// The categories of tags this tag belongs to
        /// </summary>
        public string category { get; set; }

        /// <summary>
        /// The relevance ranking of the tag out of the 100 for this media
        /// </summary>
        public int rank { get; set; }

        /// <summary>
        /// If the tag could be a spoiler for any media
        /// </summary>
        public bool isGeneralSpoiler { get; set; }

        /// <summary>
        /// If the tag is a spoiler for this media
        /// </summary>
        public bool isMediaSpoiler { get; set; }

        /// <summary>
        /// If the tag is only for adult 18+ media
        /// </summary>
        public bool isAdult { get; set; }
    }
}
