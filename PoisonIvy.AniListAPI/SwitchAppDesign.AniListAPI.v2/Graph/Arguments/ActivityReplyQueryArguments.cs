using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Models;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Arguments
{
    internal class ActivityReplyQueryArguments
    {
        public ActivityReplyQueryArguments()
        {
            InitializeProperties();
        }


        /// <summary>
        /// Filter by the reply id.
        /// </summary>
        public GraphQLQueryArgument<int> IdQueryArgument(int value)
        {
            return Id.GetQueryArgumentAndSetValue(value);
        }


        /// <summary>
        /// Filter by the parent id.
        /// </summary>
        public GraphQLQueryArgument<int> ActivityIdQueryArgument(int value)
        {
            return ActivityId.GetQueryArgumentAndSetValue(value);
        }


        private GraphQLQueryArgument<int> Id { get; set; }
        private GraphQLQueryArgument<int> ActivityId { get; set; }

        private void InitializeProperties()
        {
            Id = new GraphQLQueryArgument<int>("id", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.ActivityReply }));
            ActivityId = new GraphQLQueryArgument<int>("activityId", new QueryArgumentRules(false, null, null, new List<AniListQueryType> { AniListQueryType.ActivityReply }));
        }
    }
}