using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class User
    {
        /// <summary>
        /// The id of the user
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// The name of the user
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// The bio written by user (Markdown)
        /// </summary>
        public string about { get; set; }

        /// <summary>
        /// The user's avatar images
        /// </summary>
        public ImageData avatar { get; set; }

        /// <summary>
        /// If the authenticated user if following this user
        /// </summary>
        public bool isFollowing { get; set; }

        /// <summary>
        /// The user's general options
        /// </summary>
        public UserOptions options { get; set; }

        /// <summary>
        /// The user's media list options
        /// </summary>
        public MediaListOptions mediaListOptions { get; set; }

        /// <summary>
        /// The users favourites
        /// </summary>
        public Favourites favourites { get; set; }


        public UserStats stats { get; set; }

        /// <summary>
        /// The number of unread notifications the user has
        /// </summary>
        public int unreadNotificationCount { get; set; }

        /// <summary>
        /// The url for the user page on the AniList website
        /// </summary>
        public string siteUrl { get; set; }

        /// <summary>
        /// The donation tier of the user
        /// </summary>
        public int donatorTier { get; set; }

        /// <summary>
        /// When the user's data was last updated
        /// </summary>
        public int updatedAt { get; set; }
    }
}
