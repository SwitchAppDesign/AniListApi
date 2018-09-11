using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class ThreadComment
    {
        /// <summary>
        /// The id of the comment.
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// The user id of the comment's owner.
        /// </summary>
        public int userId { get; set; }

        /// <summary>
        /// The id of thread the comment belongs to.
        /// </summary>
        public int threadId { get; set; }

        /// <summary>
        /// The text content of the comment (Markdown)
        /// </summary>
        public string comment { get; set; }

        /// <summary>
        /// The url for the comment page on the AniList website.
        /// </summary>
        public string siteUrl { get; set; }

        /// <summary>
        /// The time of the comments creation.
        /// </summary>
        public int? createdAt { get; set; }

        /// <summary>
        /// The time of the comments last update.
        /// </summary>
        public int? updatedAt { get; set; }

        /// <summary>
        /// The user who created the comment.
        /// </summary>
        public User user { get; set; }

        /// <summary>
        /// The users who liked the comment.
        /// </summary>
        public User[] likes { get; set; }

        /// <summary>
        /// The comment's child reply comments.
        /// </summary>
        public string childComments { get; set; }
    }
}
