using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class ThreadQueryFields
    {
        public ThreadQueryFields(AniListQueryType queryType)
        {
            InitializeProperties(queryType);
        }

        /// <summary>
        /// The id of the thread.
        /// </summary>
        public GraphQueryField IdQueryField()
        {
            return Id;
        }

        /// <summary>
        /// The title of the thread.
        /// </summary>
        public GraphQueryField TitleQueryField()
        {
            return Title;
        }

        /// <summary>
        /// The text body of the thread (Markdown).
        /// </summary>
        public GraphQueryField BodyQueryField()
        {
            return Body;
        }

        /// <summary>
        /// The id of the thread owner user.
        /// </summary>
        public GraphQueryField UserIdQueryField()
        {
            return UserId;
        }

        /// <summary>
        /// The id of the user who most recently commented on the thread.
        /// </summary>
        public GraphQueryField ReplyUserIdQueryField()
        {
            return ReplyUserId;
        }

        /// <summary>
        /// The id of the most recent comment on the thread.
        /// </summary>
        public GraphQueryField ReplyCommentIdQueryField()
        {
            return ReplyCommentId;
        }

        /// <summary>
        /// The number of comments on the thread.
        /// </summary>
        public GraphQueryField ReplyCountQueryField()
        {
            return ReplyCount;
        }

        /// <summary>
        /// The number of times users have viewed the thread.
        /// </summary>
        public GraphQueryField ViewCountQueryField()
        {
            return ViewCount;
        }

        /// <summary>
        /// If the thread is locked and can receive comments.
        /// </summary>
        public GraphQueryField IsLockedQueryField()
        {
            return IsLocked;
        }

        /// <summary>
        /// If the thread is stickied and should be displayed at the top of the page.
        /// </summary>
        public GraphQueryField IsStickyQueryField()
        {
            return IsSticky;
        }

        /// <summary>
        /// If the currently authenticated user is subscribed to the thread.
        /// </summary>
        public GraphQueryField IsSubscribedQueryField()
        {
            return IsSubscribed;
        }

        /// <summary>
        /// The time of the last reply.
        /// </summary>
        public GraphQueryField RepliedAtQueryField()
        {
            return RepliedAt;
        }

        /// <summary>
        /// The time of the thread creation.
        /// </summary>
        public GraphQueryField CreatedAtQueryField()
        {
            return CreatedAt;
        }

        /// <summary>
        /// The time of the thread last update.
        /// </summary>
        public GraphQueryField UpdatedAtQueryField()
        {
            return UpdatedAt;
        }

        /// <summary>
        /// The id of the thread owner user.
        /// </summary>
        public GraphQueryField UserQueryField()
        {
            return User;
        }

        /// <summary>
        /// The id of the user who most recently commented on the thread.
        /// </summary>
        public GraphQueryField ReplyUserQueryField()
        {
            return ReplyUser;
        }

        /// <summary>
        /// The users who liked the thread.
        /// </summary>
        public GraphQueryField LikesQueryField()
        {
            return Likes;
        }

        /// <summary>
        /// The url for the thread page on the AniList website.
        /// </summary>
        public GraphQueryField SiteUrlQueryField()
        {
            return SiteUrl;
        }

        /// <summary>
        /// The categories of the thread.
        /// </summary>
        public GraphQueryField CategoriesQueryField()
        {
            return Categories;
        }

        /// <summary>
        /// The media categories of the thread.
        /// </summary>
        public GraphQueryField MediaCategoriesQueryField()
        {
            return MediaCategories;
        }

        private GraphQueryField Id { get; set; }
        private GraphQueryField Title { get; set; }
        private GraphQueryField Body { get; set; }
        private GraphQueryField UserId { get; set; }
        private GraphQueryField ReplyUserId { get; set; }
        private GraphQueryField ReplyCommentId { get; set; }
        private GraphQueryField ReplyCount { get; set; }
        private GraphQueryField ViewCount { get; set; }
        private GraphQueryField IsLocked { get; set; }
        private GraphQueryField IsSticky { get; set; }
        private GraphQueryField IsSubscribed { get; set; }
        private GraphQueryField RepliedAt { get; set; }
        private GraphQueryField CreatedAt { get; set; }
        private GraphQueryField UpdatedAt { get; set; }
        private GraphQueryField User { get; set; }
        private GraphQueryField ReplyUser { get; set; }
        private GraphQueryField Likes { get; set; }
        private GraphQueryField SiteUrl { get; set; }
        private GraphQueryField Categories { get; set; }
        private GraphQueryField MediaCategories { get; set; }

        private void InitializeProperties(AniListQueryType queryType)
        {
            Id = new GraphQueryField("id", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            Title = new GraphQueryField("title", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            Body = new GraphQueryField("body", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            UserId = new GraphQueryField("userId", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            ReplyUserId = new GraphQueryField("replyUserId", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            ReplyCommentId = new GraphQueryField("replyCommentId", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            ReplyCount = new GraphQueryField("replyCount", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            ViewCount = new GraphQueryField("viewCount", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            IsLocked = new GraphQueryField("isLocked", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            IsSticky = new GraphQueryField("isSticky", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            IsSubscribed = new GraphQueryField("isSubscribed", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            RepliedAt = new GraphQueryField("repliedAt", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            CreatedAt = new GraphQueryField("createdAt", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            UpdatedAt = new GraphQueryField("updatedAt", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            User = new GraphQueryField("user", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            ReplyUser = new GraphQueryField("replyUser", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            Likes = new GraphQueryField("likes", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            SiteUrl = new GraphQueryField("siteUrl", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            Categories = new GraphQueryField("categories", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
            MediaCategories = new GraphQueryField("mediaCategories", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Thread }));
        }
    }
}
