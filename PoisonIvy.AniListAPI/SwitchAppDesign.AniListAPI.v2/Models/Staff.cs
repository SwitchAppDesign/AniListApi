using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class Staff
    {
        /// <summary>
        /// The id of the staff member
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// The names of the staff member
        /// </summary>
        public Name name { get; set; }

        /// <summary>
        /// The primary language of the staff member
        /// </summary>
        public string language { get; set; }

        /// <summary>
        /// The staff images
        /// </summary>
        public ImageData image { get; set; }

        /// <summary>
        /// A general description of the staff member
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// If the staff member is marked as favourite by the currently authenticated user
        /// </summary>
        public bool? isFavourite { get; set; }

        /// <summary>
        /// The url for the staff page on the AniList website
        /// </summary>
        public string siteUrl { get; set; }

        /// <summary>
        /// Media where the staff member has a production role
        /// </summary>
        public MediaConnection staffMedia { get; set; }

        /// <summary>
        /// Characters voiced by the actor
        /// </summary>
        public CharacterConnection characters { get; set; }
    }
}
