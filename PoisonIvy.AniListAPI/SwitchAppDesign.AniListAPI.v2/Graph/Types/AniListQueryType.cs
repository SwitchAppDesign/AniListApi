using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Types
{
    /// <summary>
    /// All available AniList API v2 queries.
    /// </summary>
    public enum AniListQueryType
    {
        /// <summary>
        /// Page query type is used to query lists of data.
        /// </summary>
        [Description("Page")]
        Page = 1,

        /// <summary>
        /// Fetches a media information (manga or anime).
        /// </summary>
        [Description("Media")]
        Media = 2,

        /// <summary>
        /// Fetches the airing schedule of an anime.
        /// </summary>
        [Description("AiringSchedule")]
        AiringSchedule = 3,

        /// <summary>
        /// Fetches a characters information.
        /// </summary>
        [Description("Character")]
        Character = 4,

        /// <summary>
        /// Fetches a staff members information.
        /// </summary>
        [Description("Staff")]
        Staff = 5,

        /// <summary>
        /// Fetches a list of media for a user.
        /// </summary>
        [Description("MediaList")]
        MediaList = 6,

        /// <summary>
        /// Fetches a list of anime or manga for a user. 
        /// </summary>
        [Description("MediaListCollection")]
        MediaListCollection = 7,

        /// <summary>
        /// Fetches the full list of genres available.
        /// </summary>
        [Description("GenreCollection")]
        GenreCollection = 8,

        /// <summary>
        /// Fetches a list of media tags.
        /// </summary>
        [Description("MediaTagCollection")]
        MediaTagCollection = 9,

        /// <summary>
        /// Fetches a user.
        /// </summary>
        [Description("User")]
        User = 10,

        /// <summary>
        /// Fetches a viewer
        /// </summary>
        [Description("Viewer")]
        Viewer = 11,

        /// <summary>
        /// Fetches a notification.
        /// </summary>
        [Description("Notification")]
        Notification = 12,

        /// <summary>
        /// Fetches a studio.
        /// </summary>
        [Description("Studio")]
        Studio = 13,

        /// <summary>
        /// Fetches a review.
        /// </summary>
        [Description("Review")]
        Review = 14,

        /// <summary>
        /// Fetches an activity.
        /// </summary>
        [Description("Activity")]
        Activity = 15,
        
        /// <summary>
        /// Fetches and activity reply.
        /// </summary>
        [Description("ActivityReply")]
        ActivityReply = 16,

        /// <summary>
        /// Fetches information on a user who is following/followed.
        /// </summary>
        [Description("Following")]
        Following = 17,

        /// <summary>
        /// Fetches information on a user who is following/followed.
        /// </summary>
        [Description("Follower")]
        Follower = 18,

        /// <summary>
        /// Fetches a thread.
        /// </summary>
        [Description("Thread")]
        Thread = 19,

        /// <summary>
        /// Fetches a thread comment.
        /// </summary>
        [Description("ThreadComment")]
        ThreadComment = 20,

        /// <summary>
        /// Fetches markdown.
        /// </summary>
        [Description("Markdown")]
        Markdown = 21
    }
}
