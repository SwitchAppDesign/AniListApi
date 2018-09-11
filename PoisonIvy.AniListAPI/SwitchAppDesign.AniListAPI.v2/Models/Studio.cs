using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class Studio
    {
        /// <summary>
        /// The id of the studio
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// The name of the studio
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The media the studio has worked on
        /// </summary>
        public MediaConnection media { get; set; }

        /// <summary>
        /// The url for the studio page on the AniList website
        /// </summary>
        public string siteUrl { get; set; }

        /// <summary>
        /// If the studio is marked as favourite by the currently authenticated user
        /// </summary>
        public bool? isFavourite { get; set; }
    }
}
