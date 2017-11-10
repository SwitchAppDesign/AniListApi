using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    internal class Page
    {
        public Page()
        {
            InitializeProperties();
        }

        /// <summary>
        /// The pagination information
        /// </summary>
        public GraphQLQueryField PageInfoQueryField { get; private set; }

        public GraphQLQueryField UsersQueryField { get; private set; }

        public GraphQLQueryField MediaQueryField { get; private set; }

        public GraphQLQueryField CharactersQueryField { get; private set; }

        public GraphQLQueryField StaffQueryField { get; private set; }

        public GraphQLQueryField StudiosQueryField { get; private set; }

        public GraphQLQueryField MediaListQueryField { get; private set; }

        public GraphQLQueryField AiringSchedulesQueryField { get; private set; }

        public GraphQLQueryField FollowersQueryField { get; private set; }

        public GraphQLQueryField FollowingsQueryField { get; private set; }

        public GraphQLQueryField ActivityRepliesQueryField { get; private set; }

        public GraphQLQueryField ThreadsQueryField { get; private set; }

        public GraphQLQueryField ThreadCommentsQueryField { get; private set; }

        public GraphQLQueryField ReviewsQueryField { get; private set; }

        private void InitializeProperties()
        {
            PageInfoQueryField = new GraphQLQueryField("pageInfo", new FieldRules(false));
            UsersQueryField = new GraphQLQueryField("users", new FieldRules(false));
            MediaQueryField = new GraphQLQueryField("media", new FieldRules(false));
            CharactersQueryField = new GraphQLQueryField("characters", new FieldRules(false));
            StaffQueryField = new GraphQLQueryField("staff", new FieldRules(false));
            StudiosQueryField = new GraphQLQueryField("studios", new FieldRules(false));
            MediaListQueryField = new GraphQLQueryField("mediaList", new FieldRules(false));
            AiringSchedulesQueryField = new GraphQLQueryField("airingSchedules", new FieldRules(false));
            FollowersQueryField = new GraphQLQueryField("followers", new FieldRules(false));
            FollowingsQueryField = new GraphQLQueryField("followings", new FieldRules(false));
            ActivityRepliesQueryField = new GraphQLQueryField("activityReplies", new FieldRules(false));
            ThreadsQueryField = new GraphQLQueryField("threads", new FieldRules(false));
            ThreadCommentsQueryField = new GraphQLQueryField("threadComments", new FieldRules(false));
            ReviewsQueryField = new GraphQLQueryField("reviews", new FieldRules(false));
        }
    }
}
