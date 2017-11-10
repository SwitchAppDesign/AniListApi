using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class ActivityReply
    {
        public ActivityReply()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The id of the reply.
        /// </summary>
        public GraphQLQueryField IdQueryField { get; private set; }

        /// <summary>
        /// The id of the replies creator.
        /// </summary>
        public GraphQLQueryField UserIdQueryField { get; private set; }

        /// <summary>
        /// The id of the parent activity.
        /// </summary>
        public GraphQLQueryField ActivityIdQueryField { get; private set; }

        /// <summary>
        /// The reply text.
        /// </summary>
        public GraphQLQueryField TextQueryField { get; private set; }

        /// <summary>
        /// The time of the reply was created.
        /// </summary>
        public GraphQLQueryField CreatedAtQueryField { get; private set; }

        /// <summary>
        /// The id of the replies creator.
        /// </summary>
        public GraphQLQueryField UserQueryField { get; private set; }

        /// <summary>
        /// The users who liked the reply.
        /// </summary>
        public GraphQLQueryField LikesQueryField { get; private set; }

        private void InitializeProperties()
        {
            IdQueryField = new GraphQLQueryField("id", new FieldRules(false));
            UserIdQueryField = new GraphQLQueryField("userId", new FieldRules(false));
            ActivityIdQueryField = new GraphQLQueryField("activityId", new FieldRules(false));
            TextQueryField = new GraphQLQueryField("text", new FieldRules(false));
            CreatedAtQueryField = new GraphQLQueryField("createdAt", new FieldRules(false));
            UserQueryField = new GraphQLQueryField("user", new FieldRules(false));
            LikesQueryField = new GraphQLQueryField("likes", new FieldRules(false));
        }
    }
}
