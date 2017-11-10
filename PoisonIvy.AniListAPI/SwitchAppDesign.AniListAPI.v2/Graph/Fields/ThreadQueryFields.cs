using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class Thread
    {
        public Thread()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The id of the thread.
        /// </summary>
        public GraphQLQueryField IdQueryField { get; private set; }

        /// <summary>
        /// The title of the thread.
        /// </summary>
        public GraphQLQueryField TitleQueryField { get; private set; }

        /// <summary>
        /// The text body of the thread (Markdown).
        /// </summary>
        public GraphQLQueryField BodyQueryField { get; private set; }

        /// <summary>
        /// The id of the thread owner user.
        /// </summary>
        public GraphQLQueryField UserIdQueryField { get; private set; }

        /// <summary>
        /// The id of the user who most recently commented on the thread.
        /// </summary>
        public GraphQLQueryField ReplyUserIdQueryField { get; private set; }

        /// <summary>
        /// The id of the most recent comment on the thread.
        /// </summary>
        public GraphQLQueryField ReplyCommentIdQueryField { get; private set; }

        /// <summary>
        /// The number of comments on the thread.
        /// </summary>
        public GraphQLQueryField ReplyCountQueryField { get; private set; }

        /// <summary>
        /// The number of times users have viewed the thread.
        /// </summary>
        public GraphQLQueryField ViewCountQueryField { get; private set; }

        /// <summary>
        /// If the thread is locked and can receive comments.
        /// </summary>
        public GraphQLQueryField IsLockedQueryField { get; private set; }

        /// <summary>
        /// If the thread is stickied and should be displayed at the top of the page.
        /// </summary>
        public GraphQLQueryField IsStickyQueryField { get; private set; }

        /// <summary>
        /// If the currently authenticated user is subscribed to the thread.
        /// </summary>
        public GraphQLQueryField IsSubscribedQueryField { get; private set; }

        /// <summary>
        /// The time of the last reply.
        /// </summary>
        public GraphQLQueryField RepliedAtQueryField { get; private set; }

        /// <summary>
        /// The time of the thread creation.
        /// </summary>
        public GraphQLQueryField CreatedAtQueryField { get; private set; }

        /// <summary>
        /// The time of the thread last update.
        /// </summary>
        public GraphQLQueryField UpdatedAtQueryField { get; private set; }

        /// <summary>
        /// The id of the thread owner user.
        /// </summary>
        public GraphQLQueryField UserQueryField { get; private set; }

        /// <summary>
        /// The id of the user who most recently commented on the thread.
        /// </summary>
        public GraphQLQueryField ReplyUserQueryField { get; private set; }

        /// <summary>
        /// The users who liked the thread.
        /// </summary>
        public GraphQLQueryField LikesQueryField { get; private set; }

        /// <summary>
        /// The url for the thread page on the AniList website.
        /// </summary>
        public GraphQLQueryField SiteUrlQueryField { get; private set; }

        /// <summary>
        /// The categories of the thread.
        /// </summary>
        public GraphQLQueryField CategoriesQueryField { get; private set; }

        /// <summary>
        /// The media categories of the thread.
        /// </summary>
        public GraphQLQueryField MediaCategoriesQueryField { get; private set; }

        private void InitializeProperties()
        {
            IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
            TitleQueryField = new GraphQLQueryField("title", new FieldRules(false));
            BodyQueryField = new GraphQLQueryField("body", new FieldRules(false));
            UserIdQueryField = new GraphQLQueryField("userId", new FieldRules(false));
            ReplyUserIdQueryField = new GraphQLQueryField("replyUserId", new FieldRules(false));
            ReplyCommentIdQueryField = new GraphQLQueryField("replyCommentId", new FieldRules(false));
            ReplyCountQueryField = new GraphQLQueryField("replyCount", new FieldRules(false));
            ViewCountQueryField = new GraphQLQueryField("viewCount", new FieldRules(false));
            IsLockedQueryField = new GraphQLQueryField("isLocked", new FieldRules(false));
            IsStickyQueryField = new GraphQLQueryField("isSticky", new FieldRules(false));
            IsSubscribedQueryField = new GraphQLQueryField("isSubscribed", new FieldRules(false));
            RepliedAtQueryField = new GraphQLQueryField("repliedAt", new FieldRules(false));
            CreatedAtQueryField = new GraphQLQueryField("createdAt", new FieldRules(false));
            UpdatedAtQueryField = new GraphQLQueryField("updatedAt", new FieldRules(false));
            UserQueryField = new GraphQLQueryField("user", new FieldRules(false));
            ReplyUserQueryField = new GraphQLQueryField("replyUser", new FieldRules(false));
            LikesQueryField = new GraphQLQueryField("likes", new FieldRules(false));
            SiteUrlQueryField = new GraphQLQueryField("siteUrl", new FieldRules(false));
            CategoriesQueryField = new GraphQLQueryField("categories", new FieldRules(false));
            MediaCategoriesQueryField = new GraphQLQueryField("mediaCategories", new FieldRules(false));
        }
    }
}
