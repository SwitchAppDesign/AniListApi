using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class Character
    {
        /// <summary>
        /// The id of the character
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// The names of the character
        /// </summary>
        public Name name { get; set; }

        /// <summary>
        /// Character images
        /// </summary>
        public ImageData image { get; set; }

        /// <summary>
        /// A general description of the character
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// If the character is marked as favourite by the currently authenticated user
        /// </summary>
        public bool? isFavourite { get; set; }

        /// <summary>
        /// The url for the character page on the AniList website
        /// </summary>
        public string siteUrl { get; set; }

        /// <summary>
        /// Media that includes the character
        /// </summary>
        public MediaConnection media { get; set; }
    }
}
