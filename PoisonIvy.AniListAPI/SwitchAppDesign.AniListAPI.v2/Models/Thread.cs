using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class Thread
    {
        /// <summary>
        /// The id of the thread.
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// The title of the thread.
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// The text body of the thread (Markdown).
        /// </summary>
        public bool body { get; set; }

        /// <summary>
        /// The id of the thread owner user.
        /// </summary>
        public int? userId { get; set; }

        /// <summary>
        /// The id of the user who most recently commented on the thread.
        /// </summary>
        public int replyUserId { get; set; }

        /// <summary>
        /// The id of the most recent comment on the thread.
        /// </summary>
        public int replyCommentId { get; set; }

        /// <summary>
        /// The number of comments on the thread.
        /// </summary>
        public int replyCount { get; set; }

        /// <summary>
        /// The number of times users have viewed the thread.
        /// </summary>
        public int viewCount { get; set; }

        /// <summary>
        /// If the thread is locked and can receive comments.
        /// </summary>
        public bool isLocked { get; set; }

        /// <summary>
        /// If the thread is stickied and should be displayed at the top of the page.
        /// </summary>
        public bool isSticky { get; set; }

        /// <summary>
        /// If the currently authenticated user is subscribed to the thread.
        /// </summary>
        public bool isSubscribed { get; set; }

        /// <summary>
        /// The time of the last reply.
        /// </summary>
        public int repliedAt { get; set; }

        /// <summary>
        /// The time of the thread creation.
        /// </summary>
        public int? createdAt { get; set; }

        /// <summary>
        /// The time of the thread last update.
        /// </summary>
        public int? updatedAt { get; set; }

        /// <summary>
        /// The owner of the thread.
        /// </summary>
        public User user { get; set; }

        /// <summary>
        /// The user to last reply to the thread.
        /// </summary>
        public User replyUser { get; set; }

        /// <summary>
        /// The users who liked the thread.
        /// </summary>
        public User[] likes { get; set; }

        /// <summary>
        /// The url for the thread page on the AniList website.
        /// </summary>
        public string siteUrl { get; set; }

        /// <summary>
        /// The categories of the thread.
        /// </summary>
        public ThreadCategory[] categories { get; set; }

        /// <summary>
        /// The media categories of the thread.
        /// </summary>
        public Media[] mediaCategories { get; set; }
    }
}
