using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class ActivityReply
    {
        /// <summary>
        /// The id of the reply.
        /// </summary>
        public int? id { get; set; }

        /// <summary>
        /// The id of the replies creator.
        /// </summary>
        public int userId { get; set; }

        /// <summary>
        /// The id of the parent activity.
        /// </summary>
        public int activityId { get; set; }

        /// <summary>
        /// The reply text.
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// The time of the reply was created.
        /// </summary>
        public int? createdAt { get; set; }

        /// <summary>
        /// The user who created reply.
        /// </summary>
        public User user { get; set; }

        /// <summary>
        /// The users who liked the reply.
        /// </summary>
        public IEnumerable<User> likes { get; set; }
    }
}
