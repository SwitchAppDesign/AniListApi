using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class ThreadComment
    {
        public ThreadComment()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The id of the comment.
        /// </summary>
        public GraphQLQueryField IdQueryField { get; private set; }

        /// <summary>
        /// The user id of the comment's owner.
        /// </summary>
        public GraphQLQueryField UserIdQueryField { get; private set; }

        /// <summary>
        /// The id of thread the comment belongs to.
        /// </summary>
        public GraphQLQueryField ThreadIdQueryField { get; private set; }

        /// <summary>
        /// The text content of the comment (Markdown)
        /// </summary>
        public GraphQLQueryField CommentQueryField { get; private set; }

        /// <summary>
        /// The url for the comment page on the AniList website.
        /// </summary>
        public GraphQLQueryField SiteUrlQueryField { get; private set; }

        /// <summary>
        /// The time of the comments creation.
        /// </summary>
        public GraphQLQueryField CreatedAtQueryField { get; private set; }

        /// <summary>
        /// The time of the comments last update.
        /// </summary>
        public GraphQLQueryField UpdatedAtQueryField { get; private set; }

        /// <summary>
        /// The user id of the comment's owner.
        /// </summary>
        public GraphQLQueryField UserQueryField { get; private set; }

        /// <summary>
        /// The users who liked the comment.
        /// </summary>
        public GraphQLQueryField LikesQueryField { get; private set; }

        /// <summary>
        /// The comment's child reply comments.
        /// </summary>
        public GraphQLQueryField ChildCommentsQueryField { get; private set; }

        private void InitializeProperties()
        {
            IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
            UserIdQueryField = new GraphQLQueryField("userId", new FieldRules(false));
            ThreadIdQueryField = new GraphQLQueryField("threadId", new FieldRules(false));
            CommentQueryField = new GraphQLQueryField("comment", new FieldRules(false));
            SiteUrlQueryField = new GraphQLQueryField("siteUrl", new FieldRules(false));
            CreatedAtQueryField = new GraphQLQueryField("createdAt", new FieldRules(false));
            UpdatedAtQueryField = new GraphQLQueryField("updatedAt", new FieldRules(false));
            UserQueryField = new GraphQLQueryField("user", new FieldRules(false));
            LikesQueryField = new GraphQLQueryField("likes", new FieldRules(false));
            ChildCommentsQueryField = new GraphQLQueryField("childComments", new FieldRules(false));
        }
    }
}
