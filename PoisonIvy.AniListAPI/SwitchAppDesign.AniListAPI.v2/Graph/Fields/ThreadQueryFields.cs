using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class ThreadQueryFields
    {
        private readonly List<AniListQueryType> _allowedQueryTypes;
        private readonly AniListQueryType _queryType;

        public ThreadQueryFields(AniListQueryType queryType)
        {
            _queryType = queryType;
            _allowedQueryTypes = new List<AniListQueryType> { AniListQueryType.Thread };
        }

        private FieldRules InitilizeDefaultFieldRules(bool authenticationRequired = false)
        {
            return new FieldRules(authenticationRequired, _allowedQueryTypes);
        }

        /// <summary>
        /// The id of the thread.
        /// </summary>
        public GraphQueryField IdQueryField()
        {
            return new GraphQueryField("id", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The title of the thread.
        /// </summary>
        public GraphQueryField TitleQueryField()
        {
            return new GraphQueryField("title", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The text body of the thread (Markdown).
        /// </summary>
        public GraphQueryField BodyQueryField()
        {
            return new GraphQueryField("body", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The id of the thread owner user.
        /// </summary>
        public GraphQueryField UserIdQueryField()
        {
            return new GraphQueryField("userId", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The id of the user who most recently commented on the thread.
        /// </summary>
        public GraphQueryField ReplyUserIdQueryField()
        {
            return new GraphQueryField("replyUserId", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The id of the most recent comment on the thread.
        /// </summary>
        public GraphQueryField ReplyCommentIdQueryField()
        {
            return new GraphQueryField("replyCommentId", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The number of comments on the thread.
        /// </summary>
        public GraphQueryField ReplyCountQueryField()
        {
            return new GraphQueryField("replyCount", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The number of times users have viewed the thread.
        /// </summary>
        public GraphQueryField ViewCountQueryField()
        {
            return new GraphQueryField("viewCount", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// If the thread is locked and can receive comments.
        /// </summary>
        public GraphQueryField IsLockedQueryField()
        {
            return new GraphQueryField("isLocked", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// If the thread is stickied and should be displayed at the top of the page.
        /// </summary>
        public GraphQueryField IsStickyQueryField()
        {
            return new GraphQueryField("isSticky", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// If the currently authenticated user is subscribed to the thread.
        /// </summary>
        public GraphQueryField IsSubscribedQueryField()
        {
            return new GraphQueryField("isSubscribed", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The time of the last reply.
        /// </summary>
        public GraphQueryField RepliedAtQueryField()
        {
            return new GraphQueryField("repliedAt", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The time of the thread creation.
        /// </summary>
        public GraphQueryField CreatedAtQueryField()
        {
            return new GraphQueryField("createdAt", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The time of the thread last update.
        /// </summary>
        public GraphQueryField UpdatedAtQueryField()
        {
            return new GraphQueryField("updatedAt", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The id of the thread owner user.
        /// </summary>
        public GraphQueryField UserQueryField()
        {
            return new GraphQueryField("user", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The id of the user who most recently commented on the thread.
        /// </summary>
        public GraphQueryField ReplyUserQueryField()
        {
            return new GraphQueryField("replyUser", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The users who liked the thread.
        /// </summary>
        public GraphQueryField LikesQueryField()
        {
            return new GraphQueryField("likes", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The url for the thread page on the AniList website.
        /// </summary>
        public GraphQueryField SiteUrlQueryField()
        {
            return new GraphQueryField("siteUrl", GetType(), _queryType, InitilizeDefaultFieldRules());

        }

        /// <summary>
        /// The categories of the thread.
        /// </summary>
        public GraphQueryField CategoriesQueryField()
        {
            return new GraphQueryField("categories", GetType(), _queryType, InitilizeDefaultFieldRules());
            
        }

        /// <summary>
        /// The media categories of the thread.
        /// </summary>
        public GraphQueryField MediaCategoriesQueryField()
        {
            return new GraphQueryField("mediaCategories", GetType(), _queryType, InitilizeDefaultFieldRules());
        }
    }
}
